using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmSanPham : Form
    {
        private NguoiDung _currentUser;

        public frmSanPham(NguoiDung currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            LoadSanPham();

            // Chỉ chủ mới được thêm/sửa/xóa
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = _currentUser.VaiTro == "Chu";
        }

        private void LoadSanPham()
        {
            dgvSanPham.DataSource = SanPhamBUS.GetAll();
            dgvSanPham.ClearSelection();
            ClearInput();
        }

        private void ClearInput()
        {
            txtTenSP.Text = "";
            txtMoTa.Text = "";
            txtGiaBan.Text = "";
            txtDonViTinh.Text = "";
            cboTrangThai.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtTenSP.Text) || string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                cboTrangThai.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtGiaBan.Text, out var gia) || gia < 0)
            {
                MessageBox.Show("Giá bán phải là số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sp = new SanPham
            {
                TenSP = txtTenSP.Text.Trim(),
                MoTa = txtMoTa.Text.Trim(),
                GiaBan = gia,
                DonViTinh = txtDonViTinh.Text.Trim(),
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "DangBan"
            };
            string msg;
            if (SanPhamBUS.Add(sp, out msg))
            {
                MessageBox.Show(msg, "Thành công");
                LoadSanPham();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                var row = dgvSanPham.SelectedRows[0];
                txtTenSP.Text = row.Cells["TenSP"].Value?.ToString() ?? "";
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString() ?? "";
                txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString() ?? "";
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value?.ToString() ?? "";
                cboTrangThai.SelectedItem = row.Cells["TrangThai"].Value?.ToString() ?? "DangBan";
            }
            else
            {
                ClearInput();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!decimal.TryParse(txtGiaBan.Text, out var gia) || gia < 0)
            {
                MessageBox.Show("Giá bán phải là số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dgvSanPham.SelectedRows[0].Cells["MaSP"].Value);
            var sp = SanPhamBUS.GetById(id);
            sp.TenSP = txtTenSP.Text.Trim();
            sp.MoTa = txtMoTa.Text.Trim();
            sp.GiaBan = gia;
            sp.DonViTinh = txtDonViTinh.Text.Trim();
            sp.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "DangBan";
            string msg;
            if (SanPhamBUS.Update(sp, out msg))
            {
                MessageBox.Show(msg, "Thành công");
                LoadSanPham();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = Convert.ToInt32(dgvSanPham.SelectedRows[0].Cells["MaSP"].Value);
            string msg;
            var confirm = MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                if (SanPhamBUS.Delete(id, out msg))
                {
                    MessageBox.Show(msg, "Thành công");
                    LoadSanPham();
                }
                else
                {
                    MessageBox.Show(msg, "Lỗi xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}