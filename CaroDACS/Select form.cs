using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroDACS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult; 
            if(result == DialogResult)
            {
                Application.Exit();
            }
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        public void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
            else
            {
                e.Cancel = true;
            }
        }

        private void btnBDLan_Click(object sender, EventArgs e)
        {
            this.Hide();
            LanForm lf = new LanForm();
            lf.Show();
            
        }
    }
}


