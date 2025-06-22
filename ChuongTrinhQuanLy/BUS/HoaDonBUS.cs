using System;
using System.Collections.Generic;
using DTO;
using DataAccess;

namespace BUS
{
    public class HoaDonBUS
    {
        public static List<HoaDon> GetAll() => HoaDonDAO.GetAll();

        public static HoaDon GetById(int id) => HoaDonDAO.GetById(id);

        public static int Add(HoaDon hd)
        {
            hd.NgayLap = DateTime.Now;
            return HoaDonDAO.Insert(hd);
        }

        public static bool Update(HoaDon hd)
        {
            return HoaDonDAO.Update(hd);
        }

        public static bool Delete(int id)
        {
            // TODO: kiểm tra hóa đơn đã thanh toán chưa
            return HoaDonDAO.Delete(id);
        }

        public static List<HoaDon> Search(DateTime? from, DateTime? to)
        {
            return HoaDonDAO.Search(from, to);
        }

        // Chi tiết hóa đơn
        public static List<ChiTietHoaDon> GetChiTiet(int maHoaDon)
        {
            return ChiTietHoaDonDAO.GetByHoaDon(maHoaDon);
        }

        public static bool AddChiTiet(ChiTietHoaDon ct)
        {
            return ChiTietHoaDonDAO.Insert(ct);
        }

        public static bool UpdateChiTiet(ChiTietHoaDon ct)
        {
            return ChiTietHoaDonDAO.Update(ct);
        }

        public static bool DeleteChiTiet(int maHoaDon, int maSP)
        {
            return ChiTietHoaDonDAO.Delete(maHoaDon, maSP);
        }
    }
}