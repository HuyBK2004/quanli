using System;
using System.Windows.Forms;
using DTO;

namespace Forms
{
    public partial class frmMain : Form
    {
        private NguoiDung _currentUser;

        public frmMain(NguoiDung user)
        {
            InitializeComponent();
            _currentUser = user;
            LoadMenuByRole();
            lblWelcome.Text = $"Xin chào, {_currentUser.HoTen} ({_currentUser.VaiTro})";
        }

        private void LoadMenuByRole()
        {
            // Ẩn/hiện tính năng theo vai trò
            mnuNguoiDung.Visible = _currentUser.VaiTro == "Chu";
            mnuSanPham.Visible = _currentUser.VaiTro == "Chu" || _currentUser.VaiTro == "KH";
            mnuPhieuNhap.Visible = _currentUser.VaiTro == "Chu" || _currentUser.VaiTro == "NhanVienKho";
            mnuHoaDon.Visible = _currentUser.VaiTro == "Chu" || _currentUser.VaiTro == "ThuNgan";
            mnuDonHang.Visible = _currentUser.VaiTro == "Chu";
            mnuGioHang.Visible = _currentUser.VaiTro == "KH";
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new frmLogin().Show();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Xử lý mở các form con
        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            if (_currentUser.VaiTro == "Chu")
            {
                new frmSanPham(_currentUser).ShowDialog(); // Chủ: thêm/sửa/xóa
            }
            else if (_currentUser.VaiTro == "KH")
            {
                new frmSanPhamKH().ShowDialog(); // KH: chỉ xem
            }
        }
        private void mnuNguoiDung_Click(object sender, EventArgs e)
        {
            using (var f = new frmNguoiDung()) { f.ShowDialog(); }
        }
        private void mnuPhieuNhap_Click(object sender, EventArgs e)
        {
            using (var f = new frmPhieuNhap(_currentUser)) { f.ShowDialog(); }
        }
        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            using (var f = new frmHoaDon(_currentUser)) { f.ShowDialog(); }
        }
        private void mnuDonHang_Click(object sender, EventArgs e)
        {
            using (var f = new frmDonHang(_currentUser)) { f.ShowDialog(); }
        }
        private void mnuGioHang_Click(object sender, EventArgs e)
        {
            using (var f = new frmGioHang(_currentUser)) { f.ShowDialog(); }
        }
    }
}