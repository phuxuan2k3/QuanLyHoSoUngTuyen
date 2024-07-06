DECLARE @DatabaseName nvarchar(50)
SET @DatabaseName = N'QL_HSUT'

DECLARE @SQL varchar(max)

SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
FROM MASTER..SysProcesses
WHERE DBId = DB_ID(@DatabaseName) AND SPId <> @@SPId

--SELECT @SQL 
EXEC(@SQL)

USE master
IF EXISTS(select * from sys.databases where name='QL_HSUT')
DROP DATABASE QL_HSUT
GO

/*==============================================================*/
/*==============================================================*/

create database QL_HSUT;
go
use QL_HSUT;
go

--use master;
--CREATE DATABASE QL_HSUT;
--drop DATABASE QL_HSUT;
-- Creating tables

-- Table TAIKHOAN
create table TAIKHOAN (
    TenTaiKhoan varchar(50) not null primary key,
    MatKhau varchar(255),
	VaiTro  nvarchar(20),
	CONSTRAINT CK_VAITRO CHECK (VAITRO IN (N'Doanh nghiệp', N'Nhân viên', N'Ứng viên'))
);
go
select * from TAIKHOAN;
-- Table NHANVIEN
create table NHANVIEN (
    MaNhanVien varchar(50) not null primary key,
    TenNhanVien nvarchar(100),
    DiaChi nvarchar(255),
    TenTaiKhoan varchar(50) not null,

    foreign key (TenTaiKhoan) references TAIKHOAN(TenTaiKhoan)
);
go

-- Table UNGVIEN
create table UNGVIEN (
    MaUngVien varchar(50) not null primary key,
    TenUngVien nvarchar(100),
    DiaChi nvarchar(255),
	Email varchar(255),
    TenTaiKhoan varchar(50) not null,

    foreign key (TenTaiKhoan) references TAIKHOAN(TenTaiKhoan)
);
go


-- Table DOANHNGHIEP
create table DOANHNGHIEP (
    MaDoanhNghiep int not null IDENTITY(1,1) primary key,
    TenDoanhNghiep nvarchar(100),
    MASOTHUE             varchar(10)          null,
    NGUOIDAIDIEN         nvarchar(50)          null,
    DIACHI               nvarchar(50)          null,
    EMAIL                varchar(50)          null,
    TRANGTHAI            nvarchar(20)          null,
    NGAYDK               datetime             null,
    TenTaiKhoan varchar(50) not null,
	foreign key (TenTaiKhoan) references TAIKHOAN(TenTaiKhoan),
    CONSTRAINT CK_TRANGTHAI_DOANHNGHIEP CHECK (TRANGTHAI IN (N'Chưa xác thực', N'Không hợp lệ', N'Hợp lệ', N'Tiềm năng')),

);
go


-- Table CHIENLUOCUUDAI
create table CHIENLUOCUUDAI (
    MaChienLuoc int not null IDENTITY(1,1) primary key,
    TenChienLuoc nvarchar(100),
    MoTa nvarchar(255)
);
go

-- Table CT_CLUD
create table CT_CLUD (
    MaChienLuoc int not null,
    MaDoanhNghiep int not null,
    primary key (MaChienLuoc, MaDoanhNghiep),
    foreign key (MaChienLuoc) references CHIENLUOCUUDAI(MaChienLuoc),
    foreign key (MaDoanhNghiep) references DOANHNGHIEP(MaDoanhNghiep)
);
go

-- Table HINHTHUCDANGTUYEN
create table HINHTHUCDANGTUYEN (
    MaHinhThuc varchar(50) not null primary key,
    TenHinhThuc nvarchar(100),
    MoTa nvarchar(100) null,
    Gia float
);
go

-- table THONGTINDANGTUYEN
create table THONGTINDANGTUYEN (
   MATTDT               int                  not null IDENTITY(1,1),
   MADN                 int          null,
   SONGAYDT             int                  null,
   MAHTDT               varchar(50)          null,
   THOIGIANDANGTUYEN    date                 null,
   TRANGTHAI            nvarchar(20)         null,
   TINHTRANG            nvarchar(20)         null,
   TENVITRI             nvarchar(50)         null,
   SOLUONG              int                  null,
   YEUCAU               nvarchar(100)        null,
   constraint PK_THONGTINDANGTUYEN primary key (MATTDT),
   CONSTRAINT CK_TRANGTHAI_TTDT CHECK (TRANGTHAI IN (N'Chưa xét duyệt', N'Không hợp lệ', N'Hợp lệ')),
   CONSTRAINT CK_TINHTRANG_TTDT CHECK (TINHTRANG IN(N'Chưa đăng tuyển', N'Đã đăng tuyển', N'Cần hiệu chỉnh') ),
   foreign key (MAHTDT) references HINHTHUCDANGTUYEN(MaHinhThuc)
)

-- Table HOADON
create table HOADON (
   MATTDT               int                  not null,
   TONGTIEN             float                null,
   CACHTHUC             Nvarchar(30)             null,
   TRANGTHAI            Nvarchar(30)          null,
   NGAYLAP              datetime             null,
   constraint PK_HOADON primary key (MATTDT),
   CONSTRAINT CK_TRANGTHAI CHECK (TRANGTHAI IN (N'Chưa thanh toán hoàn tất', N'Đã thanh toán hoàn tất', N'Chưa thanh toán')),
   CONSTRAINT CK_CACHTHUC CHECK (CACHTHUC IN (N'Toàn bộ', N'Nhiều đợt')),
   foreign key (MATTDT) references THONGTINDANGTUYEN(MATTDT)
);
go

-- Table HS_CT_BC
create table HS_CT_BC (
    MACTBC             int not null IDENTITY(1,1) primary key,
    MaUngVien varchar(50) not null,
	TENCTBC              nvarchar(255)          null,
    foreign key (MaUngVien) references UNGVIEN(MaUngVien)
);
go



-- Table PHIEUDANGKYUNGTUYEN

create table PHIEUDANGKYUNGTUYEN (
   MATTDT               int not null, 
   MAUV                 varchar(50)                  not null,
   TRANGTHAI            Nvarchar(20)          null,
   constraint PK_PHIEUDANGKYUNGTUYEN primary key (MATTDT, MAUV),
   CONSTRAINT CK_TRANGTHAI_PDK CHECK (TRANGTHAI IN (N'Chưa xét duyệt', N'Không hợp lệ', N'Hợp lệ', N'Đã xử lý',N'Đạt',N'Không đạt')),
   foreign key (MATTDT) references THONGTINDANGTUYEN(MATTDT),
   foreign key (MAUV) references UNGVIEN(MaUngVien)
)
go

-- Table CT_HOADON
create table CT_HOADON (
    MaTTDT int not null,
    LanTT int not null,
	SoTienCanThanhToan float not null,
	NgayThanhToan date not null,
    primary key (MaTTDT, LanTT),
    foreign key (MaTTDT) references HOADON(MaTTDT)
);
go

-- Table CT_PDKUT
create table CT_PDKUT (
   MATTDT               int                  not null,
   MAUV                 varchar(50)                 not null,
   MACTBC               int                  not null,
   constraint PK_CT_PDKUT primary key (MATTDT, MAUV, MACTBC),
   foreign key (MATTDT,MAUV) references PHIEUDANGKYUNGTUYEN(MaTTDT, MAUV),
   foreign key (MACTBC) references HS_CT_BC(MACTBC)
);
go


-------------INSERT-------------
-- Insert   TAIKHOAN
INSERT INTO TAIKHOAN (TenTaiKhoan, MatKhau, VaiTro) VALUES
('NV01', 'NV01', N'Nhân viên'),
('NV02', 'NV02', N'Nhân viên'),
('NV03', 'NV03', N'Nhân viên'),
('NV04', 'NV04', N'Nhân viên'),
('NV05', 'NV05', N'Nhân viên'),
('UV01', '123', N'Ứng viên'),
('UV02', '111', N'Ứng viên'),
('UV03', '555', N'Ứng viên'),
('DN01', 'DN1', N'Doanh nghiệp'),
('DN02', 'DN2', N'Doanh nghiệp'),
('NV11', 'NV11', N'Nhân viên'),
('NV12', 'NV12', N'Nhân viên'),
('UV04', '222', N'Ứng viên'),
('DN03', 'DN3', N'Doanh nghiệp'),
('DN04', 'DN4', N'Doanh nghiệp');
GO

SELECT * FROM TAIKHOAN;
GO
-- Insert   NHANVIEN
INSERT INTO NHANVIEN (MaNhanVien, TenNhanVien, DiaChi, TenTaiKhoan) VALUES
('NV01', N'Nguyễn Văn Tùng', N'Xã Quy Kỳ-Huyện Định Hóa-Tỉnh Thái Nguyên', 'NV01'),
('NV02', N'Trần Kim Tuyến', N'Phường Trần Phú-Thành phố Hà Giang-Tỉnh Hà Giang', 'NV02'),
('NV03', N'Lê Thành Công', N'Xã Phú Trung-Huyện Tân Phú-Tỉnh Đồng Nai', 'NV03'),
('NV04', N'Phạm Thị Hồng Thắm', N'Phường 5-Thành phố Tân An-Tỉnh Long An', 'NV04'),
('NV05', N'Vũ Văn Thành', N'Phường 11-Quận 6-Thành phố Hồ Chí Minh', 'NV05'),
('NV11', N'Hoàng Thị Cúc', N'Xã Trung Thành Tây-Huyện  Vũng Liêm-Tỉnh Vĩnh Long', 'NV11'),
('NV12', N'Trịnh Văn Hoàng', N'Phường Phan Bội Châu-Quận Hồng Bàng-Thành phố Hải Phòng', 'NV12');
GO
select * from nhanvien;
go
-- Insert   UNGVIEN
INSERT INTO UNGVIEN (MaUngVien, TenUngVien, DiaChi,Email, TenTaiKhoan) VALUES
('082203564448', N'Hoàng Văn Thụ', N'Xã Hương Trạch-Huyện Hương Khê-Tỉnh Hà Tĩnh','HVThuCV@gmailcom', 'UV01'),
('082203564879', N'Đỗ Kim Hoàng', N'Xã Tân Trung-Huyện Phú Tân-Tỉnh An Giang','DKimHoangCV@gmailcom', 'UV02'),
('082203656888', N'Vũ Văn Khánh', N'Xã Hòa Sơn-Huyện Krông Bông-Tỉnh Đắk Lắk', 'VuKhanhCV@gmailcom','UV03'),
('082203666558', N'Ngô Thành Khánh Sơn', N'Xã Giao Xuân-Huyện Giao Thủy-Tỉnh Nam Định','NgKhnhSonCV@gmailcom', 'UV04');
GO
select * from ungvien;
go
-- Insert   DOANHNGHIEP
INSERT INTO DOANHNGHIEP (TenDoanhNghiep, MaSoThue, NguoiDaiDien, DiaChi, Email, TrangThai, NgayDK, TenTaiKhoan) VALUES
( N'Công ty Thành Công', '1234567890', N'Nguyễn Văn Ích', N'Phường Trần Phú-Thành phố Hà Giang-Tỉnh Hà Giang', 'abc@example.com', N'Không hợp lệ', '2023-01-01', 'DN01'),
( N'Công ty Thái Hà', '0987654321', N'Trần Thị Hà', N'Thị trấn Bình Minh-Huyện Kim Sơn-Tỉnh Ninh Bình', 'xyz@example.com', N'Hợp lệ', '2023-02-01', 'DN02'),
( N'Công ty Phát Phú', '1122334455', N'Hoàng Văn Khánh', N'Phường Liễu Giai-Quận Ba Đình-Thành phố Hà Nội', 'def@example.com', N'Tiềm năng', '2023-03-01', 'DN03'),
( N'Công ty Hoàng Văn', '2233445566', N'Vũ Thị Lệ', N'Xã Tân Phong-Huyện Kiến Thuỵ-Thành phố Hải Phòng', 'ghi@example.com', N'Chưa xác thực', '2023-04-01', 'DN04');
GO
select * from DOANHNGHIEP;
go

-- Insert   CHIENLUOCUUDAI
INSERT INTO CHIENLUOCUUDAI (TenChienLuoc, MoTa) VALUES
(N'Chiến lược 1', N'Mô tả chiến lược 1'),
(N'Chiến lược 2', N'Mô tả chiến lược 2'),
(N'Chiến lược 3', N'Mô tả chiến lược 3'),
(N'Chiến lược 4', N'Mô tả chiến lược 4'),
(N'Chiến lược 5', N'Mô tả chiến lược 5');
GO
select * from CHIENLUOCUUDAI;
go
-- Insert   CT_CLUD
INSERT INTO CT_CLUD (MaChienLuoc, MaDoanhNghiep) VALUES
(1, 1),
(2, 2),
(3,3),
(4, 4)
GO
select * from CT_CLUD;
go
-- Insert   HINHTHUCDANGTUYEN
INSERT INTO HINHTHUCDANGTUYEN (MaHinhThuc, TenHinhThuc, MoTa, Gia) VALUES
('HT001', N'Đăng bài quảng cáo','abc', 2000),
('HT002', N'Phát hành báo quảng cáo','bcd', 3000);
GO
select * from HINHTHUCDANGTUYEN;
go
-- Insert   THONGTINDANGTUYEN
INSERT INTO THONGTINDANGTUYEN (MaDN, SoNgayDT, MaHTDT, ThoiGianDangTuyen, TINHTRANG, TRANGTHAI, TenViTri, SoLuong, YeuCau) VALUES
(1, 1, 'HT001', '2024-7-5' , N'Chưa đăng tuyển', N'Chưa xét duyệt', N'Dev,BA,TEST', 3, N'Biết lập trình Java'),
(2, 1, 'HT001', '2024-7-5', N'Đã đăng tuyển', N'Hợp lệ', N'Kế toán', 2,N'Tốt nghiệp đại học chuyên ngành kế toán'),
(3, 1, 'HT001', '2024-7-5', N'Chưa đăng tuyển', N'Chưa xét duyệt', N'Thực tập sinh', 5, N'Sinh viên năm cuối'),
(2, 1, 'HT001', '2024-7-5', N'Chưa đăng tuyển', N'Chưa xét duyệt', N'Nhà thiết kế đồ họa', 1, N'Sử dụng thành thạo Photoshop'),
(4, 1, 'HT001', '2024-6-5', N'Đã đăng tuyển', N'Hợp lệ', N'Quản lý dự án', 2, N'Kinh nghiệm 3 năm trong quản lý dự án'),
(2, 1, 'HT001', '2024-6-5', N'Đã đăng tuyển', N'Hợp lệ', N'Chuyên viên tư vấn', 3, N'Có kỹ năng giao tiếp tốt');
go
INSERT INTO HOADON (MaTTDT, TongTien, CachThuc, TrangThai, NgayLap) VALUES
(1, 5000000, N'Toàn bộ', N'Chưa thanh toán hoàn tất', '2024-06-01'),
(2, 7000000, N'Nhiều đợt', N'Đã thanh toán hoàn tất', '2024-06-21');
GO
select * from HOADON;
go
-- Insert   HS_CT_BC
INSERT INTO HS_CT_BC (MaUngVien, TenCTBC) VALUES
( '082203564448', N'Chứng chỉ CCNA  Cisco Certified Network Associate'),
( '082203656888', N'Chứng chỉ CCIE  Cisco Certified Internetwork Expert'),
( '082203656888', N'Chứng chỉ CISA  Certified Information Systems Auditor'),
( '082203564448', N'Chứng chỉ CISSP  Certified Information Systems Security Professional');
GO
select * from HS_CT_BC;
go
-- Insert   PHIEUDANGKYUNGTUYEN
INSERT INTO PHIEUDANGKYUNGTUYEN (MaTTDT, MaUV, TrangThai) VALUES
(1, '082203564448', N'Đạt'),
(2, '082203564448', N'Hợp lệ'),
(2, '082203656888', N'Hợp lệ'),
(3, '082203656888', N'Chưa xét duyệt')

GO

-- Insert   CT_HOADON
INSERT INTO CT_HOADON VALUES
(2,1, 2000000,'2024-06-21'),
(2,2, 3000000,'2024-06-23'),
(2,3, 2000000,'2024-06-25');
GO
SELECT * FROM CT_HOADON;
go
-- Insert   CT_PDKUT
INSERT INTO CT_PDKUT (MaTTDT, MaUV, MaCTBC) VALUES
(1, '082203564448', 1),
(2, '082203564448', 3),
(2, '082203656888', 1),
(3, '082203656888', 3)
GO
SELECT * FROM CT_PDKUT;
go
