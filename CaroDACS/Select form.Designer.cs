
namespace CaroDACS
{
    partial class Form2
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnBDLan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(151, 169);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 31);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(151, 95);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(100, 31);
            this.btnBD.TabIndex = 2;
            this.btnBD.Text = "Bắt đầu Offline";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnBDLan
            // 
            this.btnBDLan.Location = new System.Drawing.Point(151, 132);
            this.btnBDLan.Name = "btnBDLan";
            this.btnBDLan.Size = new System.Drawing.Size(100, 31);
            this.btnBDLan.TabIndex = 3;
            this.btnBDLan.Text = "Bắt đầu LAN";
            this.btnBDLan.UseVisualStyleBackColor = true;
            this.btnBDLan.Click += new System.EventHandler(this.btnBDLan_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 286);
            this.Controls.Add(this.btnBDLan);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.btnThoat);
            this.Name = "Form2";
            this.Text = "Cờ Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btnBDLan;
    }
}