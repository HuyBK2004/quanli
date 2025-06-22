using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmPhieuNhap : Form
    {
        private readonly NguoiDung _nvKho;

        public frmPhieuNhap(NguoiDung nvKho)
        {
            InitializeComponent();
            _nvKho = nvKho;
            LoadPhieuNhap();
        }

        private void LoadPhieuNhap()
        {
            dgvPhieuNhap.DataSource = PhieuNhapBUS.GetAll();
            dgvPhieuNhap.ClearSelection();
            dgvChiTietPN.DataSource = null;
        }

        private void dgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count > 0 && dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value != null)
            {
                if (int.TryParse(dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value.ToString(), out int maPN))
                {
                    dgvChiTietPN.DataSource = PhieuNhapBUS.GetChiTiet(maPN);
                }
                else
                {
                    dgvChiTietPN.DataSource = null;
                }
            }
            else
            {
                dgvChiTietPN.DataSource = null;
            }
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            var pn = new PhieuNhap
            {
                MaNguoiDung = _nvKho.MaNguoiDung,
                NgayNhap = DateTime.Now,
                TrangThai = "ChoDuyet"
            };
            int maPN = PhieuNhapBUS.Add(pn);
            if (maPN > 0)
            {
                MessageBox.Show("Tạo phiếu nhập thành công!");
                LoadPhieuNhap();
            }
            else
            {
                MessageBox.Show("Tạo phiếu nhập thất bại!");
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để thêm sản phẩm!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtGiaNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã SP, số lượng và giá nhập!");
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
            if (!decimal.TryParse(txtGiaNhap.Text, out decimal giaNhap) || giaNhap < 0)
            {
                MessageBox.Show("Giá nhập không hợp lệ!");
                return;
            }

            int maPN = Convert.ToInt32(dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value);
            var ct = new ChiTietPhieuNhap
            {
                MaPhieuNhap = maPN,
                MaSP = maSP,
                SoLuong = soLuong,
                GiaNhap = giaNhap
            };
            if (PhieuNhapBUS.AddChiTiet(ct))
            {
                MessageBox.Show("Thêm SP vào phiếu nhập thành công!");
                dgvChiTietPN.DataSource = PhieuNhapBUS.GetChiTiet(maPN);
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại!");
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để duyệt!");
                return;
            }
            int maPN = Convert.ToInt32(dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value);
            var pn = PhieuNhapBUS.GetById(maPN);
            if (pn.TrangThai == "DaDuyet")
            {
                MessageBox.Show("Phiếu đã được duyệt trước đó!");
                return;
            }
            pn.TrangThai = "DaDuyet";
            if (PhieuNhapBUS.Update(pn))
            {
                MessageBox.Show("Phiếu đã duyệt!");
                LoadPhieuNhap();
            }
            else
            {
                MessageBox.Show("Duyệt phiếu thất bại!");
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để từ chối!");
                return;
            }
            int maPN = Convert.ToInt32(dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value);
            var pn = PhieuNhapBUS.GetById(maPN);
            if (pn.TrangThai == "TuChoi")
            {
                MessageBox.Show("Phiếu đã bị từ chối trước đó!");
                return;
            }
            pn.TrangThai = "TuChoi";
            if (PhieuNhapBUS.Update(pn))
            {
                MessageBox.Show("Phiếu đã từ chối!");
                LoadPhieuNhap();
            }
            else
            {
                MessageBox.Show("Từ chối phiếu thất bại!");
            }
        }
    }
}