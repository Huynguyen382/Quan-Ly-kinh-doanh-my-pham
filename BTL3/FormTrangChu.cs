using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL3
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }
        FormNhanVien frmNhanVien = new FormNhanVien();
        FormSanPham frmSanPham = new FormSanPham();
        FormKhachHang frmKhachHang = new FormKhachHang();
        FormHoaDon frmHoaDon = new FormHoaDon();
        private void nhanVien_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmNhanVien.MdiParent = this;
            frmNhanVien.TopLevel = false;
            frmNhanVien.Parent = panel1;
            frmNhanVien.FormBorderStyle = FormBorderStyle.None;
            frmNhanVien.Dock = DockStyle.Fill;
            frmSanPham.Hide();
            frmKhachHang.Hide();
            frmHoaDon.Hide();
            frmNhanVien.Show();
        }

        private void sanPham_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmSanPham.MdiParent = this;
            frmSanPham.TopLevel = false;
            frmSanPham.Parent = panel1;
            frmSanPham.FormBorderStyle = FormBorderStyle.None;
            frmSanPham.Dock = DockStyle.Fill;
            frmKhachHang.Hide();
            frmNhanVien.Hide();
            frmHoaDon.Hide();
            frmSanPham.Show();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang.MdiParent = this;
            frmKhachHang.TopLevel = false;
            frmKhachHang.Parent = panel1;
            frmKhachHang.FormBorderStyle = FormBorderStyle.None;
            frmKhachHang.Dock = DockStyle.Fill;
            frmNhanVien.Hide();
            frmSanPham.Hide();
            frmHoaDon.Hide();
            frmKhachHang.Show();
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon.MdiParent = this;
            frmHoaDon.TopLevel = false;
            frmHoaDon.Parent = panel1;
            frmHoaDon.FormBorderStyle = FormBorderStyle.None;
            frmHoaDon.Dock = DockStyle.Fill;
            frmNhanVien.Hide();
            frmSanPham.Hide();
            frmKhachHang.Hide();
            frmHoaDon.Show();
        }
    }
}
