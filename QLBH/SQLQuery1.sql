CREATE DATABASE QLBHang
GO

USE QLBHang
GO

CREATE TABLE LoaiMatHang(
	MaLoai int IDENTITY(1,1) PRIMARY KEY,
	TenLoai nvarchar(50) NOT NULL)
GO

CREATE TABLE MatHang(
	MaMatHang int IDENTITY(1,1) PRIMARY KEY,
	TenMatHang nvarchar(50) NOT NULL,
	LoaiMatHang int NOT NULL references LoaiMatHang(MaLoai),
	SoLuongTon int NOT NULL,
	DonGia int NOT NULL)
GO

INSERT into LoaiMatHang  VALUES (N'Bia')
INSERT into LoaiMatHang  VALUES (N'Dầu ăn')
INSERT into LoaiMatHang  VALUES (N'Nước ngọt')
INSERT into LoaiMatHang  VALUES (N'Hạt nêm')
INSERT into LoaiMatHang  VALUES (N'Bột giặt')
INSERT into LoaiMatHang  VALUES (N'Kem đánh răng')
INSERT into LoaiMatHang  VALUES (N'Sữa')
INSERT into LoaiMatHang  VALUES (N'Nước mắm')
INSERT into LoaiMatHang  VALUES (N'Giấy ăn')
INSERT into LoaiMatHang  VALUES (N'Mì tôm')
INSERT into LoaiMatHang  VALUES (N'Kẹo')
GO
SELECT * FROM MatHang
INSERT into  MatHang  VALUES  (N'Bia 333', 1, 34,33000)
INSERT into  MatHang  VALUES (N'Bia saigon', 1, 23,35000)
INSERT into  MatHang  VALUES (N'Bia Heniken', 1, 12,46000)
INSERT into  MatHang  VALUES (N'Bia tiger thường', 1, 11, 39000)
INSERT into  MatHang  VALUES (N'Bia tiger bạc', 1, 4, 23000)
INSERT into  MatHang  VALUES (N'Dầu Neptune 1l', 2, 3, 56000)
INSERT into  MatHang  VALUES (N'Dầu Neptune 2l',2, 20, 64000)
INSERT into  MatHang  VALUES (N'Dầu Neptune 5l',2, 20, 2500)
INSERT into  MatHang  VALUES (N'Dầu Simply 1l',2, 30, 3800)
INSERT into  MatHang  VALUES (N'Dầu Simply 2l',2, 24, 2000)
INSERT into  MatHang  VALUES (N'Dầu Simply 5l',2, 15, 2500)
INSERT into  MatHang  VALUES (N'Pepsi lon', 3,30, 22000)
INSERT into  MatHang  VALUES (N'Pepsi chai 500ml',3, 52, 2000)
INSERT into  MatHang  VALUES (N'Coca lon',3, 35, 20000)
INSERT into  MatHang  VALUES (N'Coca chai 500ml', 3,4, 2000)
INSERT into  MatHang  VALUES (N'Hạt nêm Knorr 500g',4,20,  436000)
INSERT into  MatHang  VALUES (N'Surf 1kg',5, 1, 48000)
GO
-- Tạo thủ tục để thêm mặt hàng mới
CREATE PROCEDURE ThemMatHang
	@TenMatHang nvarchar(50),
	@LoaiMatHang int,
	@SoLuongTon int,
	@DonGia int
AS
BEGIN
	INSERT INTO MatHang (TenMatHang, LoaiMatHang, SoLuongTon, DonGia)
	VALUES (@TenMatHang, @LoaiMatHang, @SoLuongTon, @DonGia)
END
GO

-- Tạo thủ tục để cập nhật thông tin mặt hàng
CREATE PROCEDURE CapNhatMatHang
	@MaMatHang int,
	@TenMatHang nvarchar(50),
	@LoaiMatHang int,
	@SoLuongTon int,
	@DonGia int
AS
BEGIN
	UPDATE MatHang
	SET TenMatHang = @TenMatHang,
		LoaiMatHang = @LoaiMatHang,
		SoLuongTon = @SoLuongTon,
		DonGia = @DonGia
	WHERE MaMatHang = @MaMatHang
END
GO
CREATE PROCEDURE ThemLoaiMatHang
	@TenLoai nvarchar(50)
AS
BEGIN
	INSERT INTO LoaiMatHang (TenLoai)
	VALUES (@TenLoai)
END
GO
