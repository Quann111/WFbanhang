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
    public partial class XemDonHang : Form
    {
        public static string taiKhoanDangSuDung;
        public XemDonHang()
        {
            InitializeComponent();
            lbTenNguoiLogin.Text = Login.taiKhoanDangSuDung;
            DataSet ds = new DataSet();
            Connect db = new Connect();
            ds = db.truyvan("SELECT * FROM KhachHang, QuanLy");
            cbbKhachHang.DataSource = ds.Tables[0];
            cbbKhachHang.ValueMember = "MaKH";
            cbbKhachHang.DisplayMember = "TenKH";

            cbbQuanLy.DataSource = ds.Tables[0];
            cbbQuanLy.ValueMember = "MaQL";
            cbbQuanLy.DisplayMember = "TenQL";
            show();
        }


        public void show()
        {
            DataSet ds = new DataSet();
            Connect db = new Connect();
            ds = db.truyvan("SELECT HoaDon.MaHoaDon as 'Mã hóa đơn', HoaDon.NgayTao as 'Ngày tạo', HoaDon.SoLuongSach as 'Số lượng sách', HoaDon.ThanhTien as 'Thành tiền', HoaDon.MaKH as 'Mã khách hàng', KhachHang.TenKH as 'Tên khách hàng', KhachHang.GioiTinh as 'Giới tính', KhachHang.DiaChi as 'Địa chỉ', KhachHang.NgaySinh as 'Ngày sinh', KhachHang.SoDienThoai as 'Số điện thoại',HoaDon.MaQL as 'Mã quản lý', QuanLy.TenQL as 'Tên quản lý', QuanLy.NgaySinh as 'Ngày sinh', QuanLy.GioiTinh as 'Giới tính', QuanLy.DiaChi as 'Địa chỉ' FROM HoaDon INNER JOIN KhachHang ON KhachHang.MaKH = HoaDon.MaKH INNER JOIN QuanLy ON QuanLy.MaQL = HoaDon.MaQL");
            dgvHoaDoa.DataSource = ds.Tables[0];
        }

        private void dgvXemDonhang(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dgvHoaDoa.CurrentRow;
            txtMaDonHang.Text = a.Cells[0].Value.ToString();
            txtNgayTao.Text = a.Cells[1].Value.ToString();
            txtSoLuong.Text = a.Cells[2].Value.ToString();
            txtThanhTien.Text = a.Cells[3].Value.ToString();
            cbbKhachHang.Text = a.Cells[4].Value.ToString();
            cbbQuanLy.Text = a.Cells[5].Value.ToString();
            string l = "SELECT HoaDonChiTiet.MaHoaDon as 'Mã hóa đơn', HoaDonChiTiet.MaSach as 'Mã sách', Sach.TenSach as 'Tên sách', HoaDonChiTiet.SoLuongSach as 'Số lượng sách', HoaDonChiTiet.ThanhTien as 'Thành tiền'  From HoaDonChiTiet INNER JOIN Sach ON Sach.MaSach = HoaDonChiTiet.MaSach WHERE MaHoaDon = '" + txtMaDonHang.Text + "'";
            DataSet b = new Connect().truyvan(l);
            dgvHoaDonChiTiet.DataSource = b.Tables[0];
        }

        private void label22_Click(object sender, EventArgs e)
        {
            fHeThongChinh f = new fHeThongChinh();
            f.Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            TaoHoaDon tdh = new TaoHoaDon();
            tdh.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            XemDonHang xdh = new XemDonHang();
            xdh.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();
            tl.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia();
            tg.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            TongHopSach ths = new TongHopSach();
            ths.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            ThongKeNhap tkn = new ThongKeNhap();
            tkn.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            ThongKeXuat tkx = new ThongKeXuat();
            tkx.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
