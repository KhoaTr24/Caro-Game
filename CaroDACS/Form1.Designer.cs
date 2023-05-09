namespace CaroDACS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelChess = new System.Windows.Forms.Panel();
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnnewgame = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txbTime = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.prcbTime = new System.Windows.Forms.ProgressBar();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChess
            // 
            this.panelChess.Location = new System.Drawing.Point(9, 10);
            this.panelChess.Margin = new System.Windows.Forms.Padding(2);
            this.panelChess.Name = "panelChess";
            this.panelChess.Size = new System.Drawing.Size(619, 508);
            this.panelChess.TabIndex = 0;
            // 
            // panelAvatar
            // 
            this.panelAvatar.Controls.Add(this.picAvatar);
            this.panelAvatar.Location = new System.Drawing.Point(633, 10);
            this.panelAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(262, 285);
            this.panelAvatar.TabIndex = 1;
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
            // panelName
            // 
            this.panelName.Controls.Add(this.btnUndo);
            this.panelName.Controls.Add(this.btnExit);
            this.panelName.Controls.Add(this.btnnewgame);
            this.panelName.Controls.Add(this.picLogo);
            this.panelName.Controls.Add(this.txbTime);
            this.panelName.Controls.Add(this.txbName);
            this.panelName.Controls.Add(this.prcbTime);
            this.panelName.Location = new System.Drawing.Point(632, 299);
            this.panelName.Margin = new System.Windows.Forms.Padding(2);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(262, 219);
            this.panelName.TabIndex = 2;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(4, 86);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(156, 23);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.txbTime.Size = new System.Drawing.Size(92, 20);
            this.txbTime.TabIndex = 3;
            this.txbTime.Text = "Countdown Timer";
            this.txbTime.TextChanged += new System.EventHandler(this.txbTime_TextChanged);
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
            this.prcbTime.Size = new System.Drawing.Size(92, 20);
            this.prcbTime.TabIndex = 0;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 524);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.panelAvatar);
            this.Controls.Add(this.panelChess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Cờ Caro ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChess;
        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ProgressBar prcbTime;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnnewgame;
        private System.Windows.Forms.Timer timer1;
    }
}

