create database QuanLyNhaXe
go
use QuanLyNhaXe

create table tbl_Login(
	id int PRIMARY KEY,
	username nvarchar(50),
	password nvarchar(50),
)

insert into tbl_Login values(1,'nhanvien1','123');
insert into tbl_Login values(2,'nhanvien2','456');

select * from tbl_Login

