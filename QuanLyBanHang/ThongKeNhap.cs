﻿using System;
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
    public partial class ThongKeNhap : Form
    {
        public static string taiKhoanDangSuDung;
        public ThongKeNhap()
        {
            InitializeComponent();
            lbTenNguoiLogin.Text = Login.taiKhoanDangSuDung;
            show();
        }


        private void show(string ngayBatDau = "1/1/1990", string ngayKetThuc = "1/1/2100") 
        {
            string l = "SELECT PhieuNhap.MaPN as 'Mã phiếu nhập', PhieuNhap.NgayNhap as 'Ngày nhập', PhieuNhap.SoLuongSach as 'Số lượng sách', PhieuNhap.ThanhTien as 'Thành tiền', PhieuNhap.GhiChu as 'Ghi chú' FROM PhieuNhap " +
                        "WHERE PhieuNhap.NgayNhap >= '" + ngayBatDau + "' and PhieuNhap.NgayNhap <= '" + ngayKetThuc + "'";
            dgvThongKeNhap.DataSource = new Connect().truyvan(l).Tables[0];
        }

        private void btnHienThiTKN_Click(object sender, EventArgs e)
        {
            show(dtpNgayBatDau.Value.ToString("MM/dd/yyyy").ToString(),
                dtpNgayKetthuc.Value.ToString("MM/dd/yyyy").ToString());
            //MessageBox.Show(dtpNgayBatDau.Value.ToString("MM/dd/yyyy"));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fHeThongChinh f = new fHeThongChinh();
            f.Show();
            this.Hide();
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
