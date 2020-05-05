using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FormClient : Form
    {
        private NetworkStream m_networkstream; //네트워크 스트림
        private TcpListener m_server;
        private TcpClient m_client;

        private byte[] sendBuffer = new byte[1024 * 4]; 
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bConnect = false; //서버 접속 플래그

        public Initialize m_initializeClass; //초기화 데이터 패킷
        public Select m_selectClass; //beforeSelect 데이터 패킷
        public Expand m_expandClass; //beforeExpand 데이터 패킷

        public FormClient()
        {
            InitializeComponent();
        }
        //'서버연결' 버튼 클릭
        private void btnServer_Click(object sender, EventArgs e)
        {
            //경로 설정 확인
            if (txtDownload.Text == "")
            {
                MessageBox.Show("경로가 설정되어있지 않습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //서버 연결
            if (btnServer.Text == "서버연결")
            {
                //버튼 텍스트, 색상 변경
                btnServer.Text = "서버차단";
                btnServer.ForeColor = Color.Red;
                //서버 연결 요청
                this.m_client = new TcpClient();
                try
                {
                    int port = Convert.ToInt32(txtPort.Text);
                    this.m_client.Connect(txtIp.Text, port);
                }catch
                {
                    MessageBox.Show("접속 에러");
                    return;
                }
                //클라이언트 스트림 값
                this.m_bConnect = true;
                this.m_networkstream = this.m_client.GetStream();
                //초기화 데이터 요청
                InitDirectoryInfo();
            }
            //서버 연결 종료
            else
            {
                btnServer.Text = "서버연결";
                btnServer.ForeColor = Color.Black;

                //종료 패킷 생성
                Exit exit = new Exit();
                exit.Type = (int)PacketType.종료;

                //종료 패킷 전송
                Packet.Serialize(exit).CopyTo(this.sendBuffer, 0);
                this.Send();

                this.m_client.Close();
                this.m_networkstream.Close();
                this.m_client = null;


            }
        }
        //초기화 데이터 요청
        private void InitDirectoryInfo()
        {
            TreeNode root;
            DirectoryInfo[] diarray;
            FileInfo[] fiarray;

            if (!this.m_bConnect)
            {
                return;
            }
            //초기화 패킷 생성
            Initialize Init = new Initialize();
            Init.Type = (int)PacketType.초기화;

            //초기화 패킷 요청 전송
            Packet.Serialize(Init).CopyTo(this.sendBuffer, 0);
            this.Send();

            //초기화 패킷 읽기
            this.m_networkstream.Read(readBuffer, 0, 1024 * 4);
            Initialize packet = (Initialize)Packet.Desserialize(this.readBuffer);
            //TreeView 초기화 데이터 반영(디렉토리)
            diarray = packet.Drv_list.GetDirectories();
            foreach (DirectoryInfo dirs in diarray)
            {
                root = treeView.Nodes.Add(dirs.Name);
                root.ImageIndex = 0;

                if (treeView.SelectedNode == null)
                    treeView.SelectedNode = root;
                root.SelectedImageIndex = root.ImageIndex;
                root.Nodes.Add("");
            }
            //TreeView 초기화 데이터 반영(파일)
            fiarray = packet.Drv_list.GetFiles();
            foreach (FileInfo fis in fiarray)
            {
                root = treeView.Nodes.Add(fis.Name);
                string[] movie = { ".avi", ".mp4" };
                if(movie.Contains<string>(Path.GetExtension(fis.Name).))
                {
                    root.ImageIndex = 1;
                }else if()
                {

                }else if()
                {

                }else if()
                {

                }
                else
                {

                }


                if (treeView.SelectedNode == null)
                    treeView.SelectedNode = root;
                root.SelectedImageIndex = root.ImageIndex;
                root.Nodes.Add("");
            }
        }
        //'경로설정' 버튼 클릭
        private void btnPath_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog 실행 후 경로 선택
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDownload.Text = fbd.SelectedPath;
                fbd.SelectedPath = "";
            }
        }
        // 패킷 정보 전송
        public void Send()
        {
            this.m_networkstream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkstream.Flush();

            for(int i = 0; i < 1024 * 4; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }
        //보조메뉴 버튼 클릭 이벤트
        private void mnuView_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            mnuDetail.Checked = false;
            mnuSimple.Checked = false;
            mnuSmall.Checked = false;
            mnuLarge.Checked = false;


            switch(item.Text)
            {
                case "자세히":
                    {
                        mnuDetail.Checked = true;
                        lvF.View = View.Details;
                        break;
                    }
                case "간단히":
                    {
                        mnuSimple.Checked = true;
                        lvF.View = View.List;
                        break;
                    }
                case "작은 아이콘":
                    {
                        mnuSmall.Checked = true;
                        lvF.View = View.SmallIcon;
                        break;
                    }
                case "큰 아이콘":
                    {
                        mnuLarge.Checked = true;
                        lvF.View = View.LargeIcon;
                        break;
                    }
            }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {

        }
    }
}
