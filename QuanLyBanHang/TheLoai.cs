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
    public partial class TheLoai : Form
    {
        public static string taiKhoanDangSuDung;
        public TheLoai()
        {
            InitializeComponent();
            show();
            lbTenNguoiLogin.Text = Login.taiKhoanDangSuDung;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        public void show()
        {
            DataSet ds = new DataSet();
            Connect db = new Connect();
            ds = db.truyvan("SELECT TheLoai.MaTL as 'Mã thể loại', TheLoai.TenTL as 'Tên thể loại' FROM TheLoai");
            dgvTheLoai.DataSource = ds.Tables[0];
        }
        private void btnAddTL_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            bool ck = db.CapNhatDB("INSERT INTO TheLoai VALUES('" + txtMaTL.Text + "', '" + txtTenTheLoai.Text + "')");
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

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            bool ck = db.CapNhatDB("UPDATE TheLoai SET TenTL = '" + txtTenTheLoai.Text + "' WHERE MaTL = '" + txtMaTL.Text + "'");
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

        private void btnXoaALLTL_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            bool ck = db.CapNhatDB("DELETE TheLoai WHERE MaTL = '" + txtMaTL.Text + "'");
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

        private void btnTimKiemTL_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            DataSet ds = new DataSet();
            ds = db.truyvan("SELECT * FROM TheLoai WHERE MaTL like '%" + txtMaTL.Text + "%'");
            dgvTheLoai.DataSource = ds.Tables[0];
        }

        private void dgvThe_Loai(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dgvTheLoai.CurrentRow;
            txtMaTL.Text = a.Cells[0].Value.ToString();
            txtTenTheLoai.Text = a.Cells[1].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fHeThongChinh f = new fHeThongChinh();
            f.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            TaoHoaDon tdh = new TaoHoaDon();
            tdh.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
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
