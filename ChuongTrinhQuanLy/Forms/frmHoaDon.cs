using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmHoaDon : Form
    {
        private readonly NguoiDung _thuNgan;

        public frmHoaDon(NguoiDung thuNgan)
        {
            InitializeComponent();
            _thuNgan = thuNgan;
            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            dgvHoaDon.DataSource = HoaDonBUS.GetAll();
            dgvHoaDon.ClearSelection();
            dgvChiTietHD.DataSource = null;
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0 && dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value != null)
            {
                if (int.TryParse(dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value.ToString(), out int maHD))
                {
                    dgvChiTietHD.DataSource = HoaDonBUS.GetChiTiet(maHD);
                }
                else
                {
                    dgvChiTietHD.DataSource = null;
                }
            }
            else
            {
                dgvChiTietHD.DataSource = null;
            }
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            var hd = new HoaDon
            {
                MaNguoiDung = _thuNgan.MaNguoiDung,
                NgayLap = DateTime.Now,
                TongTien = 0
            };
            int maHD = HoaDonBUS.Add(hd);
            if (maHD > 0)
            {
                MessageBox.Show("Tạo hóa đơn thành công!");
                LoadHoaDon();
            }
            else
            {
                MessageBox.Show("Tạo hóa đơn thất bại!");
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để thêm sản phẩm!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã sản phẩm, số lượng và đơn giá!");
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
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                return;
            }

            int maHD = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value);
            var ct = new ChiTietHoaDon
            {
                MaHoaDon = maHD,
                MaSP = maSP,
                SoLuong = soLuong,
                DonGia = donGia
            };
            if (HoaDonBUS.AddChiTiet(ct))
            {
                MessageBox.Show("Thêm SP vào hóa đơn thành công!");
                dgvChiTietHD.DataSource = HoaDonBUS.GetChiTiet(maHD);
            }
            else
            {
                MessageBox.Show("Thêm SP vào hóa đơn thất bại!");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để thanh toán!");
                return;
            }
            int maHD = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value);
            var list = HoaDonBUS.GetChiTiet(maHD);
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("Hóa đơn này chưa có sản phẩm!");
                return;
            }

            decimal tong = 0;
            foreach (var ct in list)
            {
                tong += ct.DonGia * ct.SoLuong;
            }
            var hd = HoaDonBUS.GetById(maHD);
            hd.TongTien = tong;
            if (HoaDonBUS.Update(hd))
            {
                MessageBox.Show("Thanh toán thành công!");
                LoadHoaDon();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại!");
            }
        }
    }
}