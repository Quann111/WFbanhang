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
    public partial class fHeThongChinh : Form
    {
        public static string taiKhoanDangSuDung;
        public fHeThongChinh()
        {
            InitializeComponent();
            lbTenNguoiLogin.Text = Login.taiKhoanDangSuDung;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            fHeThongChinh f = new fHeThongChinh();
            f.Show();
            this.Hide();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            TaoHoaDon tdh = new TaoHoaDon();
            tdh.Show();
            this.Hide();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            XemDonHang xdh = new XemDonHang();
            xdh.Show();
            this.Hide();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
            this.Hide();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();
            tl.Show();
            this.Hide();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia();
            tg.Show();
            this.Hide();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            TongHopSach ths = new TongHopSach();
            ths.Show();
            this.Hide();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            ThongKeNhap tkn = new ThongKeNhap();
            tkn.Show();
            this.Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            ThongKeXuat tkx = new ThongKeXuat();
            tkx.Show();
            this.Hide();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            TongHopSach ths = new TongHopSach();
            ths.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            TongHopSach ths = new TongHopSach();
            ths.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            TongHopSach ths = new TongHopSach();
            ths.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            TongHopSach ths = new TongHopSach();
            ths.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            TongHopSach ths = new TongHopSach();
            ths.Show();
            this.Hide();
        }
    }
}
