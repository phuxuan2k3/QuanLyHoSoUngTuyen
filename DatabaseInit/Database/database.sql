DECLARE @DatabaseName nvarchar(50)
SET @DatabaseName = N'QL_DangTuyen'

DECLARE @SQL varchar(max)

SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
FROM MASTER..SysProcesses
WHERE DBId = DB_ID(@DatabaseName) AND SPId <> @@SPId

--SELECT @SQL 
EXEC(@SQL)

USE master
IF EXISTS(select * from sys.databases where name='QL_DangTuyen')
DROP DATABASE QL_DangTuyen
GO

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     6/27/2024 2:38:02 PM                         */
/*==============================================================*/
/*
check trang thai
ID tu dong tang

*/

create database QL_DangTuyen;
go
use QL_DangTuyen;
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_CLUD') and o.name = 'FK_CT_CLUD_RELATIONS_CHIENLUO')
alter table CT_CLUD
   drop constraint FK_CT_CLUD_RELATIONS_CHIENLUO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_CLUD') and o.name = 'FK_CT_CLUD_RELATIONS_DOANHNGH')
alter table CT_CLUD
   drop constraint FK_CT_CLUD_RELATIONS_DOANHNGH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_HOADON') and o.name = 'FK_CT_HOADO_RELATIONS_HOADON')
alter table CT_HOADON
   drop constraint FK_CT_HOADO_RELATIONS_HOADON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_PDKUT') and o.name = 'FK_CT_PDKUT_RELATIONS_PHIEUDAN')
alter table CT_PDKUT
   drop constraint FK_CT_PDKUT_RELATIONS_PHIEUDAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_PDKUT') and o.name = 'FK_CT_PDKUT_RELATIONS_HS_CT_BC')
alter table CT_PDKUT
   drop constraint FK_CT_PDKUT_RELATIONS_HS_CT_BC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOANHNGHIEP') and o.name = 'FK_DOANHNGH_RELATIONS_TAIKHOAN')
alter table DOANHNGHIEP
   drop constraint FK_DOANHNGH_RELATIONS_TAIKHOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADON') and o.name = 'FK_HOADON_RELATIONS_THONGTIN')
alter table HOADON
   drop constraint FK_HOADON_RELATIONS_THONGTIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HS_CT_BC') and o.name = 'FK_HS_CT_BC_RELATIONS_UNGVIEN')
alter table HS_CT_BC
   drop constraint FK_HS_CT_BC_RELATIONS_UNGVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHANVIEN') and o.name = 'FK_NHANVIEN_RELATIONS_TAIKHOAN')
alter table NHANVIEN
   drop constraint FK_NHANVIEN_RELATIONS_TAIKHOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUDANGKYUNGTUYEN') and o.name = 'FK_PHIEUDAN_RELATIONS_THONGTIN')
alter table PHIEUDANGKYUNGTUYEN
   drop constraint FK_PHIEUDAN_RELATIONS_THONGTIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('THONGTINDANGTUYEN') and o.name = 'FK_THONGTIN_RELATIONS_HINHTHUC')
alter table THONGTINDANGTUYEN
   drop constraint FK_THONGTIN_RELATIONS_HINHTHUC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UNGVIEN') and o.name = 'FK_UNGVIEN_RELATIONS_TAIKHOAN')
alter table UNGVIEN
   drop constraint FK_UNGVIEN_RELATIONS_TAIKHOAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHIENLUOCUUDAI')
            and   type = 'U')
   drop table CHIENLUOCUUDAI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_CLUD')
            and   name  = 'RELATIONSHIP_15_FK'
            and   indid > 0
            and   indid < 255)
   drop index CT_CLUD.RELATIONSHIP_15_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_CLUD')
            and   name  = 'RELATIONSHIP_14_FK'
            and   indid > 0
            and   indid < 255)
   drop index CT_CLUD.RELATIONSHIP_14_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CT_CLUD')
            and   type = 'U')
   drop table CT_CLUD
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_HOADON')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index CT_HOADON.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CT_HOADON')
            and   type = 'U')
   drop table CT_HOADON
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_PDKUT')
            and   name  = 'RELATIONSHIP_8_FK'
            and   indid > 0
            and   indid < 255)
   drop index CT_PDKUT.RELATIONSHIP_8_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_PDKUT')
            and   name  = 'RELATIONSHIP_7_FK'
            and   indid > 0
            and   indid < 255)
   drop index CT_PDKUT.RELATIONSHIP_7_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CT_PDKUT')
            and   type = 'U')
   drop table CT_PDKUT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DOANHNGHIEP')
            and   name  = 'RELATIONSHIP_12_FK'
            and   indid > 0
            and   indid < 255)
   drop index DOANHNGHIEP.RELATIONSHIP_12_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOANHNGHIEP')
            and   type = 'U')
   drop table DOANHNGHIEP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HINHTHUCDANGTUYEN')
            and   type = 'U')
   drop table HINHTHUCDANGTUYEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOADON')
            and   type = 'U')
   drop table HOADON
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HS_CT_BC')
            and   name  = 'RELATIONSHIP_9_FK'
            and   indid > 0
            and   indid < 255)
   drop index HS_CT_BC.RELATIONSHIP_9_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HS_CT_BC')
            and   type = 'U')
   drop table HS_CT_BC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHANVIEN')
            and   name  = 'RELATIONSHIP_11_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHANVIEN.RELATIONSHIP_11_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUDANGKYUNGTUYEN')
            and   name  = 'RELATIONSHIP_6_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUDANGKYUNGTUYEN.RELATIONSHIP_6_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEUDANGKYUNGTUYEN')
            and   type = 'U')
   drop table PHIEUDANGKYUNGTUYEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAIKHOAN')
            and   type = 'U')
   drop table TAIKHOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('THONGTINDANGTUYEN')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index THONGTINDANGTUYEN.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THONGTINDANGTUYEN')
            and   type = 'U')
   drop table THONGTINDANGTUYEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('UNGVIEN')
            and   name  = 'RELATIONSHIP_10_FK'
            and   indid > 0
            and   indid < 255)
   drop index UNGVIEN.RELATIONSHIP_10_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UNGVIEN')
            and   type = 'U')
   drop table UNGVIEN
go

/*==============================================================*/
/* Table: CHIENLUOCUUDAI                                        */
/*==============================================================*/
create table CHIENLUOCUUDAI (
   MACHIENLUOC          int                  not null IDENTITY(1,1),
   TENCHIENLUOC         varchar(50)          null,
   MOTA                 varchar(50)          null,
   constraint PK_CHIENLUOCUUDAI primary key (MACHIENLUOC)
)
go

/*==============================================================*/
/* Table: CT_CLUD                                               */
/*==============================================================*/
create table CT_CLUD (
   MADN                 int                  not null,
   MACHIENLUOC          int                  not null,
   constraint PK_CT_CLUD primary key (MADN, MACHIENLUOC)
)
go



/*==============================================================*/
/* Table: CT_HOADON                                             */
/*==============================================================*/
create table CT_HOADON (
   MATTDT               int                  not null,
   LANTT                int                  not null,
   SOTIENCANTT          float                null,
   NGAYTT               datetime             null,
   constraint PK_CT_HOADON primary key (MATTDT, LANTT)
)
go



/*==============================================================*/
/* Table: CT_PDKUT                                              */
/*==============================================================*/
create table CT_PDKUT (
   MATTDT               int                  not null,
   MAUV                 int                  not null,
   MACTBC               int                  not null,
   constraint PK_CT_PDKUT primary key (MATTDT, MAUV, MACTBC)
)
go


/*==============================================================*/
/* Table: DOANHNGHIEP                                           */
/*==============================================================*/
create table DOANHNGHIEP (
   MADN                 int                  not null IDENTITY(1,1),
   TENTK                varchar(50)          not null,
   TENDN                varchar(50)          null,
   MASOTHUE             varchar(10)          null,
   NGUOIDAIDIEN         varchar(50)          null,
   DIACHI               varchar(50)          null,
   EMAIL                varchar(50)          null,
   TRANGTHAI            varchar(20)          null,
   NGAYDK               datetime             null,
   constraint PK_DOANHNGHIEP primary key (MADN)
)
go



/*==============================================================*/
/* Table: HINHTHUCDANGTUYEN                                     */
/*==============================================================*/
create table HINHTHUCDANGTUYEN (
   MAHTDT               int                  not null IDENTITY(1,1),
   TENHINHTHUC          varchar(30)          null,
   MOTA                 varchar(100)         null,
   constraint PK_HINHTHUCDANGTUYEN primary key (MAHTDT)
)
go

/*==============================================================*/
/* Table: HOADON                                                */
/*==============================================================*/
create table HOADON (
   MATTDT               int                  not null,
   TONGTIEN             float                null,
   CACHTHUC             char(10)             null,
   TRANGTHAI            varchar(30)          null,
   NGAYLAP              datetime             null,
   constraint PK_HOADON primary key (MATTDT),
   CONSTRAINT CK_TRANGTHAI CHECK (TRANGTHAI IN (N'Chưa thanh toán hoàn tất', N'Đã thanh toán hoàn tất', N'Chưa thanh toán')),
   CONSTRAINT CK_CACHTHUC CHECK (CACHTHUC IN (N'Toàn bộ', N'Nhiều đợt'))


)
go

/*==============================================================*/
/* Table: HS_CT_BC                                              */
/*==============================================================*/
create table HS_CT_BC (
   MACTBC               int                  not null,
   MAUV                 int                  not null,
   TENCTBC              varchar(50)          null,
   constraint PK_HS_CT_BC primary key (MACTBC, MAUV)
)
go



/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV                 int                  not null IDENTITY(1,1),
   TENTK                varchar(50)          not null,
   TENNV                varchar(50)          null,
   LOAINV               varchar(20)          null,
   constraint PK_NHANVIEN primary key (MANV),
   CONSTRAINT CK_LOAINV CHECK (LOAINV IN (N'Tiếp nhận', N'Nghiệp vụ', N'Thanh toán',N'Lãnh đạo'))

)
go



/*==============================================================*/
/* Table: PHIEUDANGKYUNGTUYEN                                   */
/*==============================================================*/
create table PHIEUDANGKYUNGTUYEN (
   MATTDT               int                  not null,
   MAUV                 int                  not null,
   TRANGTHAI            varchar(20)          null,
   constraint PK_PHIEUDANGKYUNGTUYEN primary key (MATTDT, MAUV),
   CONSTRAINT CK_TRANGTHAI_PDK CHECK (TRANGTHAI IN (N'Chưa xét duyệt', N'Không hợp lệ', N'Hợp lệ', N'Đã xử lý',N'Đạt',N'Không đạt'))
)
go



/*==============================================================*/
/* Table: TAIKHOAN                                              */
/*==============================================================*/
create table TAIKHOAN (
   TENTK                varchar(50)          not null,
   MATKHAU              varchar(50)          null,
   VAITRO               varchar(20)          null,
   constraint PK_TAIKHOAN primary key (TENTK),
   CONSTRAINT CK_VAITRO CHECK (VAITRO IN (N'Doanh nghiệp', N'Nhân viên', N'Ứng viên'))
)
go

/*==============================================================*/
/* Table: THONGTINDANGTUYEN                                     */
/*==============================================================*/
create table THONGTINDANGTUYEN (
   MATTDT               int                  not null IDENTITY(1,1),
   MADN                 int                  null,
   SONGAYDT             int                  null,
   MAHTDT               int                  null,
   THOIGIANXETTUYEN     int                  null,
   TRANGTHAI            varchar(20)          null,
   TINHTRANG            varchar(20)          null,
   TENVITRI             varchar(50)          null,
   SOLUONG              int                  null,
   YEUCAU               varchar(100)         null,
   constraint PK_THONGTINDANGTUYEN primary key (MATTDT),
   CONSTRAINT CK_TRANGTHAI_TTDT CHECK (TRANGTHAI IN (N'Chưa đăng tuyển', N'Đã đăng tuyển', N'Cần hiệu chỉnh')),
   CONSTRAINT CK_TINHTRANG_TTDT CHECK (TINHTRANG IN (N'Chưa xét duyệt', N'Không hợp lệ', N'Hợp lệ'))

)
go



/*==============================================================*/
/* Table: UNGVIEN                                               */
/*==============================================================*/
create table UNGVIEN (
   MAUV                 int                  not null IDENTITY(1,1),
   TENUV                varchar(50)          null,
   NGAYSINH             datetime             null,
   DIACHI               varchar(50)          null,
   EMAIL                varchar(50)          null,
   SODIENTHOAI          char(11)             null,
   TENTK                varchar(50)                  not null,
   constraint PK_UNGVIEN primary key (MAUV)
)
go




alter table CT_CLUD
   add constraint FK_CT_CLUD_RELATIONS_CHIENLUO foreign key (MACHIENLUOC)
      references CHIENLUOCUUDAI (MACHIENLUOC)
go

alter table CT_CLUD
   add constraint FK_CT_CLUD_RELATIONS_DOANHNGH foreign key (MADN)
      references DOANHNGHIEP (MADN)
go

alter table CT_HOADON
   add constraint FK_CT_HOADO_RELATIONS_HOADON foreign key (MATTDT)
      references HOADON (MATTDT)
go

alter table CT_PDKUT
   add constraint FK_CT_PDKUT_RELATIONS_PHIEUDAN foreign key (MATTDT, MAUV)
      references PHIEUDANGKYUNGTUYEN (MATTDT, MAUV)
go

alter table CT_PDKUT
   add constraint FK_CT_PDKUT_RELATIONS_HS_CT_BC foreign key (MACTBC, MAUV)
      references HS_CT_BC (MACTBC, MAUV)
go

alter table DOANHNGHIEP
   add constraint FK_DOANHNGH_RELATIONS_TAIKHOAN foreign key (TENTK)
      references TAIKHOAN (TENTK)
go

alter table HOADON
   add constraint FK_HOADON_RELATIONS_THONGTIN foreign key (MATTDT)
      references THONGTINDANGTUYEN (MATTDT)
go

alter table HS_CT_BC
   add constraint FK_HS_CT_BC_RELATIONS_UNGVIEN foreign key (MAUV)
      references UNGVIEN (MAUV)
go

alter table NHANVIEN
   add constraint FK_NHANVIEN_RELATIONS_TAIKHOAN foreign key (TENTK)
      references TAIKHOAN (TENTK)
go

alter table PHIEUDANGKYUNGTUYEN
   add constraint FK_PHIEUDAN_RELATIONS_THONGTIN foreign key (MATTDT)
      references THONGTINDANGTUYEN (MATTDT)
go

alter table THONGTINDANGTUYEN
   add constraint FK_THONGTIN_RELATIONS_HINHTHUC foreign key (MAHTDT)
      references HINHTHUCDANGTUYEN (MAHTDT)
go

alter table UNGVIEN
   add constraint FK_UNGVIEN_RELATIONS_TAIKHOAN foreign key (TENTK)
      references TAIKHOAN (TENTK)
go

