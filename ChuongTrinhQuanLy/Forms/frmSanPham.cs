using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Forms
{
    public partial class frmSanPham : Form
    {
        private SanPhamBUS sanPhamBUS = new SanPhamBUS();
        private GioHangBUS gioHangBUS = new GioHangBUS();
        private int maNguoiDung; // Lấy từ phiên đăng nhập
    
        public frmSanPhamKH(int maND)
        {
            InitializeComponent();
            maNguoiDung = maND;
            LoadSanPham();
        }
    
        private void LoadSanPham()
        {
            var ds = sanPhamBUS.LayTatCaSanPham();
            dgvSanPham.DataSource = ds;
            // Thêm cột nút "ADD"
            if (!dgvSanPham.Columns.Contains("colAdd"))
            {
                var colAdd = new DataGridViewButtonColumn();
                colAdd.Name = "colAdd";
                colAdd.HeaderText = "Thêm vào giỏ";
                colAdd.Text = "ADD";
                colAdd.UseColumnTextForButtonValue = true;
                dgvSanPham.Columns.Add(colAdd);
            }
        }
    
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSanPham.Columns["colAdd"].Index && e.RowIndex >= 0)
            {
                int maSP = Convert.ToInt32(dgvSanPham.Rows[e.RowIndex].Cells["MaSP"].Value);
                gioHangBUS.ThemVaoGioHang(maNguoiDung, maSP, 1);
                MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng!");
            }
        }
    
        private void btnXemGioHang_Click(object sender, EventArgs e)
        {
            var frm = new frmGioHang(maNguoiDung);
            frm.ShowDialog();
        }
    }
}
