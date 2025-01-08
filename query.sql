use QuanLyThuVien_new

alter proc USP_Login
@username nvarchar(100), @password nvarchar(100)
as
begin
	select TenDangNhap, MatKhau, LoaiTK, HoTen from TaiKhoan, NhanVien where TenDangNhap = @username and MatKhau = @password and TaiKhoan.IDNhanVien = NhanVien.ID
end
go

select TenDangNhap, MatKhau, LoaiTK, HoTen from TaiKhoan, NhanVien where TenDangNhap = 'quynhnt' and MatKhau = '123456' and TaiKhoan.IDNhanVien = NhanVien.ID

exec USP_Login 'vuongtm', '123456'


alter trigger trigg_checktheloai
on TheLoai
instead of insert
as
begin
	declare @ten nvarchar(100), @ten_chuanhoa nvarchar(100)

	declare cur cursor
	for
		select Ten from inserted
	open cur
	fetch next from cur into @ten

	while (@@FETCH_STATUS = 0)
	begin
		set @ten_chuanhoa = UPPER(left(@ten, 1)) + lower(SUBSTRING(@ten, 2, len(@ten)))

		if exists (select Ten from TheLoai where LOWER(Ten) = LOWER(@ten_chuanhoa))
		begin
			--print N'Thể loại "' + @ten_chuanhoa + N'" đã tồn tại.'
			declare @msg nvarchar(2048) = N'Thể loại "' + @ten_chuanhoa + N'" đã tồn tại.';
			THROW 50001, @msg, 1;
		end
		else 
		begin
			insert into TheLoai values (@ten_chuanhoa)
			print N'Thêm thành công'
		end
		fetch next from cur into @ten
	end
	close cur
	deallocate cur
end

select * from TheLoai
insert into TheLoai values (N'lịch sử')


create view TheLoaiSach
as
select Sach.ID, TenSach, TenTacGia, SoLuong, TrangThai, Ten from Sach, TheLoai where Sach.IDTheLoai = TheLoai.ID and TheLoai.Ten = N'Tiểu thuyết'

alter function BookByCategory (@tenTheLoai nvarchar(100))
returns table
as
return
(	
	select Sach.ID as N'Mã sách', TenSach as N'Tên sách', TenTacGia as N'Tên tác giả', SoLuong as N'Số lượng', TrangThai as N'Trạng thái', Ten as N'Tên thể loại' 
	from Sach, TheLoai where Sach.IDTheLoai = TheLoai.ID and TheLoai.Ten = @tenTheLoai
)

alter function fn_CountBookByCategory (@IDTheLoai int)
returns int
as
begin
	return
	(
		select isnull(sum(SoLuong),0) from Sach where IDTheLoai = @IDTheLoai
	)
end

create view view_CategoryBookCount
as
select Ten as N'Tên thể loại', dbo.fn_CountBookByCategory(ID) as N'Số lượng' from TheLoai

select * from view_CategoryBookCount

print dbo.fn_CountBookByCategory(2)
select * from dbo.BookByCategory(N'Tiểu thuyết')



create trigger trigg_XoaNhaCungCap
on NhaCungCap instead of delete
as
begin
	update NhaCungCap set TrangThai = N'Ngừng hợp tác' from NhaCungCap 
	inner join deleted on NhaCungCap.ID = deleted.ID
end

create view view_ThongKeNhaCungCap
as 
select ID as N'Mã nhà cung cấp', Ten as N'Tên nhà cung cấp', SoDienThoai as N'Số điện thoại', DiaChi as N'Địa chỉ', TrangThai as N'Trạng thái'
from NhaCungCap

create proc proc_TongSach
as
begin
	create table TongSoSach
	(
	IDNhaCungCap int,
	TongSoSach int
	)

	declare @idNhacungcap int, @tongsosach int
	declare cur cursor
	for
		select ID from NhaCungCap
	open cur
	fetch next from cur into @idNhacungcap
	while(@@FETCH_STATUS = 0)
	begin
		select @tongsosach = isnull(sum(SoLuong),0) from Sach where IDNhaCungCap = @idNhacungcap

		insert into TongSoSach values (@idNhacungcap, @tongsosach)

		fetch next from cur into @idNhacungcap
	end
	close cur
	deallocate cur

	select *, isnull(TongSoSach, 0) from view_ThongKeNhaCungCap, TongSoSach where ID = IDNhaCungCap
end
