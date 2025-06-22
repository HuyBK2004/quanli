using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmPhieuNhapKho : Form
    {
        private int _maNhanVien;
        private List<ChiTietPhieuNhap> _dsChiTiet = new List<ChiTietPhieuNhap>();

        public frmPhieuNhapKho(int maNhanVien)
        {
            InitializeComponent();
            _maNhanVien = maNhanVien;
        }

        private void frmPhieuNhapKho_Load(object sender, EventArgs e)
        {
            LoadPhieuNhap();
            LoadSanPham();
            pnlNhap.Visible = false;
            dgvChiTietNhap.AutoGenerateColumns = false;
            // Setup DataGridView columns for dgvChiTietNhap here if not done in Designer
        }

        private void LoadPhieuNhap()
        {
            var list = PhieuNhapBUS.GetByNguoiDung(_maNhanVien);
            dgvPhieuNhap.DataSource = list;
            dgvPhieuNhap.ClearSelection();
        }

        private void LoadSanPham()
        {
            cboSanPham.DataSource = SanPhamBUS.GetAll();
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            pnlNhap.Visible = !pnlNhap.Visible;
            _dsChiTiet.Clear();
            dgvChiTietNhap.DataSource = null;
            dgvChiTietNhap.Rows.Clear();
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }
            if (!decimal.TryParse(txtGiaNhap.Text, out decimal giaNhap) || giaNhap < 0)
            {
                MessageBox.Show("Giá nhập không hợp lệ!");
                return;
            }
            var maSP = (int)cboSanPham.SelectedValue;

            // Kiểm tra trùng sản phẩm
            if (_dsChiTiet.Exists(x => x.MaSP == maSP))
            {
                MessageBox.Show("Sản phẩm đã có trong danh sách chi tiết!");
                return;
            }

            var tenSP = ((DTO.SanPham)cboSanPham.SelectedItem).TenSP;
            _dsChiTiet.Add(new ChiTietPhieuNhap
            {
                MaSP = maSP,
                TenSP = tenSP,
                SoLuong = soLuong,
                GiaNhap = giaNhap
            });

            dgvChiTietNhap.DataSource = null;
            dgvChiTietNhap.DataSource = _dsChiTiet;
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietNhap.CurrentRow == null) return;
            var maSP = (int)dgvChiTietNhap.CurrentRow.Cells["MaSP"].Value;
            _dsChiTiet.RemoveAll(x => x.MaSP == maSP);
            dgvChiTietNhap.DataSource = null;
            dgvChiTietNhap.DataSource = _dsChiTiet;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_dsChiTiet.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong phiếu nhập!");
                return;
            }
            var phieu = new PhieuNhap
            {
                MaNguoiDung = _maNhanVien,
                TrangThai = "ChoDuyet",
                ChiTietPhieuNhap = _dsChiTiet
            };
            int maPhieu = PhieuNhapBUS.Insert(phieu);
            if (maPhieu > 0)
            {
                MessageBox.Show("Đã gửi phiếu nhập, chờ chủ cửa hàng duyệt!");
                LoadPhieuNhap();
                pnlNhap.Visible = false;
            }
            else
            {
                MessageBox.Show("Tạo phiếu nhập thất bại!");
            }
        }
    }
}