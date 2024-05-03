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
    public partial class TrangChu : Form
    {
        String connectString = @"Data Source=LAPTOP-SRK3A3P7;Initial Catalog=QLCH;Integrated Security=True;";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public TrangChu()
        {
            InitializeComponent();
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

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNhanVien nhanVien = new QLNhanVien();
            nhanVien.Show();
            Hide();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKhachHang khachHang = new QLKhachHang();
            khachHang.Show();
            Hide();

        }
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*QLSanPham sanPham = new QLSanPham();
            sanPham.Show();
            Hide();*/
            OpenChildForm(new QLSanPham());
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            Hide() ;
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*QLHoaDon qLHoaDon = new QLHoaDon();
            qLHoaDon.Show();
            Hide();*/
        }
        private void quanrtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Sản Phẩm";
            if (dt.Rows.Count > 0)
            {

                dt.Clear();
                try
                {
                    conn = new SqlConnection(connectString);
                    conn.Open();
                    cmd = new SqlCommand("select * from SanPham", conn);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable(); 
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    conn = new SqlConnection(connectString);
                    conn.Open();
                    cmd = new SqlCommand("select * from SanPham", conn);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable(); 
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn = new SqlConnection(connectString);

        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khachhang_Click(object sender, EventArgs e)
        {
            label1.Text = "Khách Hàng";
            if (dt.Rows.Count > 0)
            {

                dt.Clear();
                try
                {
                    conn = new SqlConnection(connectString);
                    conn.Open();
                    cmd = new SqlCommand("select * from KhachHang", conn);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                
                try
                {
                    conn = new SqlConnection(connectString);
                    conn.Open();
                    cmd = new SqlCommand("select * from KhachHang", conn);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable(); 
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "Nhân Viên";
            if (dt.Rows.Count > 0)
            {

                dt.Clear();
                try
                {
                    conn = new SqlConnection(connectString);
                    conn.Open();
                    cmd = new SqlCommand("select * from NhanVien", conn);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable(); 
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
              
                try
                {
                    conn = new SqlConnection(connectString);
                    conn.Open();
                    cmd = new SqlCommand("select * from NhanVien", conn);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable(); 
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void hóaĐơnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Text = "Hóa Đơn";
            if (dt.Rows.Count > 0)
            {
              
                dt.Clear();
                try
                {
                    conn = new SqlConnection(connectString);
                    conn.Open();
                    cmd = new SqlCommand("select * from HoaDon", conn);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable(); // Khởi tạo DataTable mới
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // Nếu không có dòng, bạn cần tải dữ liệu từ cơ sở dữ liệu vào DataTable trước khi thao tác
                try
                {
                    conn = new SqlConnection(connectString);
                    conn.Open();
                    cmd = new SqlCommand("select * from HoaDon", conn);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable(); // Khởi tạo DataTable mới
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            Hide();
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            frmQLcs ql = new frmQLcs();
            ql.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
