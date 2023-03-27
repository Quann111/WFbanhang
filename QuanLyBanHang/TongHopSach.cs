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
    public partial class TongHopSach : Form
    {
        public static string taiKhoanDangSuDung;
        public static string maSach;
        public TongHopSach()
        {
            InitializeComponent();
            lbTenNguoiLogin.Text = Login.taiKhoanDangSuDung;
            show();
        }

        public void show()
        {
            DataSet ds = new DataSet();
            Connect db = new Connect();
            ds = db.truyvan("SELECT Sach.MaSach as 'Mã sách', Sach.TenSach as 'Tên sách', Sach.SoLuongSach as 'Số lượng sách', Sach.GiaBan as 'Giá bán', Sach.MaTG as 'Mã tác giả', TacGia.TenTG as 'Tên tác giả', TacGia.LienHe as 'Liên hệ', Sach.MaTL as 'Mã thể loại', TheLoai.TenTL as 'Tên thể loại', Sach.AnhSach as 'Ảnh sách' FROM Sach INNER JOIN TacGia ON TacGia.MaTG = Sach.MaTG INNER JOIN TheLoai ON TheLoai.MaTL = Sach.MaTL");
            dgvSach.DataSource = ds.Tables[0];
        }

        private void tổngHợpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TongHopSach ths = new TongHopSach();
            ths.Show();
            this.Hide();
        }

        private void dgv_Sach(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dgvSach.CurrentRow;
            txtMaSach.Text = a.Cells[0].Value.ToString();
            txtTenSach.Text = a.Cells[1].Value.ToString();
            txtSoLuong.Text = a.Cells[2].Value.ToString();
            txtGiaBan.Text = a.Cells[3].Value.ToString();
            cbbTacGia.Text = a.Cells[4].Value.ToString();
            cbbTheLoai.Text = a.Cells[5].Value.ToString();
            imgSach.Image = Image.FromFile(a.Cells[9].Value.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            bool ck = db.CapNhatDB("INSERT INTO Sach VALUES('" + txtMaSach.Text + "', '" + txtTenSach.Text + "', '" + txtSoLuong.Text + "', '" + txtGiaBan.Text + "', '" + cbbTacGia.SelectedValue + "', '" + cbbTheLoai.SelectedValue + "')");
            if (ck == true)
            {
                MessageBox.Show("Bạn đã thêm csdl thành công!!!", "Thông báo");
                maSach = txtMaSach.Text;
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
            bool ck = db.CapNhatDB("UPDATE Sach SET TenSach = '" + txtTenSach.Text + "', SoLuongSach = '" + txtSoLuong.Text + "', GiaBan = '" + txtGiaBan.Text + "' WHERE MaSach = '" + txtMaSach.Text + "'");
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
            bool ck = db.CapNhatDB("DELETE Sach WHERE MaSach = '" + txtMaSach.Text + "'");
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
            ds = db.truyvan("SELECT * FROM Sach WHERE MaSach like '%" + txtMaSach.Text + "%'");
            dgvSach.DataSource = ds.Tables[0];
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
