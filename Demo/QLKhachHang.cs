using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class QLKhachHang : Form
    {
        private bool modeNew;
        private int row;
        String connectString = @"Data Source=LAPTOP-SRK3A3P7;Initial Catalog=QLCH;Integrated Security=True;";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public QLKhachHang()
        {
            InitializeComponent();
            SetControl(true);
        }
        
        private void SetControl(bool edit)
        {
            txtmkh.Enabled = edit;
            txtten.Enabled = edit;
            txtsdt.Enabled = edit;
            btnThem.Enabled = edit;
            btnXoa.Enabled = edit;
            btnSua.Enabled = edit;
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng này?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    listView1.SelectedItems[0].Remove();
                }
            }
            else
            {
                MessageBox.Show("Chọn khách hàng mà bạn muốn xóa !");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtmkh.Text = selectedItem.SubItems[1].Text;
                txtten.Text = selectedItem.SubItems[2].Text;
                txtsdt.Text = selectedItem.SubItems[3].Text;
                SetControl(false);
                modeNew = false;
            }
            else
            {
                MessageBox.Show("Chọn khách hàng muốn chỉnh sửa", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            SetControl(false);
            txtten.Clear();
            txtsdt.Clear();
            modeNew = false;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            modeNew = true;
            SetControl(true);
            row = listView1.Items.Count;
            txtmkh.Text = Convert.ToString(row + 1);

            if (modeNew)
            {
                ListViewItem newItem = new ListViewItem(txtmkh.Text);
                newItem.SubItems.Add(txtten.Text);
                string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                newItem.SubItems.Add(gioiTinh);

                listView1.Items.Add(newItem);
                newItem.SubItems.Add(txtsdt.Text);

       
               
            }
            else
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItems = listView1.SelectedItems[0];
                    selectedItems.SubItems[1].Text = txtten.Text;
                    string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                    selectedItems.SubItems[5].Text = gioiTinh;
                    selectedItems.SubItems[6].Text = txtsdt.Text;                  
                }
            }

            txtten.Clear();
            txtsdt.Clear();
            txtmkh.Focus();
            modeNew = false;
            SetControl(false);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
            QLKhachHang qlkh= new QLKhachHang();
            qlkh.Close();
            Hide();
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                // Lặp qua từng mục trong ListView và chèn dữ liệu vào cơ sở dữ liệu
                foreach (ListViewItem item in listView1.Items)
                {
                    string maKH = item.SubItems[0].Text;
                    string hoTen = item.SubItems[1].Text;
                    string taikhoan = item.SubItems[2].Text;
                    string matkhau = item.SubItems[3].Text;
                    string diachi = item.SubItems[4].Text;
                    string gioitinh = item.SubItems[5].Text;
                    string sodienthoai = item.SubItems[6].Text;

                    // Tạo câu lệnh SQL INSERT cho bảng KhachHang
                    string sqlInsertKhachHang = "INSERT INTO KhachHang (MaKH, HoVaTen, TaiKhoan, MatKhau, DiaChi, GioiTinh, SDT) " +
                                           "VALUES (@MaKH, @HoTen, @TaiKhoan, @MatKhau, @DiaChi, @GioiTinh, @SoDienThoai)";

                    // Tạo và thực thi SqlCommand cho bảng KhachHang
                    using (SqlCommand commandKhachHang = new SqlCommand(sqlInsertKhachHang, connection))
                    {
                        // Thêm các tham số vào câu lệnh SQL cho bảng KhachHang
                        commandKhachHang.Parameters.AddWithValue("@MaKH", maKH);
                        commandKhachHang.Parameters.AddWithValue("@HoTen", hoTen);
                        commandKhachHang.Parameters.AddWithValue("@GioiTinh", gioitinh);
                        commandKhachHang.Parameters.AddWithValue("@SoDienThoai", sodienthoai);

                        // Thực thi câu lệnh SQL cho bảng KhachHang
                        commandKhachHang.ExecuteNonQuery();
                    }

                 
                   
                }
            }

            // Hiển thị thông báo khi lưu dữ liệu thành công
            MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng này?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Nếu người dùng đồng ý xóa
                if (result == DialogResult.OK)
                {
                    // Xóa mục được chọn khỏi ListView
                    listView1.SelectedItems[0].Remove();
                }
            }
            else
            {
                MessageBox.Show("Chọn khách hàng mà bạn muốn xóa !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Font = new Font("Times New Roman", 12);

            try
            {
                conn = new SqlConnection(connectString);
                conn.Open();
                cmd = new SqlCommand("select * from KhachHang", conn);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                listView1.Items.Clear(); // Xóa các mục hiện có trước khi thêm mục mới

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["maKH"].ToString()); // Thay "ColumnName1" bằng tên cột thực tế
                    item.SubItems.Add(row["HoTen"].ToString()); // Thêm các mục phụ cho các cột bổ sung
                    item.SubItems.Add(row["GioiTinh"].ToString());
                    item.SubItems.Add(row["SDT"].ToString());// Lặp lại điều này cho mỗi cột bạn muốn hiển thị
                    listView1.Items.Add(item);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Xem xét ghi lại ngoại lệ cho mục đích gỡ lỗi
            }
        }


        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
               
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtten.Text = selectedItem.SubItems[1].Text;
                txtsdt.Text = selectedItem.SubItems[2].Text;
                txtmkh.Text = selectedItem.SubItems[3].Text;
               
                SetControl(false);
                modeNew = false;
            }
            else
            {
                MessageBox.Show("Chọn khách hàng muốn chỉnh sửa", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNhapLai_Click_1(object sender, EventArgs e)
        {
            SetControl(false);
            txtten.Clear();
            txtsdt.Clear();
            txtmkh.Clear();
           
            modeNew = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
            
