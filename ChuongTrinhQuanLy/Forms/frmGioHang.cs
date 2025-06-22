using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmGioHang : Form
    {
        private readonly NguoiDung _khach;

        public frmGioHang(NguoiDung khach)
        {
            InitializeComponent();
            _khach = khach;
            LoadGioHang();
        }

        private void LoadGioHang()
        {
            dgvGioHang.DataSource = DonHangBUS.GetGioHang(_khach.MaNguoiDung);
            dgvGioHang.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SP và Số lượng!");
                return;
            }
            if (!int.TryParse(txtMaSP.Text, out int maSP))
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ!");
                return;
            }
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!");
                return;
            }

            var gh = new GioHang
            {
                MaNguoiDung = _khach.MaNguoiDung,
                MaSP = maSP,
                SoLuong = soLuong
            };

            if (DonHangBUS.AddGioHang(gh))
            {
                MessageBox.Show("Thêm vào giỏ hàng thành công!");
                LoadGioHang();
            }
            else
            {
                MessageBox.Show("Thêm vào giỏ hàng thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            var cell = dgvGioHang.SelectedRows[0].Cells["MaSP"];
            if (cell == null || cell.Value == null)
            {
                MessageBox.Show("Không xác định được sản phẩm để xóa!");
                return;
            }

            int maSP = Convert.ToInt32(cell.Value);

            if (DonHangBUS.DeleteGioHang(_khach.MaNguoiDung, maSP))
            {
                MessageBox.Show("Xóa thành công!");
                LoadGioHang();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            var gio = DonHangBUS.GetGioHang(_khach.MaNguoiDung);
            if (gio == null || gio.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            // Tạo đơn hàng mới
            var dh = new DonHang
            {
                MaNguoiDung = _khach.MaNguoiDung,
                NgayDat = DateTime.Now,
                TrangThai = "DangXuLy",
                TongTien = 0
            };
            int maDH = DonHangBUS.Add(dh);
            decimal tong = 0;

            foreach (var gh in gio)
            {
                var sp = SanPhamBUS.GetById(gh.MaSP);
                if (sp == null)
                {
                    MessageBox.Show($"Không tìm thấy sản phẩm với mã {gh.MaSP}!");
                    continue;
                }

                var ct = new ChiTietDonHang
                {
                    MaDonHang = maDH,
                    MaSP = gh.MaSP,
                    SoLuong = gh.SoLuong,
                    DonGia = sp.GiaBan
                };
                DonHangBUS.AddChiTiet(ct);
                tong += ct.SoLuong * ct.DonGia;
            }

            // Cập nhật tổng tiền đơn hàng
            var dhUpd = DonHangBUS.GetById(maDH);
            if (dhUpd != null)
            {
                dhUpd.TongTien = tong;
                DonHangBUS.Update(dhUpd);
            }

            DonHangBUS.ClearGioHang(_khach.MaNguoiDung);
            MessageBox.Show("Đặt hàng thành công!");
            LoadGioHang();
        }
    }
}