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
    public partial class QLSanPham : Form
    {
        private bool modeNew;
        private int row;
        public QLSanPham()
        {
            InitializeComponent();
            SetControl(true);
        }
        String connectString = @"Data Source=LAPTOP-SRK3A3P7;Initial Catalog=QLCH;Integrated Security=True;";

        private void SetControl(bool edit)
        {
            txtmsp.Enabled = edit;
            txttsp.Enabled = edit;
            txtgn.Enabled = edit;
            txtgx.Enabled = edit;
            txttt.Enabled = edit;
            txtnn.Enabled = edit;
            txtsln.Enabled = edit;
            txtdb.Enabled = edit;
            txtcl.Enabled = edit;
            txtctsx.Enabled = edit;
            btnThem.Enabled = edit;
            btnXoa.Enabled = edit;
            btnSua.Enabled = edit;
            btnNhapLai.Enabled = edit;
            btnDong.Enabled = edit;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            modeNew = true;
            SetControl(true);
            row = listView1.Items.Count;
            txtmsp.Text = Convert.ToString(row + 1);
            if (modeNew)
            {
                ListViewItem newItem = new ListViewItem(txtmsp.Text);
                newItem.SubItems.Add(txttsp.Text);
                newItem.SubItems.Add(txtgn.Text);
                newItem.SubItems.Add(txtgx.Text);
                newItem.SubItems.Add(txttt.Text);
                newItem.SubItems.Add(txtnn.Text);
                newItem.SubItems.Add(txtsln.Text);
                newItem.SubItems.Add(txtdb.Text);
                newItem.SubItems.Add(txtcl.Text);
                newItem.SubItems.Add(txtctsx.Text);
                listView1.Items.Add(newItem);

                // Xóa nội dung của các hộp văn bản sau khi thêm dữ liệu vào ListViewItem
                txttsp.Clear();
                txtgn.Clear();
                txtgx.Clear();
                txttt.Clear();
                txtnn.Clear();
                txtsln.Clear();
                txtdb.Clear();
                txtcl.Clear();
                txtctsx.Clear();
            }
            else
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItems = listView1.SelectedItems[0];
                    selectedItems.SubItems[1].Text = txttsp.Text;
                    selectedItems.SubItems[2].Text = txtgn.Text;
                    selectedItems.SubItems[3].Text = txtgx.Text;
                    selectedItems.SubItems[4].Text = txttt.Text;
                    selectedItems.SubItems[5].Text = txtnn.Text;
                    selectedItems.SubItems[6].Text = txtsln.Text;
                    selectedItems.SubItems[7].Text = txtdb.Text;
                    selectedItems.SubItems[8].Text = txtcl.Text;
                    selectedItems.SubItems[9].Text = txtctsx.Text;
                }
            }

            // Xóa nội dung của các hộp văn bản nếu không ở chế độ thêm mới
            txtmsp.Focus();
            txttsp.Clear();
            txtgn.Clear();
            txtgx.Clear();
            txttt.Clear();
            txtnn.Clear();
            txtsln.Clear();
            txtdb.Clear();
            txtcl.Clear();
            txtctsx.Clear();

            modeNew = false;
            SetControl(false);

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
                txtmsp.Text = selectedItem.SubItems[1].Text;
                txttsp.Text = selectedItem.SubItems[2].Text;
                txtgn.Text = selectedItem.SubItems[3].Text;
                txtgx.Text = selectedItem.SubItems[4].Text;
                txttt.Text = selectedItem.SubItems[5].Text;
                txtnn.Text = selectedItem.SubItems[6].Text;
                txtsln.Text = selectedItem.SubItems[7].Text;
                txtdb.Text = selectedItem.SubItems[8].Text;
                txtcl.Text = selectedItem.SubItems[9].Text;
                txtctsx.Text = selectedItem.SubItems[10].Text;
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
            txtmsp.Clear();
            txttsp.Clear();
            txtgn.Clear();
            txtgx.Clear();
            txttt.Clear();
            txtnn.Clear();
            txtsln.Clear();
            txtdb.Clear();
            txtcl.Clear();
            txtctsx.Clear();
            modeNew = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                // Lặp qua từng mục trong ListView và chèn dữ liệu vào cơ sở dữ liệu
                foreach (ListViewItem item in listView1.Items)
                {
                    string msp = item.SubItems[0].Text;
                    string tsp = item.SubItems[1].Text;
                    string gn = item.SubItems[2].Text;
                    string gx = item.SubItems[3].Text;
                    string tt = item.SubItems[4].Text;
                    string nn = item.SubItems[5].Text;
                    string sln = item.SubItems[6].Text;
                    string db = item.SubItems[7].Text;
                    string cl = item.SubItems[8].Text;
                    string ctsx = item.SubItems[9].Text;

                    // Tạo câu lệnh SQL INSERT
                    string sqlInsert = "INSERT INTO SanPham (MaSP, TenSP, GiaNhap, GiaBan, TinhTrang, NgayNhap, SoLuong, DaBan, ChatLieu, CTSanXuat) " +
                                       "VALUES (@MaSP, @TenSP, @GiaNhap, @GiaBan, @TinhTrang, @NgayNhap, @SoLuong, @DaBan, @ChatLieu, @CTSanXuat)";

                    // Tạo và thực thi SqlCommand
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@MaSP", msp);
                        command.Parameters.AddWithValue("@TenSP", tsp);
                        command.Parameters.AddWithValue("@GiaNhap", gn);
                        command.Parameters.AddWithValue("@GiaBan", gx);
                        command.Parameters.AddWithValue("@TinhTrang", tt);
                        command.Parameters.AddWithValue("@NgayNhap", nn);
                        command.Parameters.AddWithValue("@SoLuong", sln);
                        command.Parameters.AddWithValue("@DaBan", db);
                        command.Parameters.AddWithValue("@ChatLieu", cl);
                        command.Parameters.AddWithValue("@CTSanXuat", ctsx);

                        // Thực thi câu lệnh SQL
                        command.ExecuteNonQuery();
                    }
                }
            }

            // Hiển thị thông báo khi lưu dữ liệu thành công
            MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QLSanPham_Load(object sender, EventArgs e)
        {

        }

    }
}