using System.Collections.Generic;
using DTO;
using DataAccess;

namespace BUS
{
    public class GioHangBUS
    {
        public static List<GioHang> GetByUser(int maNguoiDung)
        {
            return GioHangDAO.GetByUser(maNguoiDung);
        }

        public static bool Add(GioHang gh, out string message)
        {
            if (gh.SoLuong <= 0)
            {
                message = "Số lượng phải lớn hơn 0.";
                return false;
            }
            message = GioHangDAO.Insert(gh) ? "Thêm vào giỏ hàng thành công!" : "Thêm thất bại.";
            return message.StartsWith("Thêm vào giỏ hàng");
        }

        public static bool Update(GioHang gh, out string message)
        {
            if (gh.SoLuong <= 0)
            {
                message = "Số lượng phải lớn hơn 0.";
                return false;
            }
            message = GioHangDAO.Update(gh) ? "Cập nhật giỏ hàng thành công!" : "Cập nhật thất bại.";
            return message.StartsWith("Cập nhật giỏ hàng");
        }

        public static bool Delete(int maNguoiDung, int maSP, out string message)
        {
            message = GioHangDAO.Delete(maNguoiDung, maSP) ? "Xóa sản phẩm khỏi giỏ hàng thành công!" : "Xóa thất bại.";
            return message.StartsWith("Xóa sản phẩm");
        }

        public static bool Clear(int maNguoiDung, out string message)
        {
            message = GioHangDAO.Clear(maNguoiDung) ? "Xóa toàn bộ giỏ hàng thành công!" : "Xóa thất bại.";
            return message.StartsWith("Xóa toàn bộ");
        }
    }
}