using System;
using System.Windows.Forms;
using BUS;

namespace Forms
{
    public partial class frmSanPhamKH : Form
    {
        public frmSanPhamKH()
        {
            InitializeComponent();
        }

        private void frmSanPhamKH_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void LoadSanPham()
        {
            dgvSanPham.DataSource = SanPhamBUS.GetAll();
            dgvSanPham.ClearSelection();
        }
    }
}