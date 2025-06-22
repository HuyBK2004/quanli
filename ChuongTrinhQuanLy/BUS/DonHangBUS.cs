using System;
using System.Collections.Generic;
using DTO;
using DataAccess;

namespace BUS
{
    public class DonHangBUS
    {
        public static List<DonHang> GetAll() => DonHangDAO.GetAll();

        public static DonHang GetById(int id) => DonHangDAO.GetById(id);

        public static int Add(DonHang dh)
        {
            dh.NgayDat = DateTime.Now;
            dh.TrangThai = "DangXuLy";
            return DonHangDAO.Insert(dh);
        }

        public static bool Update(DonHang dh)
        {
            return DonHangDAO.Update(dh);
        }

        public static bool Delete(int id)
        {
            // TODO: kiểm tra đơn hàng đã giao chưa
            return DonHangDAO.Delete(id);
        }

        public static List<DonHang> Search(DateTime? from, DateTime? to, int? maNguoiDung = null)
        {
            return DonHangDAO.Search(from, to, maNguoiDung);
        }

        // Chi tiết đơn hàng
        public static List<ChiTietDonHang> GetChiTiet(int maDonHang)
        {
            return ChiTietDonHangDAO.GetByDonHang(maDonHang);
        }

        public static bool AddChiTiet(ChiTietDonHang ct)
        {
            return ChiTietDonHangDAO.Insert(ct);
        }

        public static bool UpdateChiTiet(ChiTietDonHang ct)
        {
            return ChiTietDonHangDAO.Update(ct);
        }

        public static bool DeleteChiTiet(int maDonHang, int maSP)
        {
            return ChiTietDonHangDAO.Delete(maDonHang, maSP);
        }

        // Giỏ hàng
        public static List<GioHang> GetGioHang(int maNguoiDung)
        {
            return GioHangDAO.GetByUser(maNguoiDung);
        }

        public static bool AddGioHang(GioHang gh)
        {
            return GioHangDAO.Insert(gh);
        }

        public static bool UpdateGioHang(GioHang gh)
        {
            return GioHangDAO.Update(gh);
        }

        public static bool DeleteGioHang(int maNguoiDung, int maSP)
        {
            return GioHangDAO.Delete(maNguoiDung, maSP);
        }

        public static bool ClearGioHang(int maNguoiDung)
        {
            return GioHangDAO.Clear(maNguoiDung);
        }
    }
}