namespace DTO

public class SanPham
{
    public int MaSP { get; set; }
    public string TenSP { get; set; }
    public string MoTa { get; set; }
    public decimal GiaBan { get; set; }
    public string DonViTinh { get; set; }
    public string TrangThai { get; set; } // "DangBan" hoặc "NgungBan"
}
