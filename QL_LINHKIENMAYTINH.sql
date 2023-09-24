USE MASTER
GO
IF EXISTS(SELECT *FROM sysdatabases WHERE name='QL_LINHKIENMAYTINH')
DROP DATABASE QL_LINHKIENMAYTINH
GO
CREATE DATABASE QL_LINHKIENMAYTINH
GO
USE QL_LINHKIENMAYTINH
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE CHITIETHD
(
	MAHD int NOT NULL,
	MALINHKIEN int NOT NULL,
	SOLUONG int,
	DONGIA float,
	THANHTIEN float,
	CONSTRAINT PK_CHITIETHD PRIMARY KEY (MAHD, MALINHKIEN)
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE CHITIETNK
(
	MAPN int NOT NULL,
	MALINHKIEN int NOT NULL,
	SOLUONG int,
	DONGIA float,
	THANHTIEN float,
	CONSTRAINT PK_CHITIETNK PRIMARY KEY (MAPN, MALINHKIEN)
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE HOADON(
	MAHD int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	NGAYLAP date NOT NULL,
	tongtien float,
	MANV int,
	MAKH int,
	giamgia float,
	ispay bit 
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE KHACHHANG(
	Makh int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TENKH nvarchar(100) NOT NULL,
	GIOITINH bit,
	DIACHI nvarchar(50),
	SDT char(12),
	maloaikh int
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE LINHKIEN
(
	MALINHKIEN int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TENLINHKIEN nvarchar(300),
	MALOAI int,
	HANGSX nvarchar(25),
	DONGIA float,
	HINHANH varchar(50),
	SOLUONGCON int NULL DEFAULT 50
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE LOAIKH
(
	MALOAIKH int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TENLOAIKH nvarchar(100),
	GIAMGIA float
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE LOAILINHKIEN
(
	MALOAI int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TENLOAI nvarchar(50)
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE NHANVIEN
(
	MANV int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TENNV nvarchar(30) NOT NULL,
	DIACHI nvarchar(50),
	SDT char(12),
	GIOITINH bit,
	NGAYVL date NOT NULL,
	LUONG float,
	HINHANH varchar(50),
	taikhoan varchar(30) NOT NULL,
	MATKHAU varchar(100) NOT NULL DEFAULT ('827ccb0eea8a706c4c34a16891f84e7b'),
	maquyen int DEFAULT 1
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE NHAPKHO
(
	MAPN int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	NGAYNHAP date NOT NULL,
	tongtien float,
	MANV int,
	ispay bit
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE QUYEN
(
	maquyen int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	tenquyen nvarchar(100) NOT NULL
)
GO
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function topSelling()
returns table
as
return 
(
select TENLINHKIEN,sum(soluong) as soluong from chitiethd,LINHKIEN,hoadon
where CHITIETHD.MALINHKIEN=LINHKIEN.MALINHKIEN and hoadon.mahd=chitiethd.mahd and Month(hoadon.ngaylap)=Month(getdate()) and Year(hoadon.ngaylap)=Year(getdate())
group by LINHKIEN.MALINHKIEN, LINHKIEN.TENLINHKIEN
having SUM(soluong)>=30
)

GO
---0: theo tháng
---1: theo năm
CREATE function topCustomerBuy(@checkType bit, @date Date)
returns @TABLE TABLE(name nvarchar(100),totalMoney int)
as
begin

if(@checkType=1)
	insert into @TABLE select top 5 khachhang.tenkh,sum(tongtien) 'total' from khachhang,hoadon
	where khachhang.makh=hoadon.makh and YEAR(NGAYLAP)=YEAR(@date)
	group by khachhang.makh,khachhang.tenkh
	order by sum(tongtien) desc
else
	insert into @TABLE select top 5 khachhang.tenkh,sum(tongtien) 'total' from khachhang,hoadon
	where khachhang.makh=hoadon.makh and MONTH(NGAYLAP)=MONTH(@date) and YEAR(NGAYLAP)=YEAR(@date)
	group by khachhang.makh,khachhang.tenkh
	order by sum(tongtien) desc
return 

end

GO

---0: theo tháng
---1: theo năm
CREATE function topStaffSell(@checkType bit, @date Date)
returns @TABLE TABLE(name nvarchar(100),totalOrder int)
as
begin
if(@checkType=1)
	insert into @TABLE select top 5 NHANVIEN.TENNV, count(*) 'totalOrder' from NHANVIEN,hoadon
	where NHANVIEN.MANV=HOADON.MANV and YEAR(NGAYLAP)=YEAR(@date)
	group by NHANVIEN.MANV,NHANVIEN.TENNV
	order by count(*) desc
	else
	insert into @TABLE select top 5 NHANVIEN.TENNV, count(*) 'totalOrder' from NHANVIEN,hoadon
	where NHANVIEN.MANV=HOADON.MANV and MONTH(NGAYLAP)=MONTH(@date) and YEAR(NGAYLAP)=YEAR(@date)
	group by NHANVIEN.MANV,NHANVIEN.TENNV
	order by count(*) desc
return 

end
GO


INSERT KHACHHANG (TENKH, GIOITINH, DIACHI, SDT, maloaikh) 
VALUES 
(N'Nguyễn Tuấn Kiệt', 1, N'Tiền Giang', N'0376880903  ', 1),
(N'Nguyễn Thành Trung', 1, N'TPHCM', N'0703031232  ', 3),
(N'Diệp Bá Huy', 0, N'HCM', N'0403332112  ', 2);

INSERT LINHKIEN (TENLINHKIEN, MALOAI, HANGSX, DONGIA, HINHANH, SOLUONGCON) 
VALUES 
(N'ASUS ROG STRIX G G512 IAL013T', 1, N'ASUS', 324332, N'6KCM16U4.jpg', 20),
(N'MACBOOK PRO 13 2020 Z11B000CT', 1, N'APPLE', 369900, N'imagelp2.jpg', 1),
(N'ACER ASPIRE 3 A315 57G 524Z', 1, N'Acer', 154900, N'imagelp3.jpg', 10),
(N'ASUS VIVOBOOK D515UA Ẹ045T', 1, N'ASUS', 1349000, N'imagelp4.jpg', 2),
(N'MSI MODERN 14 B11MO 011VN', 1, N'MSI', 2099000, N'imagelp5.jpg', 98),
(N'LENOVO IDEAPAD	SLIM 3 14IIL05 81WD00VJVN', 1, N'LENOVO', 1049000, N'imagelp6.jpg', 2),
(N'ASUS H410M-E', 2, N'ASUS', 1865000, N'imagemb1.jpg', 3),
(N'GIGABYTE B460M GAMING HD', 2, N'GIGABYTE', 1990000, N'imagemb2.jpg', 4),
(N'ASUS H410M-CS', 12, N'ASUS', 1810000, N'imagemb3.jpg', 2),
(N'MSI MAG B365M MORTAR', 2, N'MSI', 2390000, N'imagemb4.jpg', 10),
(N'GIGABYTE B365M GAMING HD', 2, N'GIGABYTE', 1750000, N'imagemb5.jpg', 1),
(N'GIGABYTE Z390 GAMING X', 2, N'GIGABYTE', 4090000, N'imagemb6.jpg', 20),
(N'AMD Ryzen 7 3700x', 3, N'AMD', 8490000, N'imagecp1.jpg', 24),
(N'AMD Ryzen 9 5900X', 3, N'AMD', 1529000, N'imagecp2.jpg', 15),
(N'AMD Ryzen Threadripper PRO', 3, N'AMD', 720000, N'imagecp3.jpg', 12),
(N'AMD Ryzen 5 2600', 3, N'AMD', 505000, N'imagecp4.jpg', 10),
(N'Intel Celeron G4900', 3, N'Intel', 1150000, N'imagecp5.jpg', 58),
(N'Adata Value Value 4GB', 4, N'ADATA', 550000, N'imagera1.jpg', 10),
(N'Gigabyte Memory 2666', 4, N'GIGABYTE', 1190000, N'imagera2.jpg', 39),
(N'G.SKILL Ripjaws V', 4, N'G.SKILL', 1190000, N'imagera3.jpg', 100),
(N'G.SKILL Trident Z RGB', 4, N'G.SKILL', 2890000, N'imagera4.jpg', 100),
(N'G.SKILL Z Neo', 4, N'G.SKILL', 4390000, N'imagera5.jpg', 100),
(N'Corsair Vengeance RGB PRO', 4, N'CORSAIR', 1199000, N'imagera6.jpg', 100),
(N'MSI GeForce RTX 3090 SUPRIM X 24G', 5, N'MSI', 75990000, N'imagevg1.jpg', 100),
(N'MSI Geforce RTX 3090 GAMING X TRIO 24G', 5, N'MSI', 72990000, N'imagevg2.jpg', 100),
(N'MSI Geforce RTX 3080 SUPRIM X 10G', 5, N'MSI', 60990000, N'imagevg3.jpg', 100),
(N'GIGABYTE AORUS Geforce RTX 3070 MASTER 8G', 11, N'GIGABYTE', 35990000, N'imagevg4.jpg', 100),
(N'GIGABYTE AORUS Radeon RX 6800 MASTER 16G', 5, N'GIGABYTE', 3199000, N'imagevg5.jpg', 100),
(N'ASUS Dual Radeon RX 6700', 5, N'ASUS', 2249000, N'imagevg6.jpg', 100),
(N'PNY SSD CS900 240GB 2.5" Sata 3', 6, N'PNY', 890000, N'imagess1.jpg', 100),
(N'SSD SAMSUNG 980 M.2 PCLe NVMe 250GB', 6, N'SAMSUNG', 1990000, N'imagess2.jpg', 100),
(N'SSD SAMSUNG 980 PRO 250GB M.2 NVMe MZ -V8P250BW', 6, N'SAMSUNG', 2450000, N'imagess3.jpg', 100),
(N'SSD KINGSTON A2000 1TB M.2 NVMe-SA2000M8/1000G', 6, N'KINGSTON', 3290000, N'imagess4.jpg', 100),
(N'WD SSD Black SN750 500GB M.2 NVMe PCIe 3470/2600 MB/s', 6, N'WESTERN DIGITAL', 2790000, N'imagess5.jpg', 100),
(N'SSD WD SN850 500GB M.2 PCIe NVMe (Gen 4)', 6, N'WESTERN DIGITAL', 3690000, N'imagess6.jpg', 34),
(N'HDD WD Blue 1TB 7200rpm', 7, N'WESTERN DIGITAL', 1050000, N'imagehd1.jpg', 100),
(N'HDD WD Red 2TB 5400rpm', 7, N'WESTERN DIGITAL', 2190000, N'imagehd2.jpg', 100),
(N'HDD WD Black 1TB 7200rpm', 7, N'WESTERN DIGITAL', 2000000, N'imagehd3.jpg', 100),
(N'WD HDD Black 2TB 7200rpm', 7, N'WESTERN DIGITAL', 3690000, N'imagehd4.jpg', 100),
(N'HDD Seagate Ironwolf PRO 4TB 7200rpm', 7, N'SEAGATE', 5090000, N'imagehd5.jpg', 100),
(N'HDD Seagate Ironwolf PRO 14TB 7200rpm', 7, N'SEAGATE', 14490000, N'imagehd6.jpg', 34),
(N'Case XIGMATEK AERO 2F', 8, N'XIGMATEK', 690000, N'imagevm1.jpg', 100),
(N'Case XIGMATEK GAMING X 3FX', 8, N'XIGMATEK', 850000, N'imagevm2.jpg', 100),
(N'Case MSI MAG VAMPIRIC 100R', 8, N'XIGMATEK', 1490000, N'imagevm3.jpg', 100),
(N'Case Antec NX800', 8, N'ANTEC', 1750000, N'imagevm4.jpg', 100),
(N'Case Xigmatek Aquarius Plus-Black', 8, N'XIGMATEK', 2000000, N'imagevm5.jpg', 100),
(N'Case Deepcool CL500 4F', 8, N'DEEPCOOL', 2190000, N'imagevm6.jpg', 100),
(N'(600W) Nguồn SliverStone ST60F-ES230-80 Plus', 9, N'SLIVERSTONE', 1090000, N'imageps1.jpg', 100),
(N'(750W) Nguồn CoolerMaster MWE 750 BRONZE-V2 230V', 9, N'COOLER MASTER', 2090000, N'imageps2.jpg', 100),
(N'(650W) Nguồn Corsair RM650-80 Plus Gold-Full Modular', 9, N'CORSAIR', 2690000, N'imageps3.jpg', 100),
(N'(850W) Nguồn Corsair RM850-80 Plus Gold-Full Modular', 9, N'CORSAIR', 3290000, N'imageps4.jpg', 100),
(N'(850W) Nguồn Corsair RM850X-80 Plus Gold-Full Modular', 9, N'CORSAIR', 3790000, N'imageps5.jpg', 100),
(N'(1200W)Nguồn Corsair AX1200i-1200 Watt-80 Plus Platinum-Full Modular', 9, N'CORSAIR', 9200000, N'imageps6.jpg', 100),
(N'Fan DEEPCOOL CF120-FAN RGB(CF120)', 10, N'DEEPCOOL', 450000, N'imagetn1.jpg', 100),
(N'Tản nhiệt Xigmatek Windpower Pro ARGB', 10, N'XIGMATEK', 890000, N'imagetn2.jpg', 100),
(N'Fan Cooler Master MASTERFAN MF120 PRISMATIC 3 IN 1', 10, N'COOLER MASTER', 1550000, N'imagetn3.jpg', 100),
(N'Tản nhiệt Cooler Master MASTERAIR MA610P ARGB', 10, N'COOLER MASTER', 1750000, N'imagetn4.jpg', 100),
(N'Tản nhiệt GIGABYTE AORUS ATC800', 10, N'GIGABYTE', 2050000, N'imagetn5.jpg', 100),
(N'Tản nhiệt Deepcool Assassin III', 10, N'DEEPCOOL', 2250000, N'imagetn6.jpg', 100),
(N'Tai nghe DareU EH416 RGB', 11, N'DARE-U', 350000, N'imagetng1.jpg', 100),
(N'Tai nghe HyperX Cloud II RED', 11, N'KINGSTON', 2090000, N'imagetng2.jpg', 100),
(N'Tai nghe Gaming Logitech G Pro Gen 2', 11, N'LOGITECH', 2390000, N'imagetng3.jpg', 100),
(N'Tai nghe HyperX Cloud Stinger Core', 11, N'KINGSTONE', 799000, N'imagetng4.jpg', 100),
(N'Tai nghe Razer Hammerhead True Wireless Earbuds', 11, N'RAZER', 2290000, N'imagetng5.jpg', 100),
(N'Tai nghe Cooler Master MH710', 11, N'COOLER MASTER', 990000, N'imagetng6.jpg', 100),
(N'Bàn phím Razer Huntsman Mini', 12, N'RAZER', 3190000, N'imagebp1.jpg', 100),
(N'Bàn phím Razer Blackwidow V3', 12, N'RAZER', 3590000, N'imagebp2.jpg', 100),
(N'Bàn phím Razer Blackwidow V3 Pro', 12, N'RAZER', 5990000, N'imagebp3.jpg', 100),
(N'Bàn phím Logitech G813 RGB', 12, N'LOGITECH', 3090000, N'imagebp4.jpg', 100),
(N'Bàn phím Logitech G913 TKL Lightspeed Wireless', 12, N'LOGITECH', 3990000, N'bg.gif', 220),
(N'Bàn phím Leopold FC660MPD Light Pink', 12, N'LEOPOLD', 2750000, N'imagebp6.jpg', 100),
(N'Màn hình ViewSonic VX2458-P 24" 144Hz FreeSync', 13, N'VIEWSONIC', 4350000, N'imagemh1.jpg', 100),
(N'Màn hình Asus TUF GAMING VG249Q 24" IPS 144Hz FreeSync chuyên game', 13, N'ASUS', 5450000, N'imagemh2.jpg', 100),
(N'Màn hình ViewSonic VP2458 24" IPS chuyên đồ họa', 13, N'VIEWSONIC', 4500000, N'imagemh3.jpg', 100),
(N'Màn hình ASUS ProArt PA248QV 24" IPS 75Hz 16:10 chuyên đồ họa', 13, N'ASUS', 5190000, N'imagemh4.jpg', 100),
(N'Màn hình Dell UltraSharp U2721DE 27" IPS 2K chuyên đồ họa', 13, N'DELL', 1069000, N'imagemh5.jpg', 100),
(N'Màn hình cong Philips 322M8CZ 32" VA 165Hz Freesync', 13, N'PHILIPS', 6290000, N'imagemh6.jpg', 200),
(N'Chuột Logitech G102 Lightsync RGB Black', 14, N'LOGITECH', 400000, N'imagech1.jpg', 100),
(N'Chuột Logitech G502 Hero', 14, N'LOGITECH', 990000, N'imagech2.jpg', 100),
(N'Chuột Logitech G Pro Wireless', 14, N'LOGITECH', 2690000, N'imagech3.jpg', 100),
(N'Chuột Razer DeathAdder V2', 14, N'RAZER', 1690000, N'imagech4.jpg', 100),
(N'Chuột Razer DeathAdder V2 Pro', 14, N'RAZER', 299000, N'imagech5.jpg', 100),
(N'Chuột Steelseries Rival 650', 14, N'STEELSERIES', 259000, N'imagech6.jpg', 100),
(N'Bộ định tuyến WiFi 5 ASUS RT-AC1500UHP Chuẩn AC1500 (Xuyên tường)', 15, N'ASUS', 1690000, N'imagetbm1.jpg', 100),
(N'Bộ định tuyến WiFi 6 Asus RT-AX82U Gundam Edition', 15, N'ASUS', 6390000, N'imagetbm2.jpg', 100),
(N'Bộ định tuyến WiFi 6 Asus RT-AX86U Zaku II Gundam Edition', 15, N'ASUS', 7390000, N'imagetbm3.jpg', 100),
(N'Bộ định tuyến WiFi 6 ASUS RT-AX88U Chuẩn AX6000', 15, N'ASUS', 8190000, N'imagetbm4.jpg', 100),
(N'Bộ định tuyến WiFi 6 ASUS RT-AX92U Chuẩn AX6100', 15, N'ASUS', 9090000, N'imagetbm5.jpg', 100),
(N'Bộ định tuyến WiFi 6 ROG Rapture GT-AX11000 Chuẩn AX11000', 15, N'ASUS', 1449000, N'blog1.jpg', 100),
(N'MÀN HÌNH CONG SAMSUNG', 13, N'SAMSUNG', 1200000, N'service1.jpg', 1000);


INSERT LOAIKH (TENLOAIKH, GIAMGIA) 
VALUES 
(N'KHÁCH HÀNG VIP', 0.1),
(N'KHÁCH HÀNG TIỀM NĂNG', 0.08),
(N'KHÁCH HÀNG THÂN THIẾT', 0.05);


INSERT LOAILINHKIEN (TENLOAI) 
VALUES 
(N'Laptop'),
(N'Mainboard'),
(N'CPU'),
(N'RAM'),
(N'VGA'),
(N'SSD'),
(N'HDD'),
(N'VỎ MÁY TÍNH'),
(N'PSU'),
(N'TẢN NHIỆT'),
(N'TAI NGHE'),
(N'BÀN PHÍM'),
(N'MÀN HÌNH'),
(N'CHUỘT'),
(N'THIẾT BỊ MẠNG');

INSERT NHANVIEN (TENNV, DIACHI, SDT, GIOITINH, NGAYVL, LUONG, HINHANH, taikhoan, MATKHAU, maquyen) 
VALUES 
(N'Nguyễn Tuấn Kiệt', N'TP.HCM', N'0376880903  ', 1, CAST(N'2021-05-11' AS Date), 11000000, N'cart.jpg', N'limminh', N'12345', 1),
(N'Nguyễn Thành Trung', N'Bình Định', N'0789632456  ', 1, CAST(N'2021-04-12' AS Date), 10000000, N'logo.jpg.png', N'duyho', N'12345', 1),
(N'Nguyễn Nhật My', N'TPHCM', N'0125325635  ', 1, CAST(N'2020-12-14' AS Date), 14000000, N'cart4.jpg', N'mynguyen', N'12345', 1),
(N'Lê Bảo Hoàng Việt', N'TPHCM', N'01245369852 ', 0, CAST(N'2019-12-14' AS Date), 15000000, N'productbig.jpg', N'vietle', N'12345', 1),
(N'Nguyễn Trần Yến Nhi', N'TPHCM', N'01247369752 ', 1, CAST(N'2017-12-14' AS Date), 100000000, N'staff(7).png', N'nhinguyen', N'12345', 1),
(N'Trương Văn Tấn Trung', N'TPHCM', N'0784325965  ', 1, CAST(N'2020-01-14' AS Date), 1, N'blog4.jpg', N'trungtruongd', N'12345', 2),
(N'Diệp Bá Huy', N'Tiền Giang', N'0376880903  ', 1, CAST(N'2001-12-06' AS Date), 423423423, N'cart.png', N'dongduy', N'12345', 2);


INSERT NHAPKHO (NGAYNHAP, tongtien, MANV, ispay) 
VALUES 
(CAST(N'2022-05-22' AS Date), 25754159612, 1, 1),
(CAST(N'2022-05-23' AS Date), 18619, 1, 1),
(CAST(N'2022-05-23' AS Date), 501618040, 1, 1),
(CAST(N'2022-05-23' AS Date), 2400000000, 1, 1),
(CAST(N'2022-06-05' AS Date), 19752521031, 1, 1),
(CAST(N'2022-06-05' AS Date), 310962475, 1, 1),
(CAST(N'2022-06-05' AS Date), 33242176, 1, 1),
(CAST(N'2022-06-05' AS Date), 6577880000, 1, 1),
(CAST(N'2022-06-06' AS Date), 2595691500, 1, 1),
(CAST(N'2022-06-06' AS Date), 568040000, 1, 1),
(CAST(N'2022-06-06' AS Date), 1891000000, 1, 1),
(CAST(N'2022-06-06' AS Date), 1183900000, 1, 1),
(CAST(N'2022-06-06' AS Date), 1460000000, 1, 1),
(CAST(N'2022-06-06' AS Date), 808979900, 1, 1),
(CAST(N'2022-06-06' AS Date), 5176877600, 1, 1),
(CAST(N'2022-06-06' AS Date), 109999989, 1, 1);
INSERT QUYEN (tenquyen) 
VALUES 
(N'Nhân viên'),
(N'admin');
