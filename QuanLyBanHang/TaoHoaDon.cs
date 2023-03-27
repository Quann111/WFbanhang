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
    public partial class TaoHoaDon : Form
    {
        public static string taiKhoanDangSuDung;
        public static string maHoaDon_dc;
        public TaoHoaDon()
        {
            InitializeComponent();
            lbTenNguoiLogin.Text = Login.taiKhoanDangSuDung;
            showKH();
            showDH();
        }

        private void btnBanHangHD_Click(object sender, EventArgs e)
        {
            DataGridViewRow x = dgvHoaDon.CurrentRow;
            maHoaDon_dc = x.Cells[0].Value.ToString();
            BanHang taodonhang = new BanHang();
            taodonhang.Show();
            this.Hide();
        }

       
        public void showKH()
        {
            DataSet ds = new DataSet();
            Connect db = new Connect();
            ds = db.truyvan("SELECT KhachHang.MaKH as 'Mã khách hàng', KhachHang.TenKH as 'Tên khách hàng', KhachHang.NgaySinh as 'Ngày sinh', KhachHang.GioiTinh as 'Giới tính', KhachHang.DiaChi as 'Địa chỉ', KhachHang.SoDienThoai as 'Số điện thoại', KhachHang.AnhKH as 'Ảnh khách hàng' FROM KhachHang");
            dgvKhachHang_HD.DataSource = ds.Tables[0];
        }
        public void showDH()
        {
            DataSet ds = new DataSet();
            Connect db = new Connect();
            ds = db.truyvan("SELECT HoaDon.MaHoaDon as 'Mã hóa đơn', HoaDon.MaQL as 'Mã quản lý', HoaDon.MaKH as 'Mã khách hàng', HoaDon.SoLuongSach as 'Số lượng sách', HoaDon.ThanhTien as ' Thành tiền', HoaDon.NgayTao as 'Ngày tạo' FROM HoaDon");
            dgvHoaDon.DataSource = ds.Tables[0];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow a = dgvKhachHang_HD.CurrentRow;
            string maKhachHang = a.Cells[0].Value.ToString();
            string maQuanLy = Login.taiKhoanDangSuDung;
            string l = "INSERT INTO HoaDon VALUES('" + txtMaHoaDon.Text + "','" + maQuanLy + "','" + maKhachHang + "','','',GETDATE())";
            Console.WriteLine(l);
            if (new Connect().CapNhatDB(l))
            {
                MessageBox.Show("Cập nhật thành công!!!");
                maHoaDon_dc = txtMaHoaDon.Text;
                showDH();
            }
            else MessageBox.Show("Cập nhật thất bại!!!");
        }

        private void label34_Click(object sender, EventArgs e)
        {
            fHeThongChinh f = new fHeThongChinh();
            f.Show();
            this.Hide();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            TaoHoaDon thd = new TaoHoaDon();
            thd.Show();
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
    }
}
