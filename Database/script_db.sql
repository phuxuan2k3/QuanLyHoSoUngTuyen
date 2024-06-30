USE QL_HSUT;
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
    MaTaiKhoan varchar(50),
    foreign key (MaNhanVien) references TAIKHOAN(TenTaiKhoan)
);
go

-- Table UNGVIEN
create table UNGVIEN (
    MaUngVien varchar(50) not null primary key,
    TenUngVien nvarchar(100),
    DiaChi nvarchar(255),
	Email varchar(255),
    MaTaiKhoan varchar(50),
    foreign key (MaUngVien) references TAIKHOAN(TenTaiKhoan)
);
go


-- Table DOANHNGHIEP
create table DOANHNGHIEP (
    MaDoanhNghiep varchar(50) not null primary key,
    TenDoanhNghiep nvarchar(100),
    MASOTHUE             varchar(10)          null,
    NGUOIDAIDIEN         nvarchar(50)          null,
    DIACHI               nvarchar(50)          null,
    EMAIL                varchar(50)          null,
    TRANGTHAI            nvarchar(20)          null,
    NGAYDK               datetime             null,
	foreign key (MaDoanhNghiep) references TAIKHOAN(TenTaiKhoan)
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
    MaDoanhNghiep varchar(50) not null,
    primary key (MaChienLuoc, MaDoanhNghiep),
    foreign key (MaChienLuoc) references CHIENLUOCUUDAI(MaChienLuoc),
    foreign key (MaDoanhNghiep) references DOANHNGHIEP(MaDoanhNghiep)
);
go


-- Table HINHTHUCDANGTUYEN
create table HINHTHUCDANGTUYEN (
    MaHinhThuc varchar(50) not null primary key,
    TenHinhThuc nvarchar(100)
);
go

-- table THONGTINDANGTUYEN
create table THONGTINDANGTUYEN (
   MATTDT               int                  not null IDENTITY(1,1),
   MADN                 varchar(50)          null,
   SONGAYDT             int                  null,
   MAHTDT               varchar(50)          null,
   THOIGIANXETTUYEN     int                  null,
   TRANGTHAI            nvarchar(20)          null,
   TINHTRANG            nvarchar(20)          null,
   TENVITRI             nvarchar(50)          null,
   SOLUONG              int                  null,
   GIA              float                  null,
   YEUCAU               nvarchar(100)         null,
   constraint PK_THONGTINDANGTUYEN primary key (MATTDT),
   CONSTRAINT CK_TRANGTHAI_TTDT CHECK (TRANGTHAI IN (N'Chưa đăng tuyển', N'Đã đăng tuyển', N'Cần hiệu chỉnh')),
   CONSTRAINT CK_TINHTRANG_TTDT CHECK (TINHTRANG IN (N'Chưa xét duyệt', N'Không hợp lệ', N'Hợp lệ')),
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
    MACTBC               int                  not null,
    MaUngVien varchar(50) not null,
	TENCTBC              nvarchar(255)          null,
	constraint PK_HS_CT_BC primary key (MACTBC, MaUngVien),
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
   foreign key (MACTBC,MAUV) references HS_CT_BC(MACTBC,MaUngVien)
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
('082203666558', '123', N'Ứng viên'),
('082203656888', '111', N'Ứng viên'),
('082203564879', '555', N'Ứng viên'),
('123568', 'DN1', N'Doanh nghiệp'),
('23568', 'DN2', N'Doanh nghiệp'),
('NV11', 'NV11', N'Nhân viên'),
('NV12', 'NV12', N'Nhân viên'),
('082203564448', '222', N'Ứng viên'),
('563245', 'DN3', N'Doanh nghiệp'),
('223587', 'DN4', N'Doanh nghiệp');
GO

SELECT * FROM TAIKHOAN;
GO
-- Insert   NHANVIEN
INSERT INTO NHANVIEN (MaNhanVien, TenNhanVien, DiaChi, MaTaiKhoan) VALUES
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
INSERT INTO UNGVIEN (MaUngVien, TenUngVien, DiaChi,Email, MaTaiKhoan) VALUES
('082203564448', N'Hoàng Văn Thụ', N'Xã Hương Trạch-Huyện Hương Khê-Tỉnh Hà Tĩnh','HVThuCV@gmailcom', '082203564448'),
('082203564879', N'Đỗ Kim Hoàng', N'Xã Tân Trung-Huyện Phú Tân-Tỉnh An Giang','DKimHoangCV@gmailcom', '082203564879'),
('082203656888', N'Vũ Văn Khánh', N'Xã Hòa Sơn-Huyện Krông Bông-Tỉnh Đắk Lắk', 'VuKhanhCV@gmailcom','082203656888'),
('082203666558', N'Ngô Thành Khánh Sơn', N'Xã Giao Xuân-Huyện Giao Thủy-Tỉnh Nam Định','NgKhnhSonCV@gmailcom', '082203666558');
GO
select * from ungvien;
go
-- Insert   DOANHNGHIEP
INSERT INTO DOANHNGHIEP (MaDoanhNghiep, TenDoanhNghiep, MaSoThue, NguoiDaiDien, DiaChi, Email, TrangThai, NgayDK) VALUES
('123568', N'Công ty Thành Công', '1234567890', N'Nguyễn Văn Ích', N'Phường Trần Phú-Thành phố Hà Giang-Tỉnh Hà Giang', 'abc@example.com', N'Hoạt động', '2023-01-01'),
('223587', N'Công ty Thái Hà', '0987654321', N'Trần Thị Hà', N'Thị trấn Bình Minh-Huyện Kim Sơn-Tỉnh Ninh Bình', 'xyz@example.com', N'Hoạt động', '2023-02-01'),
('23568', N'Công ty Phát Phú', '1122334455', N'Hoàng Văn Khánh', N'Phường Liễu Giai-Quận Ba Đình-Thành phố Hà Nội', 'def@example.com', N'Hoạt động', '2023-03-01'),
('563245', N'Công ty Hoàng Văn', '2233445566', N'Vũ Thị Lệ', N'Xã Tân Phong-Huyện Kiến Thuỵ-Thành phố Hải Phòng', 'ghi@example.com', N'Hoạt động', '2023-04-01');
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
(1, '123568'),
(2, '123568'),
(3, '223587'),
(4, '563245'),
(5, '23568');
GO
select * from CT_CLUD;
go
-- Insert   HINHTHUCDANGTUYEN
INSERT INTO HINHTHUCDANGTUYEN (MaHinhThuc, TenHinhThuc) VALUES
('HT001', N'Đăng bài quảng cáo'),
('HT002', N'Phát hành báo quảng cáo');
GO
select * from HINHTHUCDANGTUYEN;
go
-- Insert   THONGTINDANGTUYEN
INSERT INTO THONGTINDANGTUYEN (MaDN, SoNgayDT, MaHTDT, ThoiGianXetTuyen, TrangThai, TinhTrang, TenViTri, SoLuong, gia, YeuCau) VALUES
('123568', 30, 'HT001', 15, N'Chưa đăng tuyển', N'Chưa xét duyệt', N'Dev,BA,TEST', 3,300000, N'Biết lập trình Java'),
('223587', 45, 'HT001', 20, N'Đã đăng tuyển', N'Hợp lệ', N'Kế toán', 2, 250000,N'Tốt nghiệp đại học chuyên ngành kế toán'),
('23568', 60, 'HT001', 25, N'Chưa đăng tuyển', N'Chưa xét duyệt', N'Thực tập sinh', 5,150000, N'Sinh viên năm cuối'),
('23568', 30, 'HT001', 10, N'Chưa đăng tuyển', N'Chưa xét duyệt', N'Nhà thiết kế đồ họa', 1,123000, N'Sử dụng thành thạo Photoshop'),
('23568', 40, 'HT001', 15, N'Đã đăng tuyển', N'Hợp lệ', N'Quản lý dự án', 2,450000, N'Kinh nghiệm 3 năm trong quản lý dự án'),
('123568', 25, 'HT001', 18, N'Đã đăng tuyển', N'Hợp lệ', N'Chuyên viên tư vấn', 3,440000, N'Có kỹ năng giao tiếp tốt');
go
INSERT INTO HOADON (MaTTDT, TongTien, CachThuc, TrangThai, NgayLap) VALUES
(1, 5000000, N'Toàn bộ', N'Chưa thanh toán hoàn tất', '2024-06-01'),
(2, 7000000, N'Nhiều đợt', N'Đã thanh toán hoàn tất', '2024-06-21');
GO
select * from HOADON;
go
-- Insert   HS_CT_BC
INSERT INTO HS_CT_BC (MaCTBC, MaUngVien, TenCTBC) VALUES
(1, '082203564448', N'Chứng chỉ CCNA  Cisco Certified Network Associate'),
(2, '082203564879', N'Chứng chỉ CCIE  Cisco Certified Internetwork Expert'),
(3, '082203564448', N'Chứng chỉ CISA  Certified Information Systems Auditor'),
(4, '082203666558', N'Chứng chỉ CISSP  Certified Information Systems Security Professional');
GO
select * from HS_CT_BC;
go
-- Insert   PHIEUDANGKYUNGTUYEN
INSERT INTO PHIEUDANGKYUNGTUYEN (MaTTDT, MaUV, TrangThai) VALUES
(1, '082203564448', N'Đạt'),
(1, '082203656888', N'Đạt'),
(2, '082203564448', N'Hợp lệ'),
(2, '082203564879', N'Hợp lệ'),
(2, '082203656888', N'Hợp lệ'),
(3, '082203564879', N'Chưa xét duyệt'),
(1, '082203666558', N'Đạt');
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
(1, '082203564448', 3),
(2, '082203564448', 1),
(2, '082203564448', 3),
(2, '082203564879', 2);
GO
SELECT * FROM CT_PDKUT;
go
