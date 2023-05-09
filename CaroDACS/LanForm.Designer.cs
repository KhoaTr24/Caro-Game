
namespace CaroDACS
{
    partial class LanForm
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
            this.components = new System.ComponentModel.Container();
            this.panelName = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnnewgame = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txbTime = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.prcbTime = new System.Windows.Forms.ProgressBar();
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panelChess = new System.Windows.Forms.Panel();
            this.tmCoolDown2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbChat = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHost = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.btnUndo);
            this.panelName.Controls.Add(this.btnExit);
            this.panelName.Controls.Add(this.btnnewgame);
            this.panelName.Controls.Add(this.picLogo);
            this.panelName.Controls.Add(this.txbTime);
            this.panelName.Controls.Add(this.txbName);
            this.panelName.Controls.Add(this.prcbTime);
            this.panelName.Location = new System.Drawing.Point(636, 300);
            this.panelName.Margin = new System.Windows.Forms.Padding(2);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(262, 219);
            this.panelName.TabIndex = 5;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(4, 86);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(155, 23);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(132, 122);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 94);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnnewgame
            // 
            this.btnnewgame.Location = new System.Drawing.Point(4, 122);
            this.btnnewgame.Name = "btnnewgame";
            this.btnnewgame.Size = new System.Drawing.Size(122, 94);
            this.btnnewgame.TabIndex = 6;
            this.btnnewgame.Text = "New Game";
            this.btnnewgame.UseVisualStyleBackColor = true;
            this.btnnewgame.Click += new System.EventHandler(this.btnnewgame_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(164, 13);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(93, 97);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // txbTime
            // 
            this.txbTime.BackColor = System.Drawing.SystemColors.Highlight;
            this.txbTime.Location = new System.Drawing.Point(4, 37);
            this.txbTime.Margin = new System.Windows.Forms.Padding(2);
            this.txbTime.Name = "txbTime";
            this.txbTime.ReadOnly = true;
            this.txbTime.Size = new System.Drawing.Size(155, 20);
            this.txbTime.TabIndex = 3;
            this.txbTime.Text = "Countdown Timer";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(4, 13);
            this.txbName.Margin = new System.Windows.Forms.Padding(2);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(156, 20);
            this.txbName.TabIndex = 5;
            // 
            // prcbTime
            // 
            this.prcbTime.ForeColor = System.Drawing.Color.LightGreen;
            this.prcbTime.Location = new System.Drawing.Point(4, 61);
            this.prcbTime.Margin = new System.Windows.Forms.Padding(2);
            this.prcbTime.Name = "prcbTime";
            this.prcbTime.Size = new System.Drawing.Size(155, 20);
            this.prcbTime.TabIndex = 0;
            // 
            // panelAvatar
            // 
            this.panelAvatar.Controls.Add(this.picAvatar);
            this.panelAvatar.Location = new System.Drawing.Point(634, 11);
            this.panelAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(262, 285);
            this.panelAvatar.TabIndex = 4;
            // 
            // picAvatar
            // 
            this.picAvatar.BackgroundImage = global::CaroDACS.Properties.Resources.unnamed;
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar.Location = new System.Drawing.Point(2, 2);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(258, 280);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // panelChess
            // 
            this.panelChess.Location = new System.Drawing.Point(11, 11);
            this.panelChess.Margin = new System.Windows.Forms.Padding(2);
            this.panelChess.Name = "panelChess";
            this.panelChess.Size = new System.Drawing.Size(619, 508);
            this.panelChess.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbChat);
            this.panel1.Location = new System.Drawing.Point(899, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 285);
            this.panel1.TabIndex = 6;
            // 
            // txbChat
            // 
            this.txbChat.Location = new System.Drawing.Point(5, 3);
            this.txbChat.Multiline = true;
            this.txbChat.Name = "txbChat";
            this.txbChat.Size = new System.Drawing.Size(250, 279);
            this.txbChat.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.txbStatus);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Controls.Add(this.btnHost);
            this.panel2.Controls.Add(this.txbIP);
            this.panel2.Controls.Add(this.btnsend);
            this.panel2.Controls.Add(this.txbMessage);
            this.panel2.Location = new System.Drawing.Point(899, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 215);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP : ";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(177, 63);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(78, 40);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Dừng";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(5, 109);
            this.txbStatus.Multiline = true;
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(250, 103);
            this.txbStatus.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(95, 63);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(76, 40);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(5, 63);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(84, 40);
            this.btnHost.TabIndex = 3;
            this.btnHost.Text = "Host";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(67, 37);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(188, 20);
            this.txbIP.TabIndex = 2;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(5, 6);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(56, 25);
            this.btnsend.TabIndex = 1;
            this.btnsend.Text = "Gửi";
            this.btnsend.UseVisualStyleBackColor = true;
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(67, 6);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(188, 25);
            this.txbMessage.TabIndex = 0;
            // 
            // LanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.panelAvatar);
            this.Controls.Add(this.panelChess);
            this.Name = "LanForm";
            this.Text = "LanForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LanForm_FormClosing);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnnewgame;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ProgressBar prcbTime;
        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel panelChess;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.TextBox txbChat;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmCoolDown2;
    }
}