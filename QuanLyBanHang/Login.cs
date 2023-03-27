using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Login : Form
    {
        public static string taiKhoanDangSuDung;
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Connect db = new Connect();

            ds = db.truyvan("SELECT TenQL FROM QuanLy WHERE MaQL = N'" + txtTenTaiKhoan.Text + "' and PassWord = '" + txtMatKhau.Text + "'  ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                taiKhoanDangSuDung = ds.Tables[0].Rows[0]["TenQL"].ToString();
                
                MessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo");
                fHeThongChinh f = new fHeThongChinh();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn đăng nhập thất bại!", "Thông báo");
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo"); 
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
