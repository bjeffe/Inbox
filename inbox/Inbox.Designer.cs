namespace inbox
{
    partial class Inbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inbox));
            this.textBoxcount = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.treeViewmails = new System.Windows.Forms.TreeView();
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.buttonConnectandRetreive = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.labelpopserver = new System.Windows.Forms.Label();
            this.textBoxPopserver = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxSMTPServer = new System.Windows.Forms.TextBox();
            this.labelSTMPServer = new System.Windows.Forms.Label();
            this.textBoxPopPort = new System.Windows.Forms.TextBox();
            this.labelpopport = new System.Windows.Forms.Label();
            this.textBoxSMTPport = new System.Windows.Forms.TextBox();
            this.labelSMTPPort = new System.Windows.Forms.Label();
            this.checkBoxssl = new System.Windows.Forms.CheckBox();
            this.buttonNewMail = new System.Windows.Forms.Button();
            this.labelMailCount = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerGetMails = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custoumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxcount
            // 
            this.textBoxcount.Enabled = false;
            this.textBoxcount.Location = new System.Drawing.Point(713, 33);
            this.textBoxcount.Name = "textBoxcount";
            this.textBoxcount.Size = new System.Drawing.Size(53, 20);
            this.textBoxcount.TabIndex = 0;
            this.textBoxcount.TabStop = false;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(190, 141);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(454, 262);
            this.textBoxMessage.TabIndex = 1;
            this.textBoxMessage.TabStop = false;
            // 
            // treeViewmails
            // 
            this.treeViewmails.Location = new System.Drawing.Point(13, 141);
            this.treeViewmails.Name = "treeViewmails";
            this.treeViewmails.Size = new System.Drawing.Size(171, 262);
            this.treeViewmails.TabIndex = 2;
            this.treeViewmails.TabStop = false;
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.Location = new System.Drawing.Point(650, 141);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.Size = new System.Drawing.Size(121, 262);
            this.treeViewFiles.TabIndex = 3;
            this.treeViewFiles.TabStop = false;
            // 
            // buttonConnectandRetreive
            // 
            this.buttonConnectandRetreive.Location = new System.Drawing.Point(560, 33);
            this.buttonConnectandRetreive.Name = "buttonConnectandRetreive";
            this.buttonConnectandRetreive.Size = new System.Drawing.Size(84, 43);
            this.buttonConnectandRetreive.TabIndex = 8;
            this.buttonConnectandRetreive.Text = "Connect and Retreive";
            this.buttonConnectandRetreive.UseVisualStyleBackColor = true;
            this.buttonConnectandRetreive.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFile
            // 
            this.saveFile.Title = "Save Attachment";
            // 
            // labelpopserver
            // 
            this.labelpopserver.AutoSize = true;
            this.labelpopserver.Location = new System.Drawing.Point(12, 33);
            this.labelpopserver.Name = "labelpopserver";
            this.labelpopserver.Size = new System.Drawing.Size(60, 13);
            this.labelpopserver.TabIndex = 5;
            this.labelpopserver.Text = "Pop Server";
            // 
            // textBoxPopserver
            // 
            this.textBoxPopserver.Location = new System.Drawing.Point(79, 33);
            this.textBoxPopserver.Name = "textBoxPopserver";
            this.textBoxPopserver.Size = new System.Drawing.Size(100, 20);
            this.textBoxPopserver.TabIndex = 1;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(254, 33);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(100, 20);
            this.textBoxusername.TabIndex = 4;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(187, 33);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(55, 13);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "Username";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(427, 33);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 6;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(360, 33);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(53, 13);
            this.labelPass.TabIndex = 9;
            this.labelPass.Text = "Password";
            // 
            // textBoxSMTPServer
            // 
            this.textBoxSMTPServer.Location = new System.Drawing.Point(79, 66);
            this.textBoxSMTPServer.Name = "textBoxSMTPServer";
            this.textBoxSMTPServer.Size = new System.Drawing.Size(100, 20);
            this.textBoxSMTPServer.TabIndex = 2;
            // 
            // labelSTMPServer
            // 
            this.labelSTMPServer.AutoSize = true;
            this.labelSTMPServer.Location = new System.Drawing.Point(12, 66);
            this.labelSTMPServer.Name = "labelSTMPServer";
            this.labelSTMPServer.Size = new System.Drawing.Size(69, 13);
            this.labelSTMPServer.TabIndex = 11;
            this.labelSTMPServer.Text = "SMTP server";
            // 
            // textBoxPopPort
            // 
            this.textBoxPopPort.Location = new System.Drawing.Point(254, 66);
            this.textBoxPopPort.Name = "textBoxPopPort";
            this.textBoxPopPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPopPort.TabIndex = 5;
            // 
            // labelpopport
            // 
            this.labelpopport.AutoSize = true;
            this.labelpopport.Location = new System.Drawing.Point(187, 66);
            this.labelpopport.Name = "labelpopport";
            this.labelpopport.Size = new System.Drawing.Size(48, 13);
            this.labelpopport.TabIndex = 13;
            this.labelpopport.Text = "Pop Port";
            // 
            // textBoxSMTPport
            // 
            this.textBoxSMTPport.Location = new System.Drawing.Point(427, 66);
            this.textBoxSMTPport.Name = "textBoxSMTPport";
            this.textBoxSMTPport.Size = new System.Drawing.Size(100, 20);
            this.textBoxSMTPport.TabIndex = 7;
            // 
            // labelSMTPPort
            // 
            this.labelSMTPPort.AutoSize = true;
            this.labelSMTPPort.Location = new System.Drawing.Point(360, 66);
            this.labelSMTPPort.Name = "labelSMTPPort";
            this.labelSMTPPort.Size = new System.Drawing.Size(59, 13);
            this.labelSMTPPort.TabIndex = 15;
            this.labelSMTPPort.Text = "SMTP Port";
            // 
            // checkBoxssl
            // 
            this.checkBoxssl.AutoSize = true;
            this.checkBoxssl.Checked = true;
            this.checkBoxssl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxssl.Location = new System.Drawing.Point(15, 97);
            this.checkBoxssl.Name = "checkBoxssl";
            this.checkBoxssl.Size = new System.Drawing.Size(46, 17);
            this.checkBoxssl.TabIndex = 3;
            this.checkBoxssl.Text = "SSL";
            this.checkBoxssl.UseVisualStyleBackColor = true;
            // 
            // buttonNewMail
            // 
            this.buttonNewMail.Location = new System.Drawing.Point(560, 83);
            this.buttonNewMail.Name = "buttonNewMail";
            this.buttonNewMail.Size = new System.Drawing.Size(84, 43);
            this.buttonNewMail.TabIndex = 18;
            this.buttonNewMail.TabStop = false;
            this.buttonNewMail.Text = "New Mail";
            this.buttonNewMail.UseVisualStyleBackColor = true;
            this.buttonNewMail.Click += new System.EventHandler(this.buttonNewMail_Click);
            // 
            // labelMailCount
            // 
            this.labelMailCount.AutoSize = true;
            this.labelMailCount.Location = new System.Drawing.Point(650, 36);
            this.labelMailCount.Name = "labelMailCount";
            this.labelMailCount.Size = new System.Drawing.Size(57, 13);
            this.labelMailCount.TabIndex = 19;
            this.labelMailCount.Text = "Mail Count";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 409);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(758, 23);
            this.progressBar.TabIndex = 20;
            this.progressBar.Visible = false;
            // 
            // backgroundWorkerGetMails
            // 
            this.backgroundWorkerGetMails.WorkerReportsProgress = true;
            this.backgroundWorkerGetMails.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGetMails_DoWork);
            this.backgroundWorkerGetMails.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerGetMails_ProgressChanged);
            this.backgroundWorkerGetMails.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerGetMails_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.startToolStripMenuItem.Text = "File";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defualToolStripMenuItem,
            this.GreenToolStripMenuItem,
            this.redToolStripMenuItem,
            this.custoumToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // defualToolStripMenuItem
            // 
            this.defualToolStripMenuItem.Name = "defualToolStripMenuItem";
            this.defualToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.defualToolStripMenuItem.Text = "Default";
            this.defualToolStripMenuItem.Click += new System.EventHandler(this.defualToolStripMenuItem_Click);
            // 
            // GreenToolStripMenuItem
            // 
            this.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem";
            this.GreenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.GreenToolStripMenuItem.Text = "Green";
            this.GreenToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // custoumToolStripMenuItem
            // 
            this.custoumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useToolStripMenuItem,
            this.changeToolStripMenuItem});
            this.custoumToolStripMenuItem.Name = "custoumToolStripMenuItem";
            this.custoumToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.custoumToolStripMenuItem.Text = "Custom";
            // 
            // useToolStripMenuItem
            // 
            this.useToolStripMenuItem.Name = "useToolStripMenuItem";
            this.useToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.useToolStripMenuItem.Text = "Use";
            this.useToolStripMenuItem.Click += new System.EventHandler(this.useToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 438);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelMailCount);
            this.Controls.Add(this.buttonNewMail);
            this.Controls.Add(this.checkBoxssl);
            this.Controls.Add(this.textBoxSMTPport);
            this.Controls.Add(this.labelSMTPPort);
            this.Controls.Add(this.textBoxPopPort);
            this.Controls.Add(this.labelpopport);
            this.Controls.Add(this.textBoxSMTPServer);
            this.Controls.Add(this.labelSTMPServer);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxPopserver);
            this.Controls.Add(this.labelpopserver);
            this.Controls.Add(this.buttonConnectandRetreive);
            this.Controls.Add(this.treeViewFiles);
            this.Controls.Add(this.treeViewmails);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxcount);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inbox";
            this.Text = "Mail Inbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxcount;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TreeView treeViewmails;
        private System.Windows.Forms.TreeView treeViewFiles;
        private System.Windows.Forms.Button buttonConnectandRetreive;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Label labelpopserver;
        private System.Windows.Forms.TextBox textBoxPopserver;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxSMTPServer;
        private System.Windows.Forms.Label labelSTMPServer;
        private System.Windows.Forms.TextBox textBoxPopPort;
        private System.Windows.Forms.Label labelpopport;
        private System.Windows.Forms.TextBox textBoxSMTPport;
        private System.Windows.Forms.Label labelSMTPPort;
        private System.Windows.Forms.CheckBox checkBoxssl;
        private System.Windows.Forms.Button buttonNewMail;
        private System.Windows.Forms.Label labelMailCount;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGetMails;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custoumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

