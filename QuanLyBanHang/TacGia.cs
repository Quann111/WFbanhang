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
    public partial class TacGia : Form
    {
        public static string taiKhoanDangSuDung;
        public TacGia()
        {
            InitializeComponent();
            lbTenNguoiLogin.Text = Login.taiKhoanDangSuDung;
            show();
        }


        public void show()
        {
            DataSet ds = new DataSet();
            Connect db = new Connect();
            ds = db.truyvan("SELECT TacGia.MaTG as 'Mã tác giả', TacGia.TenTG as 'Tên tác giả', LienHe as 'Liên hệ' FROM TacGia");
            dgvTacGia.DataSource = ds.Tables[0];
        }
        private void btnAddTG_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            bool ck = db.CapNhatDB("INSERT INTO TacGia VALUES('" + txtMaTG.Text + "', '" + txtTenTG.Text + "', '" + txtLHTG.Text + "')");
            if(ck == true)
            {
                MessageBox.Show("Bạn đã thêm csdl thành công!!!", "Thông báo");
                show();
            }
            else
            {
                MessageBox.Show("Bạn đã thêm csdl thất bại!!!", "Thông báo");
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            show();
        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            bool ck = db.CapNhatDB("UPDATE TacGia SET TenTG = '" + txtTenTG.Text + "', LienHe = '" + txtLHTG.Text + "' WHERE MaTG = '" + txtMaTG.Text + "'");
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

        private void btnXoaALLTG_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            bool ck = db.CapNhatDB("DELETE TacGia WHERE MaTG = '" + txtMaTG.Text + "'");
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

        private void btnTimKiemTG_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            DataSet ds = new DataSet();
            ds = db.truyvan("SELECT * FROM TacGia WHERE MaTG like '%" + txtMaTG.Text + "%'");
            dgvTacGia.DataSource = ds.Tables[0];
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dgvTacGia.CurrentRow;
            txtMaTG.Text = a.Cells[0].Value.ToString();
            txtTenTG.Text = a.Cells[1].Value.ToString();
            txtLHTG.Text = a.Cells[2].Value.ToString();
            //MessageBox.Show("Hello");
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
