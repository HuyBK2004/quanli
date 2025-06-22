using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmDonHang : Form
    {
        private readonly NguoiDung _khach;

        public frmDonHang(NguoiDung khach)
        {
            InitializeComponent();
            _khach = khach;
            LoadDonHang();

            // Sự kiện có thể gán trong Designer, nhưng an toàn hơn vẫn nên kiểm tra và gán ở đây nếu cần
            dgvDonHang.SelectionChanged += dgvDonHang_SelectionChanged;
            btnXemChiTiet.Click += btnXemChiTiet_Click;
        }

        private void LoadDonHang()
        {
            // Lấy danh sách đơn hàng của khách
            var listDonHang = DonHangBUS.Search(null, null, _khach.MaNguoiDung);
            dgvDonHang.DataSource = listDonHang;
            dgvDonHang.ClearSelection();
            dgvChiTietDH.DataSource = null;
        }

        private void dgvDonHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count > 0 && dgvDonHang.SelectedRows[0].Cells["MaDonHang"].Value != null)
            {
                if (int.TryParse(dgvDonHang.SelectedRows[0].Cells["MaDonHang"].Value.ToString(), out int maDH))
                {
                    var chiTiet = DonHangBUS.GetChiTiet(maDH);
                    dgvChiTietDH.DataSource = chiTiet;
                }
                else
                {
                    dgvChiTietDH.DataSource = null;
                }
            }
            else
            {
                dgvChiTietDH.DataSource = null;
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            // Đảm bảo gọi đúng xử lý khi xem chi tiết
            dgvDonHang_SelectionChanged(sender, e);
        }
    }
}