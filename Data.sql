
create database QuanLyThuVien
go
use QuanLyThuVien
go

create table Account_Type
(
	LoaiTk int not null primary key,
	TenTK nvarchar(100) not null
)
go
create table TaiKhoan
(
	TenDangNhap nvarchar(100) not null,
	MatKhau varchar(300) not null,
	primary key (TenDangNhap),
	TenHienThi nvarchar(100) not null,
	LoaiTK int default 0, --0:QuanLy 1:Admin
	unique(TenDangNhap),
	foreign key (LoaiTK) references Account_Type(LoaiTk)
)
go


insert into Account_Type
(LoaiTk,TenTK)
values (0,N'Quản lý'),
		(1, 'Admin')
go


create table QuanLy
(
	MaQuanLy int identity(1,1) not null primary key,
	TenDangNhap nvarchar(100) not null,
	foreign key (TenDangNhap) references TaiKhoan(TenDangNhap),
)
go


insert into QuanLy
(TenDangNhap)
values
('admin'),
('firststaff'),
('secondstaff'),
('thirdstaff'),
('fouthstaff')
go

create table NhaCungCap
(
	ID int identity(1,1) primary key,
	Ten nvarchar(100),
	SoDienThoai varchar(10),
	DiaChi nvarchar(200),
)

create table TheLoai
(
	MaLoai int identity(1,1) not null primary key,
	TenLoai nvarchar(100) not null,
)
go

create table Sach
(
	MaSach int identity(1,1) not null primary key,
	TenSach nvarchar(100) not null,
	TenTacGia nvarchar(100),
	MaLoai int not null,
	SoLuong int not null default 0,
	foreign key (MaLoai) references TheLoai(MaLoai),
)
go

create table DocGia
(
	MaDocGia int identity(1,1) not null primary key,
	SoDienThoai nvarchar(100) not null default '0',
	TenDocGia nvarchar(100) not null,
	DiaChi nvarchar(200) not null,
	unique(SoDienThoai)
)
go

insert into DocGia
(TenDocGia, SoDienThoai, DiaChi)
values
(N'Độc giả 1', '0123456789', N'Hà Nội'),
(N'Độc giả 2', '0472375634', N'Hải Phòng'),
(N'Độc giả 3', '0341434534', N'Thanh Hóa'),
(N'Độc giả 4', '0166752341', N'Hải Dương'),
(N'Độc giả 5', '0234134324', N'Đà Nẵng')
go
select * from DocGia



create table TheMuon
(
	MaThe int identity(1,1) not null primary key,
	MaDocGia int not null

	foreign key (MaDocGia) references DocGia(MaDocGia)
)
go

create table SachMuon
(
	MaThe int not null,
	MaSach int not null,
	NgayMuon date default getdate(),
	NgayTra date,
	MaQuanLy int not null
	
	foreign key (MaThe) references TheMuon(MaThe),
	foreign key (MaSach) references Sach(MaSach),
	foreign key (MaQuanLy) references QuanLy(MaQuanLy)
)
go


insert into TaiKhoan
(
	TenDangNhap,
	MatKhau,
	TenHienThi,
	LoaiTK
)
values (N'firststaff','123456',N'First Staff',0),
		(N'admin',
		'admin',
		N'Admin',
		1),
		(N'secondstaff',
		'123456',
		N'Second Staff',
		0),
		(N'thirdstaff',
		'123456',
		N'Third Staff',
		0),
		(N'fouthstaff',
		'123456',
		N'Fouth Staff',
		0)

go

insert into TheLoai
(TenLoai)
values (N'Thể loại 1'),
		(N'Thể loại 2'),
		(N'Thể loại 3'),
		(N'Thể loại 4'),
		(N'Thể loại 5')
go
select * from TheLoai

insert into Sach
(
	TenSach,
	TenTacGia,
	MaLoai,
	SoLuong
)
values (N'Sách 1',
		N'Tác Giả 1',
		1,
		2),
		(N'Sách 2',
		N'Tác Giả 2',
		2,
		5),
		(N'Sách 3',
		N'Tác Giả 3',
		3,
		3),
		(N'Sách 4',
		N'Tác Giả 4',
		4,
		8),
		(N'Sách 5',
		N'Tác Giả 5',
		5,
		6)
go	
select * from Sach	


create proc USP_Login
@username nvarchar(100), @password nvarchar(100)
as
begin
	select * from TaiKhoan where TenDangNhap = @username and MatKhau = @password
end
go


create proc Add_Account
@username nvarchar(100), @displayname nvarchar(100) , @password nvarchar(100), @type int
as
begin
	insert into TaiKhoan (TenDangNhap, MatKhau, TenHienThi, LoaiTK)
	values (@username, @password, @displayname, @type)

	insert into QuanLy (TenDangNhap)
	values (@username)
end
go



create proc Remove_Account
@username nvarchar(100), @displayname nvarchar(100)
as
begin
	
	declare @maquanly int
	select @maquanly = MaQuanLy from Quanly where TenDangNhap = @username

	declare @ktra int = 0
	select @ktra = count (*) from SachMuon where MaQuanLy = @maquanly

	if(@ktra=0)
		begin
			delete from QuanLy where TenDangNhap = @username
			delete from TaiKhoan where TenDangNhap = @username and TenHienThi = @displayname
		end
end
go 


create proc Search_Book
@search_info nvarchar(100)
as
begin
	if((select Try_Convert(int, @search_info)) is not null)
		begin
			select Sach.MaSach as 'Mã sách',
					Sach.TenSach as 'Tên sách',
					Sach.TenTacGia as 'Tên tác giả',
					TheLoai.TenLoai as 'Thể loại',
					Sach.MaLoai as 'Mã loại',
					Sach.SoLuong as 'Số lượng' 
			from Sach
			join TheLoai on Sach.MaLoai = TheLoai.MaLoai
			where (Sach.MaSach = @search_info)
		end
	else
		begin
			select Sach.MaSach as 'Mã sách',
					Sach.TenSach as 'Tên sách',
					Sach.TenTacGia as 'Tên tác giả',
					TheLoai.TenLoai as 'Thể loại',
					Sach.MaLoai as 'Mã loại',
					Sach.SoLuong as 'Số lượng' 
			from Sach
			join TheLoai on Sach.MaLoai = TheLoai.MaLoai
			where (Sach.TenSach = @search_info or Sach.TenTacGia = @search_info or TheLoai.TenLoai = @search_info)
		end
end
go


create proc USP_UpdateAccount
@username nvarchar(100), @displayname nvarchar(100), @password nvarchar(100), @newpassword nvarchar(100)
as
begin
	declare @isRightPass int = 0

	select @isRightPass = count (*) from TaiKhoan where TenDangNhap = @username and MatKhau = @password

	if (@isRightPass = 1)
	begin
		if(@newpassword = null or @newpassword ='')
			begin
				update TaiKhoan set TenHienThi = @displayname where TenDangNhap = @username
			end
		else
		begin
			update TaiKhoan set TenHienThi = @displayname, MatKhau = @newpassword where TenDangNhap = @username
		end
	end
end
go

create proc Search_Account
@displayname nvarchar(100)
as
begin
	select TenHienThi as 'Tên hiển thị', TenDangNhap as 'Tên đăng nhập', MatKhau as 'Mật khẩu', Account_Type.TenTK as N'Loại tài khoản' from TaiKhoan, Account_Type
	where TenHienThi = @displayname and TaiKhoan.LoaiTK = Account_Type.LoaiTk

end
go


create proc Delete_BorrowBook
@bookid int, @readerid int, @ngaymuon date, @ngaytra date, @tenquanly nvarchar(100)
as
begin
	declare @id int
	select @id = MaThe from TheMuon where MaDocGia = @readerid
	
	declare @maquanly int, @tendangnhap nvarchar(100)
	select @tendangnhap = TenDangNhap from TaiKhoan where TenHienThi = @tenquanly
	select @maquanly = MaQuanLy from QuanLy where TenDangNhap = @tendangnhap

	delete from SachMuon where MaSach = @bookid and MaThe = @id and NgayMuon = @ngaymuon and NgayTra = @ngaytra and MaQuanLy = @maquanly
	update Sach set SoLuong = SoLuong + 1 where MaSach = @bookid

end
go
drop proc Delete_BorrowBook

select * from Sach
select * from SachMuon

insert into TheMuon
(MaDocGia)
values
(1),
(2),
(3),
(4),
(5)
go

insert into SachMuon
(MaThe, MaSach, MaQuanLy, NgayMuon, NgayTra)
values
(1,1,1,getdate(),dateadd(year,1,getdate())),
(2,2,2,getdate(),dateadd(year,1,getdate())),
(3,3,3,getdate(),dateadd(year,1,getdate())),
(4,4,4,getdate(),dateadd(year,1,getdate())),
(5,5,5,getdate(),dateadd(year,1,getdate()))
go




create proc Borrow_Book
@readerid int, @bookid int, @tendangnhap nvarchar(100)
as
begin
	declare @soluong int = 0
	select @soluong = count (*) from Sach where MaSach = @bookid and  Soluong > 0
	if(@soluong>0)
	begin
		declare @id int, @maquanly int

		select @id = MaThe from TheMuon where MaDocGia = @readerid

		select @maquanly = MaQuanLy from QuanLy where TenDangNhap = @tendangnhap 

		insert into SachMuon(MaThe,MaSach,NgayMuon,NgayTra,MaQuanLy) 
		values (@id, @bookid, getdate(),dateadd(year,1,getdate()),@maquanly)

		update Sach set SoLuong = SoLuong - 1 where MaSach = @bookid
	end
end
go

create proc Add_Book
@tensach nvarchar(100), @tentacgia nvarchar(100), @tenloai nvarchar(100), @soluong int
as
begin
	declare @maloai int
	select @maloai = MaLoai from TheLoai where TenLoai = @tenloai
	insert into Sach (TenSach, TenTacGia, MaLoai, SoLuong)
	values (@tensach, @tentacgia, @maloai, @soluong)
end
go

create proc Update_Book
@masach int, @tensach nvarchar(100), @tentacgia nvarchar(100), @tenloai nvarchar(100), @soluong int
as
begin
	declare @maloai int
	select @maloai = MaLoai from TheLoai where TenLoai = @tenloai
	update Sach set TenSach = @tensach, TenTacGia = @tentacgia, MaLoai = @maloai, SoLuong = @soluong where MaSach = @masach
end
go

select * from TaiKhoan
select * from QuanLy

select * from TheLoai where TenLoai = N'Thể loại 1'

