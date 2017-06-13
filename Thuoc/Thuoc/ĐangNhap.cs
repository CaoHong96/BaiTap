using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Thuoc
{
    public partial class ĐangNhap : Form
    {
        public ĐangNhap()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            GiaoDienChinh gdc = new GiaoDienChinh();
            this.Hide();
            gdc.ShowDialog();
            this.Show();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
