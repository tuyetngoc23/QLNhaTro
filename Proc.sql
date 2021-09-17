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

CREATE PROC sp_ThemKH @tenKH nvarchar(max), @cmnd nchar(10), @queQuan nvarchar(max), 
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
	else
		begin
			insert into KhachHang(HoTen, CMND, QueQuan, GioiTinh, NgaySinh, SDT) 
			values(@tenKH, @cmnd, @queQuan, @gt, @ngaySinh, @sdt)
		end
END

