using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo
{
    public partial class DangNhap : Form
    {
        SqlConnection sqlcon = null;
        public DangNhap()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection("Data Source=NGUYENCUONG;Initial Catalog=QLCH;Integrated Security=True;");
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            string tk = textBox1.Text.Trim();
            string mk = textBox2.Text.Trim();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select * from NguoiDung where TaiKhoan = '" + tk + "'AND MatKhau = '" + mk + "'";
            sqlcmd.Connection = sqlcon;
            SqlDataReader data = sqlcmd.ExecuteReader();
            if (data.Read() == true)
            {
                MessageBox.Show("Thành công");
                data.Close();
                this.Hide();
                TrangChu trangChuForm = new TrangChu();
                trangChuForm.ShowDialog();
            }
            else { MessageBox.Show("Thất bại"); }
            data.Close();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            /*textBox2.PasswordChar = cbShow.Checked ? '\0' : '*';*/
            if(cbShow.Checked == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public string getValueUser()
        {
            return textBox1.Text;
        }
    }
}
