using System;
using System.Collections.Generic;
using DTO;
using DataAccess;

namespace BUS
{
    public class PhieuNhapBUS
    {
        public static List<PhieuNhap> GetAll() => PhieuNhapDAO.GetAll();

        public static PhieuNhap GetById(int id) => PhieuNhapDAO.GetById(id);

        public static List<PhieuNhap> GetByNguoiDung(int maNguoiDung)
            => PhieuNhapDAO.GetByNguoiDung(maNguoiDung);

        public static int Insert(PhieuNhap phieu)
        {
            phieu.TrangThai = "ChoDuyet";
            return PhieuNhapDAO.Insert(phieu); // DAO xử lý transaction
        }

        public static bool Update(PhieuNhap pn)
            => PhieuNhapDAO.Update(pn);

        public static bool Delete(int id)
            => PhieuNhapDAO.Delete(id);

        public static List<PhieuNhap> Search(DateTime? from, DateTime? to, string trangThai = null)
            => PhieuNhapDAO.Search(from, to, trangThai);

        // --- Chi tiết phiếu nhập ---

        public static List<ChiTietPhieuNhap> GetChiTiet(int maPhieuNhap)
            => ChiTietPhieuNhapDAO.GetByPhieu(maPhieuNhap);

        public static bool AddChiTiet(ChiTietPhieuNhap ct)
            => ChiTietPhieuNhapDAO.Insert(ct);

        public static bool UpdateChiTiet(ChiTietPhieuNhap ct)
            => ChiTietPhieuNhapDAO.Update(ct);

        public static bool DeleteChiTiet(int maPhieuNhap, int maSP)
            => ChiTietPhieuNhapDAO.Delete(maPhieuNhap, maSP);

        internal static int Add(PhieuNhap pn)
        {
            throw new NotImplementedException();
        }
    }
}