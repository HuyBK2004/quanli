using System;
using System.Collections.Generic;

namespace DTO
{
    public class PhieuNhap
    {
      public int MaPhieuNhap { get; set; }
    public DateTime NgayNhap { get; set; }
    public int MaNguoiDung { get; set; } // Nhân viên kho
    public string TrangThai { get; set; } // "ChoDuyet", "DaDuyet", "TuChoi"
    }
}
