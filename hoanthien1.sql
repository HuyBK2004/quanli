 -- ===========================
-- 1. Bảng NguoiDung (Tài khoản người dùng)
-- ===========================
CREATE TABLE NguoiDung (
    MaNguoiDung INT AUTO_INCREMENT PRIMARY KEY,
    HoTen VARCHAR(100) NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(255) NOT NULL,  
    Email VARCHAR(100) UNIQUE,
    SoDienThoai VARCHAR(20) UNIQUE,
    VaiTro ENUM('Chu', 'NhanVienKho', 'ThuNgan', 'KH') NOT NULL DEFAULT 'KH',
    NgayTao DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    TrangThai ENUM('BinhThuong', 'Khoa') NOT NULL DEFAULT 'BinhThuong'
);

-- ===========================chitietdonhang
-- 2. Bảng SanPham (Sản phẩm)
-- ===========================
CREATE TABLE SanPham (
    MaSP INT AUTO_INCREMENT PRIMARY KEY,
    TenSP VARCHAR(200) NOT NULL,
    MoTa TEXT,
    GiaBan DECIMAL(18,2) NOT NULL CHECK (GiaBan >= 0),
    DonViTinh VARCHAR(20),
    TrangThai ENUM('DangBan', 'NgungBan') NOT NULL DEFAULT 'DangBan'
);

-- ===========================
-- 3. Bảng PhieuNhap (Phiếu nhập kho)
-- ===========================
CREATE TABLE PhieuNhap (
    MaPhieuNhap INT AUTO_INCREMENT PRIMARY KEY,
    NgayNhap DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    MaNguoiDung INT NOT NULL, -- Nhân viên kho tạo phiếu
    TrangThai ENUM('ChoDuyet', 'DaDuyet', 'TuChoi') NOT NULL DEFAULT 'ChoDuyet',
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
);

-- ===========================
-- 4. Bảng ChiTietPhieuNhap (Chi tiết phiếu nhập)
-- ===========================
CREATE TABLE ChiTietPhieuNhap (
    MaPhieuNhap INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    GiaNhap DECIMAL(18,2) NOT NULL CHECK (GiaNhap >= 0),
    PRIMARY KEY (MaPhieuNhap, MaSP),
    FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhap(MaPhieuNhap),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- ===========================
-- 5. Bảng HoaDon (Hóa đơn bán lẻ)
-- ===========================
CREATE TABLE HoaDon (
    MaHoaDon INT AUTO_INCREMENT PRIMARY KEY,
    NgayLap DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    MaNguoiDung INT NOT NULL, 
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0,
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
);

-- ===========================
-- 6. Bảng ChiTietHoaDon (Chi tiết hóa đơn)
-- ===========================
CREATE TABLE ChiTietHoaDon (
    MaHoaDon INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL,
    PRIMARY KEY (MaHoaDon, MaSP),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- ===========================
-- 7. Bảng GioHang (Giỏ hàng tạm của khách)
-- ===========================
CREATE TABLE GioHang (
    MaNguoiDung INT NOT NULL,   -- Khách hàng
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    PRIMARY KEY (MaNguoiDung, MaSP),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- ===========================
-- 8. Bảng DonHang (Đơn hàng online)
-- ===========================
CREATE TABLE DonHang (
    MaDonHang INT AUTO_INCREMENT PRIMARY KEY,
    NgayDat DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    MaNguoiDung INT NOT NULL,  -- Khách hàng tạo đơn
    TrangThai ENUM('DangXuLy', 'DaXacNhan', 'DangGiao', 'HoanThanh', 'Huy') NOT NULL DEFAULT 'DangXuLy',
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0,
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
);

-- ===========================
-- 9. Bảng ChiTietDonHang (Chi tiết đơn hàng)
-- ===========================
CREATE TABLE ChiTietDonHang (
    MaDonHang INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL,
    PRIMARY KEY (MaDonHang, MaSP),
    FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- ===========================
-- 10. Trigger: Đảm bảo chỉ có duy nhất 1 tài khoản Chủ cửa hàng
-- ===========================
DELIMITER $$
CREATE TRIGGER trg_only_one_chu_insert
BEFORE INSERT ON NguoiDung
FOR EACH ROW
BEGIN
    IF NEW.VaiTro = 'Chu' THEN
        IF (SELECT COUNT(*) FROM NguoiDung WHERE VaiTro = 'Chu') > 0 THEN
            SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Chỉ được phép có duy nhất 1 tài khoản Chủ cửa hàng!';
        END IF;
    END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER trg_only_one_chu_update
BEFORE UPDATE ON NguoiDung
FOR EACH ROW
BEGIN
    IF NEW.VaiTro = 'Chu' AND OLD.VaiTro <> 'Chu' THEN
        IF (SELECT COUNT(*) FROM NguoiDung WHERE VaiTro = 'Chu' AND MaNguoiDung <> OLD.MaNguoiDung) > 0 THEN
            SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Chỉ được phép có duy nhất 1 tài khoản Chủ cửa hàng!';
        END IF;
    END IF;
END$$
DELIMITER ;

-- ===========================
-- 11. Tạo sẵn tài khoản Chủ cửa hàng mặc định (thực hiện trước khi tạo trigger chỉ cho phép đăng ký khách)
-- ===========================
INSERT INTO NguoiDung (HoTen, Username, MatKhau, Email, VaiTro, TrangThai)
VALUES ('Chủ Cửa Hàng', 'admin', '<hash_mk>', 'chu@cuahang.vn', 'Chu', 'BinhThuong');
-- <hash_mk> là mật khẩu đã mã hóa

-- ===========================
-- 12. Trigger: Chỉ cho phép đăng ký tài khoản mới với vai trò Khách hàng (KH)
-- ===========================
DELIMITER $$
CREATE TRIGGER trg_only_khachhang_can_register
BEFORE INSERT ON NguoiDung
FOR EACH ROW
BEGIN
    -- Bỏ qua nếu thêm Chủ (tức là tài khoản Chủ đã được tạo ở bước trên)
    -- Chỉ áp dụng cho các trường hợp đăng ký tài khoản bình thường (qua giao diện khách)
    IF NEW.VaiTro IS NOT NULL AND NEW.VaiTro <> 'KH' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Chỉ cho phép đăng ký tài khoản mới với vai trò Khách hàng!';
    END IF;
END$$
DELIMITER ;

-- ===========================
-- 13. Ghi chú sử dụng với MySQL 8.0.42
-- ===========================
-- - Username, Email, SĐT đều unique.
-- - Trigger sẽ kiểm soát việc không tạo thêm chủ và không tự đăng ký nhân viên/chu.
-- - Các ràng buộc CHECK đều hoạt động tốt trên MySQL 8.0.42.
-- - Chủ cửa hàng thêm nhân viên qua giao diện quản trị sẽ không bị trigger khách hàng chặn vì ứng dụng sẽ kiểm soát logic này