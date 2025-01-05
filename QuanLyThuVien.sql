create database QuanLyThuVien_new
go
use QuanLyThuVien_new
go

/*
create table Account_Type
(
	LoaiTk int not null primary key,
	TenTK nvarchar(100) not null
)
go
*/
create table NhanVien
(
	ID int identity(1,1) primary key,
	HoTen nvarchar(100) not null,
	SoDienThoai varchar(11),
	TrangThai nvarchar(100) check (TrangThai in (N'Đang làm', N'Nghỉ việc')) default N'Đang làm'
)

create table TaiKhoan
(
	ID int identity(1,1) primary key,
	TenDangNhap nvarchar(100) not null,
	MatKhau varchar(300) not null,
	LoaiTK varchar(20) default 'staff' check (LoaiTK in ('admin', 'staff')), --0:QuanLy 1:Admin
	IDNhanVien int not null,
	unique(TenDangNhap),
	foreign key (IDQuanLy) references NhanVien(ID)
)
go



create table NhaCungCap
(
	ID int identity(1,1) primary key,
	Ten nvarchar(100) not null,
	SoDienThoai varchar(10),
	DiaChi nvarchar(200)
)

create table TheLoai
(
	ID int identity(1,1) primary key,
	Ten nvarchar(100) not null,
)

create table Sach
(
	ID int identity(1,1) primary key,
	TenSach nvarchar(100) not null,
	TenTacGia nvarchar(100),
	IDTheLoai int not null,
	IDNhaCungCap int not null,
	SoLuong int default 0 check (Soluong >= 0),
	TrangThai nvarchar(50) check (TrangThai in (N'Còn', N'Hết')),
	foreign key (IDTheLoai) references TheLoai(ID),
	foreign key (IDNhaCungCap) references NhaCungCap(ID)
)

create table DocGia
(
	ID int identity(1,1) primary key,
	Ten nvarchar(100) not null,
	SoDienThoai varchar(11) not null,
	DiaChi nvarchar(200),
	unique(SoDienThoai)
)

create table TheMuon
(
	ID int identity(1,1) primary key,
	IDDocGia int not null,
	foreign key (IDDocGia) references DocGia(ID)
)

create table SachMuon
(
	ID int identity(1,1) primary key,
	IDTheMuon int not null,
	IDSach int not null,
	NgayMuon date default getdate(),
	NgayTra date,
	IDNhanVien int not null,
	foreign key (IDTheMuon) references TheMuon(ID),
	foreign key (IDSach) references Sach(ID),
	foreign key (IDNhanVien) references NhanVien(ID)
)

create table BaoCao
(
	ID int identity(1,1) primary key,
	Thang int check (Thang between 1 and 12),
	Nam int,
	TongSachMuon int default 0,
	TongSachTra int default 0,
	DoanhThu int default 0,
	GhiChu nvarchar(500)
)

