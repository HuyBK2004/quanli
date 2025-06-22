using System.Collections.Generic;
using DTO;
using DataAccess;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        public static List<ChiTietPhieuNhap> GetByPhieuNhap(int maPhieuNhap)
        {
            return ChiTietPhieuNhapDAO.GetByPhieuNhap(maPhieuNhap);
        }

        public static bool Add(ChiTietPhieuNhap ct, out string message)
        {
            if (ct.SoLuong <= 0)
            {
                message = "Số lượng phải lớn hơn 0.";
                return false;
            }
            if (ct.GiaNhap < 0)
            {
                message = "Giá nhập không hợp lệ.";
                return false;
            }
            message = ChiTietPhieuNhapDAO.Insert(ct) ? "Thêm chi tiết thành công!" : "Thêm thất bại.";
            return message.StartsWith("Thêm chi tiết");
        }

        public static bool Update(ChiTietPhieuNhap ct, out string message)
        {
            if (ct.SoLuong <= 0)
            {
                message = "Số lượng phải lớn hơn 0.";
                return false;
            }
            if (ct.GiaNhap < 0)
            {
                message = "Giá nhập không hợp lệ.";
                return false;
            }
            message = ChiTietPhieuNhapDAO.Update(ct) ? "Cập nhật thành công!" : "Cập nhật thất bại.";
            return message.StartsWith("Cập nhật thành công");
        }

        public static bool Delete(int maPhieuNhap, int maSP, out string message)
        {
            message = ChiTietPhieuNhapDAO.Delete(maPhieuNhap, maSP) ? "Xóa thành công!" : "Xóa thất bại.";
            return message.StartsWith("Xóa thành công");
        }
    }
}