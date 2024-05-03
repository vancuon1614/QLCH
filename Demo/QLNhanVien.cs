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
    public partial class QLNhanVien : Form
    {
        private bool modeNew;
        private int row;
        public QLNhanVien()
        {
            InitializeComponent();
            SetControl(true);
        }
        String connectString = @"Data Source=LAPTOP-SRK3A3P7;Initial Catalog=QLCH;Integrated Security=True;";
        private void SetControl(bool edit)
        {
            txtMnv.Enabled = edit;
            txtTnv.Enabled = edit;
            txtNs.Enabled = edit;
            txtTk.Enabled = edit;
            txtMk.Enabled = edit;
            txtVt.Enabled = edit;
            txtSdt.Enabled = edit;
            btnThem.Enabled = edit;
            btnXoa.Enabled = edit;
            btnSua.Enabled = edit;
            btnNhapLai.Enabled = edit;
            btnDong.Enabled = edit;
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
                txtMnv.Text = selectedItem.SubItems[1].Text;
                txtTnv.Text = selectedItem.SubItems[2].Text;
                txtNs.Text = selectedItem.SubItems[3].Text;
                txtVt.Text = selectedItem.SubItems[4].Text;
                txtSdt.Text = selectedItem.SubItems[5].Text;
                txtTk.Text = selectedItem.SubItems[6].Text;
                txtMk.Text = selectedItem.SubItems[7].Text;
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
            txtMnv.Clear();
            txtTnv.Clear();
            txtSdt.Clear();
            txtTk.Clear();
            txtMk.Clear();
            txtNs.Clear();
            txtVt.Clear();
            modeNew = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            modeNew = true;
            SetControl(true);
            row = listView1.Items.Count;
            txtMnv.Text = Convert.ToString(row + 1);

            if (modeNew)
            {
                ListViewItem newItem = new ListViewItem(txtMnv.Text);
                newItem.SubItems.Add(txtTnv.Text);
                newItem.SubItems.Add(txtNs.Text);     
                string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                newItem.SubItems.Add(gioiTinh);
                listView1.Items.Add(newItem);
                newItem.SubItems.Add(txtVt.Text);
                newItem.SubItems.Add(txtSdt.Text);
                newItem.SubItems.Add(txtTk.Text);
                newItem.SubItems.Add(txtMk.Text);
            }
            else
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItems = listView1.SelectedItems[0];
                    selectedItems.SubItems[1].Text = txtMnv.Text;
                    selectedItems.SubItems[2].Text = txtTnv.Text;
                    selectedItems.SubItems[3].Text = txtNs.Text;
                    string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                    selectedItems.SubItems[4].Text = txtVt.Text;
                    selectedItems.SubItems[5].Text = gioiTinh;
                    selectedItems.SubItems[6].Text = txtSdt.Text;
                    selectedItems.SubItems[7].Text = txtTk.Text;
                    selectedItems.SubItems[8].Text = txtMk.Text;
                }
            }

            txtMnv.Clear();
            txtTnv.Clear();
            txtSdt.Clear();
            txtTk.Clear();
            txtMk.Clear();
            txtNs.Clear();
            txtVt.Clear();

            txtMnv.Focus();
            modeNew = false;
            SetControl(false);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
            QLNhanVien qlnv = new QLNhanVien();
            qlnv.Close();
            Hide();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                // Lặp qua từng mục trong ListView và chèn dữ liệu vào cơ sở dữ liệu
                foreach (ListViewItem item in listView1.Items)
                {
                    string manv = item.SubItems[0].Text;
                    string hoten = item.SubItems[1].Text;
                    string ngaysinh = item.SubItems[2].Text;
                    string gioitinh = item.SubItems[3].Text;
                    string vitri = item.SubItems[4].Text;
                    string sdt = item.SubItems[5].Text;
                    string tendangnhap = item.SubItems[6].Text;
                    string matkhau = item.SubItems[7].Text;

                    // Tạo câu lệnh SQL INSERT
                    string sqlInsert = "INSERT INTO NhanVien (MaNV, TenNV, ViTri, SDT, NgaySinh, GioiTinh, TaiKhoan, MatKhau) " +
                                       "VALUES (@MaNV, @TenNV, @ViTri, @SDT, @NgaySinh, @GioiTinh, @TaiKhoan, @MatKhau)";

                    // Tạo và thực thi SqlCommand
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@MaNV", manv);
                        command.Parameters.AddWithValue("@TenNV", hoten);
                        command.Parameters.AddWithValue("@ViTri", vitri);
                        command.Parameters.AddWithValue("@SDT", sdt);
                        command.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                        command.Parameters.AddWithValue("@GioiTinh", gioitinh);
                        command.Parameters.AddWithValue("@TaiKhoan", tendangnhap);
                        command.Parameters.AddWithValue("@MatKhau", matkhau);

                        // Thực thi câu lệnh SQL
                        command.ExecuteNonQuery();
                    }
                }
            }

            // Hiển thị thông báo khi lưu dữ liệu thành công
            MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
