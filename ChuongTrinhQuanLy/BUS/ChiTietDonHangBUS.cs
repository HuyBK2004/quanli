using System.Collections.Generic;
using DTO;
using DataAccess;

namespace BUS
{
    public class ChiTietDonHangBUS
    {
        public static List<ChiTietDonHang> GetByDonHang(int maDonHang)
        {
            return ChiTietDonHangDAO.GetByDonHang(maDonHang);
        }

        public static bool Add(ChiTietDonHang ct, out string message)
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
            message = ChiTietDonHangDAO.Insert(ct) ? "Thêm chi tiết thành công!" : "Thêm thất bại.";
            return message.StartsWith("Thêm chi tiết");
        }

        public static bool Update(ChiTietDonHang ct, out string message)
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
            message = ChiTietDonHangDAO.Update(ct) ? "Cập nhật thành công!" : "Cập nhật thất bại.";
            return message.StartsWith("Cập nhật thành công");
        }

        public static bool Delete(int maDonHang, int maSP, out string message)
        {
            message = ChiTietDonHangDAO.Delete(maDonHang, maSP) ? "Xóa thành công!" : "Xóa thất bại.";
            return message.StartsWith("Xóa thành công");
        }
    }
}