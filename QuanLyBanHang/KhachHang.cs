using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace QuanLyBanHang
{
    public partial class KhachHang : Form
    {
        public static string taiKhoanDangSuDung;
        public KhachHang()
        {
            InitializeComponent();
            lbTenNguoiLogin.Text = Login.taiKhoanDangSuDung;
            show();
        }

        public void show()
        {
            DataSet ds = new DataSet();
            Connect db = new Connect();
            ds = db.truyvan("SELECT KhachHang.MaKH as 'Mã khách hàng', KhachHang.TenKH as 'Tên khách hàng', KhachHang.NgaySinh as 'Ngày sinh', KhachHang.GioiTinh as 'Giới tính', KhachHang.DiaChi as 'Địa chỉ', KhachHang.SoDienThoai as 'Số điện thoại', KhachHang.AnhKH as 'Ảnh khách hàng' FROM KhachHang");
            dgvKhachHang.DataSource = ds.Tables[0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            bool ck = db.CapNhatDB("INSERT INTO KhachHang VALUES('" + txtMaKH.Text + "', '" + txtTenKH.Text + "', '" + txtNgaySinh.Text + "', '" + txtGioiTinhKH.Text + "', '" + txtDiaChiKH.Text + "', '" + txtSDTKH.Text + "')");
            if (ck == true)
            {
                MessageBox.Show("Bạn đã thêm csdl thành công!!!", "Thông báo");
                show();
            }
            else
            {
                MessageBox.Show("Bạn đã thêm csdl thất bại!!!", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            bool ck = db.CapNhatDB("UPDATE KhachHang SET TenKH = '" + txtTenKH.Text + "', NgaySinh = '" + txtNgaySinh.Text + "', GioiTinh = '"+txtNgaySinh.Text+ "', DiaChi = '"+txtDiaChiKH.Text+ "', SoDienThoai = '"+txtSDTKH.Text+ "' WHERE MaKH = '" + txtMaKH.Text + "'");
            if (ck == true)
            {
                MessageBox.Show("Bạn đã sửa csdl thành công!!!", "Thông báo");
                show();
            }
            else
            {
                MessageBox.Show("Bạn đã sửa csdl thất bại!!!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            bool ck = db.CapNhatDB("DELETE KhachHang WHERE MaKH = '" + txtMaKH.Text + "'");
            if (ck == true)
            {
                MessageBox.Show("Bạn đã xóa csdl thành công!!!", "Thông báo");
                show();
            }
            else
            {
                MessageBox.Show("Bạn đã xóa csdl thất bại!!!", "Thông báo");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            DataSet ds = new DataSet();
            ds = db.truyvan("SELECT * FROM KhachHang WHERE MaKH like '%" + txtMaKH.Text + "%'");
            dgvKhachHang.DataSource = ds.Tables[0];
        }

        private void dgv_KhachHang(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dgvKhachHang.CurrentRow;
            txtMaKH.Text = a.Cells[0].Value.ToString();
            txtTenKH.Text = a.Cells[1].Value.ToString();
            txtNgaySinh.Text = a.Cells[2].Value.ToString();
            txtGioiTinhKH.Text = a.Cells[3].Value.ToString();
            txtDiaChiKH.Text = a.Cells[4].Value.ToString();
            txtSDTKH.Text = a.Cells[5].Value.ToString();

            pictureKH.Image = Image.FromFile(a.Cells[6].Value.ToString());
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
    }
}
