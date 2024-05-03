using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class frmQLcs : Form
    {

        public frmQLcs()
        {
            InitializeComponent();
            DangNhap dn = new DangNhap();
            string ngdung = dn.getValueUser();
            lbQL.Text = "Admin" + ngdung;
        }
        private Form CurrentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }
            CurrentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLKhachHang());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSanPham());
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLNhanVien());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLHoaDon());
            
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
