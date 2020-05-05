using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Net;
using ClassLibrary1;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class FormServer : Form
    {
        private NetworkStream m_networkstream; //네트워크 스트림
        private TcpListener m_listener;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bClientOn = false; //서버 접속 플래그

        private Thread m_thread;

        public Initialize m_initializeClass; //초기화 데이터 패킷
        public Select m_selectClass; //beforeSelect 데이터 패킷
        public Expand m_expandClass; //beforeExpand 데이터 패킷

        StreamReader m_reader;
        StreamWriter m_writer;

        public FormServer()
        {
            InitializeComponent();
        }
        // 경로 설정
        private void btnPath_Click(object sender, EventArgs e)
        {
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
                fbd.SelectedPath = "";
                txtLog.AppendText(txtPath.Text + "로 경로가 수정되었습니다.\r\n");
            }
        }
        // 서버 연결 & 끊기
        private void btnServer_Click(object sender, EventArgs e)
        {
            if(txtPath.Text == "")
            {
                MessageBox.Show("경로를 선택해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnServer.Text == "서버켜기")
            {
                btnServer.Text = "서버끊기";
                btnServer.ForeColor = Color.Red;
                this.m_thread = new Thread(new ThreadStart(ServerStart));
                this.m_thread.Start();
            }
            else
            {
                btnServer.Text = "서버켜기";
                btnServer.ForeColor = Color.Black;
                this.m_listener.Stop();
                this.m_networkstream.Close();
                this.m_thread.Abort();
            }
        }
        // 서버 시작
        public void ServerStart()
        {
            //IP, Port
            IPAddress IpAddr = IPAddress.Parse(txtIp.Text);
            int port = Convert.ToInt32(txtPort.Text);
            //서버 시작
            m_listener = new TcpListener(IpAddr, port);
            m_listener.Start();
            //클라이언트 접속 대기 메시지
            if (!this.m_bClientOn)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.txtLog.AppendText("클라이언트 접속 대기중...\r\n");
                }));
            }
            //클라이언트 연결 수락
            TcpClient client = this.m_listener.AcceptTcpClient();
            //클라이언트 접속 성공 메시지
            if(client.Connected)
            {
                this.m_bClientOn = true;
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.txtLog.AppendText("클라이언트 접속\r\n");
                }));
            }
            //클라이언트 스트림 값
            m_networkstream = client.GetStream();
            //읽기 & 쓰기 스트림
            m_reader = new StreamReader(m_networkstream);
            m_writer = new StreamWriter(m_networkstream);

            int nRead = 0;
            while(this.m_bClientOn)
            {
                try
                {
                    //패킷 읽기
                    nRead = 0;
                    nRead = this.m_networkstream.Read(readBuffer, 0, 1024 * 4);
                }
                catch
                {
                    this.m_bClientOn = false;
                    this.m_networkstream = null;
                }

                Packet packet = (Packet)Packet.Desserialize(this.readBuffer);

                switch((int)packet.Type)
                {
                    case (int)PacketType.초기화:
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                this.txtLog.AppendText("초기화 데이터 요청..\r\n");
                            }));
                            //초기화 패킷 생성
                            Initialize Init = new Initialize();
                            Init.Type = (int)PacketType.초기화;
                            Init.Drv_list = new DirectoryInfo(txtPath.Text);

                            //초기화 패킷 전송
                            Packet.Serialize(Init).CopyTo(this.sendBuffer, 0);
                            this.Send();
                            break;
                        }
                    case (int)PacketType.선택:
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                this.txtLog.AppendText("beforeSelect 데이터 요청..\r\n");
                            }));
                            break;
                        }
                    case (int)PacketType.확장:
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                this.txtLog.AppendText("beforeExpand 데이터 요청..\r\n");
                            }));
                            break;
                        }
                    case (int)PacketType.종료:
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                this.txtLog.AppendText("클라이언트 접속 종료\r\n");
                            }));
                            this.m_bClientOn = false;
                            break;
                        }
                }
            }
        }
        //서버 종료
        public void ServerStop()
        {

        }
        //패킷 전송
        public void Send()
        {
            this.m_networkstream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkstream.Flush();

            for(int i = 0; i < 1024 * 4; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }
    }
}
