CREATE DATABASE QLCH;

USE QLCH;


drop table SanPham;
drop table NguoiDung;
drop table NhanVien;
drop table KhachHang;
drop table HoaDon;


-- Tạo bảng NguoiDung với khóa chính
CREATE TABLE NguoiDung (
    TaiKhoan NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50)
);

-- Tạo bảng KhachHang với khóa chính và khóa ngoại tham chiếu đến NguoiDung
CREATE TABLE KhachHang (
    MaKH NVARCHAR(10) PRIMARY KEY,
    HoVaTen NVARCHAR(100),
    TaiKhoan NVARCHAR(50),
    MatKhau NVARCHAR(50),
    DiaChi NVARCHAR(255),
    GioiTinh NVARCHAR(3),
    SDT NVARCHAR(15),
);

-- Tạo bảng NhanVien với khóa chính và khóa ngoại tham chiếu đến NguoiDung
CREATE TABLE NhanVien (
    MaNV NVARCHAR(10) PRIMARY KEY,
    TenNV NVARCHAR(100),
    ViTri NVARCHAR(100),
    SDT NVARCHAR(15),
    NgaySinh DATE,
    GioiTinh NVARCHAR(3),
    TaiKhoan NVARCHAR(50),
    MatKhau NVARCHAR(50),
    FOREIGN KEY (TaiKhoan) REFERENCES NguoiDung(TaiKhoan)
);

-- Tạo bảng SanPham với khóa chính
CREATE TABLE SanPham (
    MaSP NVARCHAR(10) PRIMARY KEY,
    TenSP NVARCHAR(100),
    GiaNhap INT,
    GiaBan INT,
    TinhTrang NVARCHAR(50),
    NgayNhap DATE,
    SoLuong INT,
    DaBan INT,
    ChatLieu NVARCHAR(50),
    CTSanXuat NVARCHAR(100)
);

-- Tạo bảng HoaDon với khóa chính và khóa ngoại tham chiếu đến KhachHang, NhanVien, và SanPham
CREATE TABLE HoaDon (
    ID INT PRIMARY KEY IDENTITY,
    MaKH NVARCHAR(10),
    HoVaTen NVARCHAR(100),
    MaSP NVARCHAR(10),
    TenSP NVARCHAR(100),
    DaBan INT,
    MaNV NVARCHAR(10),
    TenNV NVARCHAR(100),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);




INSERT INTO NguoiDung (TaiKhoan, MatKhau)
VALUES 
    ('TranVanX123', 'VanX'),
    ('NguyenThiY456', 'ThiY'),
    ('LeVanZ789', 'VanZ'),
    ('PhamThiW321', 'ThiW'),
    ('HoangVanU654', 'VanU'),
    ('NguyenThiV987', 'ThiV'),
    ('TranVanS012', 'VanS'),
    ('LeThiR345', 'ThiR'),
    ('PhanVanQ678', 'VanQ'),
    ('DoThiP901', 'ThiP');


INSERT INTO KhachHang (MaKH, HoVaTen, TaiKhoan, MatKhau, DiaChi, GioiTinh, SDT)
VALUES 
    ('KH001', 'Nguyen Van A', 'NguyenVanA123', 'VanA', '123 Duong ABC', 'Nam', '0123456789'),
    ('KH002', 'Tran Thi B', 'TranThiB456', 'ThiB', '456 Duong XYZ', 'Nu', '0987654321'),
    ('KH003', 'Le Van C', 'LeVanC789', 'VanC', '789 Duong DEF', 'Nam', '0365987412'),
    ('KH004', 'Pham Thi D', 'PhamThiD321', 'ThiD', '321 Duong GHI', 'Nu', '0789456123'),
    ('KH005', 'Hoang Van E', 'HoangVanE654', 'VanE', '654 Duong JKL', 'Nam', '0369852147'),
    ('KH006', 'Nguyen Thi F', 'NguyenThiF987', 'ThiF', '987 Duong MNO', 'Nu', '0912345678'),
    ('KH007', 'Tran Van G', 'TranVanG234', 'VanG', '234 Duong PQR', 'Nam', '0975318642'),
    ('KH008', 'Le Thi H', 'LeThiH567', 'ThiH', '567 Duong STU', 'Nu', '0654321987'),
    ('KH009', 'Phan Van I', 'PhanVanI890', 'VanI', '890 Duong VWX', 'Nam', '0321654987'),
    ('KH010', 'Do Thi K', 'DoThiK012', 'ThiK', '012 Duong YZA', 'Nu', '0968745123');



INSERT INTO NhanVien (MaNV, TenNV, ViTri, SDT, NgaySinh, GioiTinh, TaiKhoan, MatKhau)
VALUES 
    ('NV001', 'Tran Van X', 'Quan ly cua hang', '0123456789', '1990-01-01', 'Nam', 'TranVanX123', 'VanX'),
    ('NV002', 'Nguyen Thi Y', 'Nhan vien ban hang', '0987654321', '1995-05-15', 'Nu', 'NguyenThiY456', 'ThiY'),
    ('NV003', 'Le Van Z', 'Ke toan', '0365987412', '1988-12-20', 'Nam', 'LeVanZ789', 'VanZ'),
    ('NV004', 'Pham Thi W', 'Nhan vien van chuyen', '0789456123', '1992-09-10', 'Nu', 'PhamThiW321', 'ThiW'),
    ('NV005', 'Hoang Van U', 'Nhan vien ky thuat', '0369852147', '1987-03-25', 'Nam', 'HoangVanU654', 'VanU'),
    ('NV006', 'Nguyen Thi V', 'Chuyen vien marketing', '0912345678', '1984-07-18', 'Nu', 'NguyenThiV987', 'ThiV'),
    ('NV007', 'Tran Van S', 'Quan ly san xuat', '0975318642', '1979-11-30', 'Nam', 'TranVanS012', 'VanS'),
    ('NV008', 'Le Thi R', 'Nhan vien kinh doanh', '0654321987', '1998-02-05', 'Nu', 'LeThiR345', 'ThiR'),
    ('NV009', 'Phan Van Q', 'Bao ve', '0321654987', '1993-06-12', 'Nam', 'PhanVanQ678', 'VanQ'),
    ('NV010', 'Do Thi P', 'Nhan vien ho tro khach hang', '0968745123', '1996-08-08', 'Nu', 'DoThiP901', 'ThiP');



INSERT INTO SanPham (MaSP, TenSP, GiaNhap, GiaBan, TinhTrang, NgayNhap, SoLuong, DaBan, ChatLieu, CTSanXuat)
VALUES 
    ('SP001', 'Ao so mi nam', 200000, 350000, 'Moi', '2024-04-14', 50, 20, 'Vai', 'San xuat tai VPN'),
    ('SP002', 'Quan jean nam', 250000, 400000, 'Moi', '2024-04-14', 40, 15, 'Jean', 'San xuat tai VCC'),
    ('SP003', 'Ao thun nu', 150000, 280000, 'Moi', '2024-04-14', 60, 25, 'Cotton', 'San xuat tai VCX'),
    ('SP004', 'Vay dam cong so', 300000, 500000, 'Moi', '2024-04-14', 30, 10, 'Vai', 'San xuat tai VCX'),
    ('SP005', 'Ao khoac nam', 400000, 700000, 'Moi', '2024-04-14', 35, 12, 'Vai du', 'San xuat tai VNN'),
    ('SP006', 'Quan short nu', 180000, 320000, 'Moi', '2024-04-14', 45, 18, 'Polyester', 'San xuat tai VNN'),
    ('SP007', 'Ao len nam', 220000, 380000, 'Moi', '2024-04-14', 25, 8, 'Len', 'San xuat tai VPN'),
    ('SP008', 'Ao khoac nu', 350000, 600000, 'Moi', '2024-04-14', 20, 7, 'Vai du', 'San xuat tai VPN'),
    ('SP009', 'Quan tay nam', 280000, 450000, 'Moi', '2024-04-14', 30, 11, 'Vai', 'San xuat tai VCX'),
    ('SP010', 'Vay dam du tiec', 500000, 900000, 'Moi', '2024-04-14', 15, 5, 'Ren', 'San xuat tai VCC');



-- Thêm dữ liệu vào bảng HoaDon
INSERT INTO HoaDon (MaKH, HoVaTen, MaSP, TenSP, DaBan, MaNV, TenNV)
VALUES 
    ('KH001', 'Nguyen Van A', 'SP001', 'Ao so mi nam', 2, 'NV001', 'Tran Van X'),
    ('KH002', 'Tran Thi B', 'SP002', 'Quan jean nam', 3, 'NV002', 'Nguyen Thi Y'),
    ('KH003', 'Le Van C', 'SP003', 'Ao thun nu', 1, 'NV003', 'Le Van Z'),
    ('KH004', 'Pham Thi D', 'SP004', 'Vay dam cong so', 2, 'NV004', 'Pham Thi W'),
    ('KH005', 'Hoang Van E', 'SP005', 'Ao khoac nam', 1, 'NV005', 'Hoang Van U'),
    ('KH006', 'Nguyen Thi F', 'SP006', 'Quan short nu', 4, 'NV006', 'Nguyen Thi V'),
    ('KH007', 'Tran Van G', 'SP007', 'Ao len nam', 2, 'NV007', 'Tran Van S'),
    ('KH008', 'Le Thi H', 'SP008', 'Ao khoac nu', 3, 'NV008', 'Le Thi R'),
    ('KH009', 'Phan Van I', 'SP009', 'Quan tay nam', 1, 'NV009', 'Phan Van Q'),
    ('KH010', 'Do Thi K', 'SP010', 'Vay dam du tiec', 2, 'NV010', 'Do Thi P');




