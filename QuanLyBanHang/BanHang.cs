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

    public partial class BanHang : Form
    {
        public static string taiKhoanDangSuDung;
        public BanHang()
        {
            InitializeComponent();
            init();
            lbTenNguoiLogin.Text = Login.taiKhoanDangSuDung;
            showSP();
            showHH();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan tt = new ThanhToan();
            tt.Show();
        }

        public void init()
        {
            lbMaHoaDon.Text = TaoHoaDon.maHoaDon_dc;
            //DataGridViewRow a = dgvKhachHang_HD.CurrentRow;
            string l = "SELECT KhachHang.TenKH,HoaDon.NgayTao FROM KhachHang INNER JOIN HoaDon ON HoaDon.MaKH = KhachHang.MaKH INNER JOIN HoaDonChiTiet ON HoaDonChiTiet.MaHoaDon = HoaDon.MaHoaDon WHERE HoaDon.MaHoaDon = '" + TaoHoaDon.maHoaDon_dc + "'";
            DataSet ds = new Connect().truyvan(l);

            string tenKhachHang = ds.Tables[0].Rows[0][0].ToString();
            lbTenKH.Text = tenKhachHang;

            lbNgayTao.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        public void showSP()
        {
            DataSet ds = new DataSet();
            Connect db = new Connect();
            ds = db.truyvan("SELECT Sach.MaSach as 'Mã sách', Sach.TenSach as 'Tên sách', Sach.MaTG as 'Mã tác giả', Sach.MaTL as 'Mã thể loại', Sach.SoLuongSach as 'Số lượng sách', Sach.GiaBan as 'Giá bán',  Sach.AnhSach as 'Ảnh sách' FROM Sach");
            dgvSanPham.DataSource = ds.Tables[0];
        }
        public void showHH()
        {
            DataSet ds = new DataSet();
            Connect db = new Connect();
            ds = db.truyvan("SELECT HoaDonChiTiet.MaHoaDon as 'Mã hóa đơn', HoaDonChiTiet.MaSach as 'Mã sách', HoaDonChiTiet.GiaTien as 'Giá tiền', HoaDonChiTiet.SoLuongSach as 'Số lượng sách', HoaDonChiTiet.ThanhTien as 'Thành tiền' FROM HoaDonChiTiet WHERE MaHoaDon = '"+ TaoHoaDon.maHoaDon_dc +"'");
            dgvThongTinHoaDon.DataSource = ds.Tables[0];
        }
        private void btnChuyenSang_Click(object sender, EventArgs e)
        {
            //okok
            DataGridViewRow a = dgvSanPham.CurrentRow;
            string maQuanLy = Login.taiKhoanDangSuDung;
            // MessageBox.Show(maNhanVien);
            string maHoaDon = TaoHoaDon.maHoaDon_dc;
            //MessageBox.Show(maHoaDon);
            string maSach = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            string l = "INSERT INTO HoaDonChiTiet VALUES('" + maHoaDon + "','" +maSach+"','1','','')";
            //MessageBox.Show("Heoosudhfgufs");
            if (new Connect().CapNhatDB(l))
            {
                MessageBox.Show("Cập nhật thành công!!!");
                showHH();
            }
            else MessageBox.Show("Cập nhật thất bại!!!");
        }

        private void btnChuyenVe_Click(object sender, EventArgs e)
        {
            //okok
            string maSach = dgvThongTinHoaDon.CurrentRow.Cells[1].Value.ToString();
            string mahoadon = dgvThongTinHoaDon.CurrentRow.Cells[0].Value.ToString();
            string l = "DELETE HoaDonChiTiet WHERE MaSach = '" + maSach + "' AND MaHoaDon = '"+ mahoadon + "'";
            if(new Connect().CapNhatDB(l))
            {
                MessageBox.Show("Xóa dự liệu thành công!!!");
                showHH();
            }
            else
            {
                MessageBox.Show("Xóa dự liệu thất bại!!!");
            }
        }

        private void tổngQuanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fHeThongChinh f = new fHeThongChinh();
            f.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            fHeThongChinh f = new fHeThongChinh();
            f.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            TaoHoaDon tdh = new TaoHoaDon();
            tdh.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            XemDonHang xdh = new XemDonHang();
            xdh.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
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
