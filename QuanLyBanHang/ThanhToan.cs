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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
            show();
            init();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã thanh toán thành công!!!", "Thông báo");
        }
        void init()
        {
            lbMaHoaDon.Text = TaoHoaDon.maHoaDon_dc;
            string l = "SELECT KhachHang.TenKH,HoaDon.NgayTao FROM KhachHang INNER JOIN HoaDon ON HoaDon.MaKH = KhachHang.MaKH INNER JOIN HoaDonChiTiet ON HoaDonChiTiet.MaHoaDon = HoaDon.MaHoaDon WHERE HoaDon.MaHoaDon = '" + TaoHoaDon.maHoaDon_dc + "'";
            DataSet ds = new Connect().truyvan(l);

            lbNgayTao.Text = ds.Tables[0].Rows[0][1].ToString();
        }
        void show()
        {
            string mahoadon = TaoHoaDon.maHoaDon_dc;
            DataSet ds = new DataSet();
            Connect db = new Connect();
            ds = db.truyvan("SELECT HoaDonChiTiet.MaSach as'Mã sách', Sach.TenSach as 'Tên sách', HoaDonChiTiet.SoLuongSach as 'Số lượng sách', HoaDonChiTiet.ThanhTien 'Thành tiền' FROM HoaDonChiTiet INNER JOIN Sach ON Sach.MaSach = HoaDonChiTiet.MaSach INNER JOIN HoaDon ON HoaDon.MaHoaDon = HoaDonChiTiet.MaHoaDon WHERE HoaDon.MaHoaDon = '" + mahoadon + "'");
            dgvThanhToanTien.DataSource = ds.Tables[0];
        }

        private void lbTienCanTra_Click(object sender, EventArgs e)
        {
            //lbTienCanTra.Text = txtTienKhachDua.Text.ToString() - txtTienCanTra.Text.ToString();
        }
    }
}
