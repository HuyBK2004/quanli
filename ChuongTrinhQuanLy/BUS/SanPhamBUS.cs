using System.Collections.Generic;
using DTO;
using DataAccess;

namespace BUS
{
    public class SanPhamBUS
    {
        public static List<SanPham> GetAll() => SanPhamDAO.GetAll();

        public static SanPham GetById(int id) => SanPhamDAO.GetById(id);

        public static bool Add(SanPham sp, out string message)
        {
            if (string.IsNullOrWhiteSpace(sp.TenSP))
            {
                message = "Tên sản phẩm không được để trống.";
                return false;
            }
            if (sp.GiaBan < 0)
            {
                message = "Giá bán không hợp lệ.";
                return false;
            }
            message = SanPhamDAO.Insert(sp) ? "Thêm sản phẩm thành công!" : "Thêm thất bại.";
            return message.StartsWith("Thêm sản phẩm");
        }

        public static bool Update(SanPham sp, out string message)
        {
            if (string.IsNullOrWhiteSpace(sp.TenSP))
            {
                message = "Tên sản phẩm không được để trống.";
                return false;
            }
            if (sp.GiaBan < 0)
            {
                message = "Giá bán không hợp lệ.";
                return false;
            }
            message = SanPhamDAO.Update(sp) ? "Cập nhật sản phẩm thành công!" : "Cập nhật thất bại.";
            return message.StartsWith("Cập nhật sản phẩm");
        }

        public static bool Delete(int id, out string message)
        {
            // TODO: kiểm tra ràng buộc nếu sản phẩm đã có ở hóa đơn, phiếu nhập...
            message = SanPhamDAO.Delete(id) ? "Xóa sản phẩm thành công!" : "Xóa thất bại.";
            return message.StartsWith("Xóa sản phẩm");
        }

        public static List<SanPham> Search(string keyword, string trangThai = null)
        {
            return SanPhamDAO.Search(keyword, trangThai);
        }
    }
}