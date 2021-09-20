CREATE PROC sp_TinhTien @maThue int, @soDien int, @soNuoc int, @tongTien decimal, @thangID int
AS
BEGIN
	update ThuePhong
	set TrangThaiThanhToan = 1
	where ID = @maThue

	insert into HoaDon values(@soDien, @soNuoc, @tongTien, @maThue, @thangID, GETDATE())
END

Alter PROC sp_TraPhong @PhongID int, @KHID int, @ThuePhongID int
AS
BEGIN
	update Phong
	set TrangThai = 0
	where ID = @PhongID
	update ThuePhong
	set TrangThaiTraPhong = 1
	where ID = @ThuePhongID
	update KhachHang
	set TrangThaiThuePhong = 0
	where ID = @KHID
	insert into TraPhong values(GETDATE(), @ThuePhongID, 1)
	
END


AlTER PROC sp_ThuePhong @tienCoc decimal, @ngayNhanCoc date, @PhongID int, @KHID int
AS
BEGIN
	insert into ThuePhong(TienCoc, NgayNhanCoc, PhongID, KhachHangID, NgayThue)
	values (@tienCoc, @ngayNhanCoc, @PhongID, @KHID, GETDATE())
	update Phong
	set TrangThai = 1
	where ID = @PhongID
	update KhachHang
	set TrangThaiThuePhong = 1
	where ID = @KHID
END

alter PROC sp_ThemKH @tenKH nvarchar(max), @cmnd nchar(10), @queQuan nvarchar(max), 
						@gt nvarchar(50), @ngaySinh date, @sdt nchar(10), @id int
AS
BEGIN
	if(@id in (select ID from KhachHang))
		begin
			update KhachHang
			set HoTen = @tenKH, CMND = @cmnd, QueQuan = @queQuan, GioiTinh = @gt,
				NgaySinh = @ngaySinh,
				SDT = @sdt
			where ID = @id
		end
	else if(@cmnd in (select CMND from KhachHang))
		begin
			update KhachHang
			set HoTen = @tenKH, CMND = @cmnd, QueQuan = @queQuan, GioiTinh = @gt,
				NgaySinh = @ngaySinh,
				SDT = @sdt
			where ID = (select ID from KhachHang where CMND = @cmnd)
		end
	else
		begin
			insert into KhachHang(HoTen, CMND, QueQuan, GioiTinh, NgaySinh, SDT) 
			values(@tenKH, @cmnd, @queQuan, @gt, @ngaySinh, @sdt)
		end
END

