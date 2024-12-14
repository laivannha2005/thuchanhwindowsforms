-- Tạo cơ sở dữ liệu
CREATE DATABASE quanlythuvien;
GO

USE quanlythuvien;

-- Tạo bảng 'khoa'
CREATE TABLE khoa (
    makhoa INT PRIMARY KEY,
    tenkhoa NVARCHAR(100),
    diachi NVARCHAR(200),
    sdt CHAR(10) CHECK (sdt NOT LIKE '%[^0-9]%')
);

-- Tạo bảng 'nhanvien'
CREATE TABLE nhanvien (
    manhanvien INT PRIMARY KEY,
    hoten NVARCHAR(100),
    diachi NVARCHAR(200),
    tendangnhap NVARCHAR(100) UNIQUE,
    matkhau NVARCHAR(50),
    quyenhan NVARCHAR(50)
);

-- Tạo bảng 'sach'
CREATE TABLE sach (
    masach INT PRIMARY KEY,
    nhande NVARCHAR(200),
    sotrang INT,
    soluong INT,
    namxb INT,
    lanxb INT,
    solanmuon INT,
    loaisach NVARCHAR(100),
    nxb NVARCHAR(200),
    tacgia NVARCHAR(100),
    ngaynhap DATE
);

-- Tạo bảng 'docgia'
CREATE TABLE docgia (
    madocgia INT PRIMARY KEY,
    hovaten NVARCHAR(100),
    ngaysinh DATE,
    makhoa INT FOREIGN KEY REFERENCES khoa(makhoa),
    vitri NVARCHAR(200),
    diachi NVARCHAR(200),
    ngaylapthe DATE
);

-- Tạo bảng 'phieumuon'
CREATE TABLE phieumuon (
    maphieumuon INT PRIMARY KEY,
    madocgia INT FOREIGN KEY REFERENCES docgia(madocgia),
    thethumuon NVARCHAR(50),
    ngaymuon DATE,
    masach INT FOREIGN KEY REFERENCES sach(masach),
    manhanvien INT FOREIGN KEY REFERENCES nhanvien(manhanvien),
    soluong INT
);

-- Tạo bảng 'users'
CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(100) NULL,
    password NVARCHAR(100) NULL
);

-- Chèn dữ liệu vào bảng 'users'
INSERT INTO users (username, password) VALUES ('admin', 'nha123');

-- Chuyển cơ sở dữ liệu sang chế độ đa người dùng (nếu cần)
ALTER DATABASE quanlythuvien
SET MULTI_USER;
GO

-- Kiểm tra dữ liệu trong bảng 'users'
SELECT * FROM users;

ALTER DATABASE quanlythuvien
SET MULTI_USER;
GO