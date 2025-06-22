using System.Collections.Generic;
using DTO;
using DataAccess;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        public static List<ChiTietHoaDon> GetByHoaDon(int maHoaDon)
        {
            return ChiTietHoaDonDAO.GetByHoaDon(maHoaDon);
        }

        public static bool Add(ChiTietHoaDon ct, out string message)
        {
            if (ct.SoLuong <= 0)
            {
                message = "Số lượng phải lớn hơn 0.";
                return false;
            }
            if (ct.DonGia < 0)
            {
                message = "Đơn giá không hợp lệ.";
                return false;
            }
            message = ChiTietHoaDonDAO.Insert(ct) ? "Thêm chi tiết thành công!" : "Thêm thất bại.";
            return message.StartsWith("Thêm chi tiết");
        }

        public static bool Update(ChiTietHoaDon ct, out string message)
        {
            if (ct.SoLuong <= 0)
            {
                message = "Số lượng phải lớn hơn 0.";
                return false;
            }
            if (ct.DonGia < 0)
            {
                message = "Đơn giá không hợp lệ.";
                return false;
            }
            message = ChiTietHoaDonDAO.Update(ct) ? "Cập nhật thành công!" : "Cập nhật thất bại.";
            return message.StartsWith("Cập nhật thành công");
        }

        public static bool Delete(int maHoaDon, int maSP, out string message)
        {
            message = ChiTietHoaDonDAO.Delete(maHoaDon, maSP) ? "Xóa thành công!" : "Xóa thất bại.";
            return message.StartsWith("Xóa thành công");
        }
    }
}