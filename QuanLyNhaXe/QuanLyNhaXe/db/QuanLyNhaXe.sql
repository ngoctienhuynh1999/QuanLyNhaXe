create database QuanLyNhaXe
go
use QuanLyNhaXe

create table tbl_Login(
	id int PRIMARY KEY,
	username nvarchar(50),
	password nvarchar(50),
	role nvarchar(50) 
)

insert into tbl_Login values(1,'NhanVienVe','123','nhanvienve');
insert into tbl_Login values(2,'NhanVienKyThuat','456','nhanvienkythuat');

select * from tbl_Login

create table KhachHang(
	MaKH nvarchar(50) primary key,
	TenKH nvarchar(50),
	SDT varchar(10),
)

insert into KhachHang values('KH01','Huynh Ngoc Tien','0902895176');  
 
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

insert into VeXe values('Tien',15,13,'TP.HCM','Ha Noi','7/11/2019','13:30',90000);


