create database QuanLyNhaXe
go
use QuanLyNhaXe

create table tbl_Login(
	id int IDENTITY(1,1) PRIMARY KEY,
	username nvarchar(50),
	password nvarchar(50),
	role nvarchar(50) 
)
drop table tbl_Login
Select * from tbl_Login 

insert into tbl_Login values('NhanVienVe','123','nhanvienve');
insert into tbl_Login values('NhanVienKyThuat','456','nhanvienkythuat');
insert into tbl_Login values('NhanVienLoTrinh','456','nhanvienlotrinh');
insert into tbl_Login values('NhanVienNhanSu','456','nhanviennhansu');
insert into tbl_Login values('admin','123','admin');



create table KhachHang(
	MaKH int IDENTITY(1,1) PRIMARY KEY,
	TenKH nvarchar(50),
	SDT varchar(10),
)
drop table KhachHang

insert into KhachHang values('Huynh Ngoc Tien','0902895176');  

select * from KhachHang
 
create table VeXe(
	MaVe int IDENTITY(1,1) PRIMARY KEY,
	TenKH nvarchar(50),
	SoGhe int,
	SoXe int,
	DiemDi nvarchar(50),
	DiemDen nvarchar(50),
	NgayDi datetime,
	GioKhoiHanh nvarchar(5), 
	GiaVe int,
)
drop table VeXe

insert into VeXe values('Tien',15,13,'TP.HCM','Ha Noi','7/11/2019','13:30',90000);

Update VeXe set GioKhoiHanh='20:30', TenKH = 'Huy' where MaVe = 1

create table Xe(
	MaXe int IDENTITY(1,1) PRIMARY KEY,
	LoaiXe nvarchar(50),
	BienSo nvarchar(50),
	BenXe nvarchar(50),
	SoLuongGhe int,
	NgayDangKy datetime,
	TinhTrangXe nvarchar(50),
)

drop table Xe;

insert into Xe values('Xe Limousine','59-L1 0837','TP.HCM',16,'7/11/2019','OK');

create table LoTrinh(
	MaLoTrinh int IDENTITY(1,1) PRIMARY KEY,
	DiemDi nvarchar(50),
	DiemDen nvarchar(50),
	NgayDi datetime,
	GioKhoiHanh nvarchar(5),

)
drop table LoTrinh

insert into LoTrinh values('TP.HCM','Đà Lạt','7-15-2019','05:50');

create table NhanVien(
	MaNhanVien int IDENTITY(1,1) PRIMARY KEY,
	TenNhanVien nvarchar(50),
	SoDienThoai nvarchar(50),
	DiaChi nvarchar(50),
	Email nvarchar(50),
)

drop table NhanVien

insert into NhanVien values('Tien','0902895176','PTH F6 Q8','ngoctienhuynh1999@gmail.com')

