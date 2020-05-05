namespace WindowsFormsApp2
{
    partial class FormServer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbIp = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.gbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Location = new System.Drawing.Point(12, 19);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(16, 12);
            this.lbIp.TabIndex = 0;
            this.lbIp.Text = "IP";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(8, 42);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(38, 12);
            this.lbPort.TabIndex = 1;
            this.lbPort.Text = "PORT";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(8, 67);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(37, 12);
            this.lbPath.TabIndex = 2;
            this.lbPath.Text = "PATH";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(52, 12);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(330, 21);
            this.txtIp.TabIndex = 3;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(52, 39);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(330, 21);
            this.txtPort.TabIndex = 4;
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPath.Location = new System.Drawing.Point(52, 64);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(330, 21);
            this.txtPath.TabIndex = 5;
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(388, 19);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(78, 29);
            this.btnServer.TabIndex = 6;
            this.btnServer.Text = "서버켜기";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(388, 54);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(78, 29);
            this.btnPath.TabIndex = 7;
            this.btnPath.Text = "경로선택";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Location = new System.Drawing.Point(14, 110);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(451, 254);
            this.gbLog.TabIndex = 8;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 15);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(439, 233);
            this.txtLog.TabIndex = 0;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 390);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbIp);
            this.Name = "FormServer";
            this.Text = "File Manager - Server";
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.FolderBrowserDialog fbd;
    }
}

