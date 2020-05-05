namespace WindowsFormsApp1
{
    partial class FormClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.lbIp = new System.Windows.Forms.Label();
            this.lbDownload = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtDownload = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvF = new System.Windows.Forms.ListView();
            this.contextMenuStripList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSimple = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.imageListList = new System.Windows.Forms.ImageList(this.components);
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.contextMenuStripList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Location = new System.Drawing.Point(21, 22);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(20, 12);
            this.lbIp.TabIndex = 0;
            this.lbIp.Text = "IP:";
            // 
            // lbDownload
            // 
            this.lbDownload.AutoSize = true;
            this.lbDownload.Location = new System.Drawing.Point(21, 43);
            this.lbDownload.Name = "lbDownload";
            this.lbDownload.Size = new System.Drawing.Size(85, 12);
            this.lbDownload.TabIndex = 1;
            this.lbDownload.Text = "다운로드 경로:";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(321, 22);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(42, 12);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "PORT:";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(51, 17);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(257, 21);
            this.txtIp.TabIndex = 3;
            // 
            // txtDownload
            // 
            this.txtDownload.Enabled = false;
            this.txtDownload.Location = new System.Drawing.Point(112, 40);
            this.txtDownload.Name = "txtDownload";
            this.txtDownload.Size = new System.Drawing.Size(363, 21);
            this.txtDownload.TabIndex = 4;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(369, 17);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(106, 21);
            this.txtPort.TabIndex = 5;
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(51, 67);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(83, 25);
            this.btnServer.TabIndex = 6;
            this.btnServer.Text = "서버연결";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(199, 67);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(83, 25);
            this.btnPath.TabIndex = 7;
            this.btnPath.Text = "경로설정";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(345, 67);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(83, 25);
            this.btnFolder.TabIndex = 8;
            this.btnFolder.Text = "폴더열기";
            this.btnFolder.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvF);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.treeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 352);
            this.panel1.TabIndex = 9;
            // 
            // lvF
            // 
            this.lvF.ContextMenuStrip = this.contextMenuStripList;
            this.lvF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvF.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvF.LargeImageList = this.imageListList;
            this.lvF.Location = new System.Drawing.Point(109, 0);
            this.lvF.Name = "lvF";
            this.lvF.Size = new System.Drawing.Size(373, 352);
            this.lvF.SmallImageList = this.imageListList;
            this.lvF.TabIndex = 1;
            this.lvF.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStripList
            // 
            this.contextMenuStripList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInfo,
            this.mnuDownload,
            this.toolStripMenuItem2,
            this.mnuDetail,
            this.mnuSimple,
            this.mnuSmall,
            this.mnuLarge});
            this.contextMenuStripList.Name = "contextMenuStripList";
            this.contextMenuStripList.Size = new System.Drawing.Size(139, 142);
            // 
            // mnuInfo
            // 
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(138, 22);
            this.mnuInfo.Text = "상세정보";
            // 
            // mnuDownload
            // 
            this.mnuDownload.Name = "mnuDownload";
            this.mnuDownload.Size = new System.Drawing.Size(138, 22);
            this.mnuDownload.Text = "다운로드";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(135, 6);
            // 
            // mnuDetail
            // 
            this.mnuDetail.Name = "mnuDetail";
            this.mnuDetail.Size = new System.Drawing.Size(138, 22);
            this.mnuDetail.Text = "자세히";
            this.mnuDetail.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuSimple
            // 
            this.mnuSimple.Name = "mnuSimple";
            this.mnuSimple.Size = new System.Drawing.Size(138, 22);
            this.mnuSimple.Text = "간단히";
            this.mnuSimple.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuSmall
            // 
            this.mnuSmall.Name = "mnuSmall";
            this.mnuSmall.Size = new System.Drawing.Size(138, 22);
            this.mnuSmall.Text = "작은 아이콘";
            this.mnuSmall.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuLarge
            // 
            this.mnuLarge.Name = "mnuLarge";
            this.mnuLarge.Size = new System.Drawing.Size(138, 22);
            this.mnuLarge.Text = "큰 아이콘";
            this.mnuLarge.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageListTree;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(106, 352);
            this.treeView.TabIndex = 0;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeSelect);
            // 
            // imageListTree
            // 
            this.imageListTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTree.ImageStream")));
            this.imageListTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTree.Images.SetKeyName(0, "folder.jpg");
            this.imageListTree.Images.SetKeyName(1, "avi.png");
            this.imageListTree.Images.SetKeyName(2, "image.png");
            this.imageListTree.Images.SetKeyName(3, "music.png");
            this.imageListTree.Images.SetKeyName(4, "temp.png");
            this.imageListTree.Images.SetKeyName(5, "text.png");
            // 
            // imageListList
            // 
            this.imageListList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListList.ImageStream")));
            this.imageListList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListList.Images.SetKeyName(0, "folder.png");
            this.imageListList.Images.SetKeyName(1, "avi.png");
            this.imageListList.Images.SetKeyName(2, "image.png");
            this.imageListList.Images.SetKeyName(3, "music.png");
            this.imageListList.Images.SetKeyName(4, "temp.png");
            this.imageListList.Images.SetKeyName(5, "text.png");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(106, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 352);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtDownload);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbDownload);
            this.Controls.Add(this.lbIp);
            this.Name = "FormClient";
            this.Text = "File Manager - Client";
            this.panel1.ResumeLayout(false);
            this.contextMenuStripList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.Label lbDownload;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtDownload;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripList;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.ImageList imageListList;
        private System.Windows.Forms.ToolStripMenuItem mnuInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuDownload;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuDetail;
        private System.Windows.Forms.ToolStripMenuItem mnuSimple;
        private System.Windows.Forms.ToolStripMenuItem mnuSmall;
        private System.Windows.Forms.ToolStripMenuItem mnuLarge;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.ListView lvF;
        private System.Windows.Forms.Splitter splitter1;
    }
}

