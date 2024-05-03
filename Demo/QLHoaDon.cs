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
    public partial class QLHoaDon : Form
    {
        public QLHoaDon()
        {
            InitializeComponent();
        }
        String connectString = @"Data Source=LAPTOP-SRK3A3P7;Initial Catalog=QLCH;Integrated Security=True;";
        int row = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();

                
                string query = "SELECT * FROM HoaDon"; 
                SqlCommand cmd = new SqlCommand(query, conn);

                // Tạo một adapter để đọc dữ liệu từ cơ sở dữ liệu vào DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ adapter vào DataTable
                adapter.Fill(dataTable);

                // Xóa tất cả các mục hiện tại trong ListView
                lvHoaDon.Items.Clear();

                // Lặp qua từng dòng trong DataTable và thêm vào ListView
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["ID"].ToString()); 
                    item.SubItems.Add(row["MaKH"].ToString());
                    item.SubItems.Add(row["MaKH"].ToString());
                    item.SubItems.Add(row["HoTen"].ToString());
                    item.SubItems.Add(row["MaSP"].ToString());
                    item.SubItems.Add(row["TenSP"].ToString());
                    item.SubItems.Add(row["DaBan"].ToString());
                    item.SubItems.Add(row["TenNN"].ToString());
                    lvHoaDon.Items.Add(item);
                }
            }
        }

        private void QLHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbdshd_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.Show();
            Hide();

        }
    }
}
