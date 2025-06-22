using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
            LoadNguoiDung();
        }

        private void LoadNguoiDung()
        {
            dgvNguoiDung.DataSource = NguoiDungBUS.GetAll();
            dgvNguoiDung.ClearSelection();
            ClearInput();
        }

        private void ClearInput()
        {
            txtHoTen.Text = "";
            txtUsername.Text = "";
            txtMatKhau.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            cboVaiTro.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên, Username và Mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập Email!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = new NguoiDung
            {
                HoTen = txtHoTen.Text.Trim(),
                Username = txtUsername.Text.Trim(),
                MatKhau = Utils.PasswordHelper.HashPassword(txtMatKhau.Text),
                Email = txtEmail.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                VaiTro = cboVaiTro.SelectedItem?.ToString() ?? "KH",
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "BinhThuong"
            };
            string msg;
            if (NguoiDungBUS.Register(user, txtMatKhau.Text, out msg))
            {
                MessageBox.Show("Thêm người dùng thành công!", "Thành công");
                LoadNguoiDung();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNguoiDung.SelectedRows.Count > 0)
            {
                var row = dgvNguoiDung.SelectedRows[0];
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
                txtUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
                txtMatKhau.Text = ""; // không show mật khẩu
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString() ?? "";
                cboVaiTro.SelectedItem = row.Cells["VaiTro"].Value?.ToString() ?? "KH";
                cboTrangThai.SelectedItem = row.Cells["TrangThai"].Value?.ToString() ?? "BinhThuong";
            }
            else
            {
                ClearInput();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn người dùng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var row = dgvNguoiDung.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["MaNguoiDung"].Value);
            string name = row.Cells["HoTen"].Value?.ToString() ?? "";
            var confirm = MessageBox.Show($"Bạn chắc chắn muốn xóa người dùng '{name}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                if (NguoiDungBUS.Delete(id))
                {
                    MessageBox.Show("Đã xóa!", "Thành công");
                    LoadNguoiDung();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn người dùng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvNguoiDung.SelectedRows[0].Cells["MaNguoiDung"].Value);
            var user = NguoiDungBUS.GetById(id);
            if (user == null)
            {
                MessageBox.Show("Không tìm thấy người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user.HoTen = txtHoTen.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.SoDienThoai = txtSoDienThoai.Text.Trim();
            user.VaiTro = cboVaiTro.SelectedItem?.ToString() ?? "KH";
            user.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "BinhThuong";
            if (!string.IsNullOrEmpty(txtMatKhau.Text)) user.MatKhau = Utils.PasswordHelper.HashPassword(txtMatKhau.Text);

            if (NguoiDungBUS.Update(user))
            {
                MessageBox.Show("Cập nhật thành công!", "Thành công");
                LoadNguoiDung();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}