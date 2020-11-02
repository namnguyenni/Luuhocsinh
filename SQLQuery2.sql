select * from LuuHocSinh

declare @temp float
set @temp = Datediff(year,'2016-01-01','2016-12-01')
print(@temp)

--Thong ke si quan cbi len quan ham

create proc ThongKe_NienHanQuanHam
as
begin
Select * from (
Select b.* from(
Select LuuHocSinh.LHSID from LuuHocSinh,DoiTuong 
where LuuHocSinh.MaDoiTuong=DoiTuong.MaDoiTuong
and DoiTuong = N'Sĩ quan') as a
left join

(select LHSID,Max(NgayNhan)as NgayNhan from LHS_QuanHam
group by LHSID) as b
on a.LHSID=b.LHSID) as c
where (DATEDIFF(year,NgayNhan,getDate()))<=1
end

USE [QuanLyLHS]
GO
/****** Object:  Trigger [dbo].[update_diemtb]    Script Date: 10/29/2020 3:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[update_diemtb] on [dbo].[KetQuaHocTap]
for insert,update
as 
begin
	declare @dem int
	set @dem=0
	declare @Ki1 float
	declare @Ki2 float
	declare @Ki3 float
	declare @Ki4 float
	declare @Ki5 float
	declare @Ki6 float
	declare @Ki7 float
	declare @Ki8 float
	declare @Ki9 float
	declare @Ki10 float
	declare @Ki11 float
	declare @Ki12 float
	declare @Ki13 float
	declare @Ki14 float
	select @Ki1=Ki1 from inserted
	select @Ki2=Ki2 from inserted
	select @Ki3=Ki3 from inserted
	select @Ki4=Ki4 from inserted
	select @Ki5=Ki5 from inserted
	select @Ki5=Ki5 from inserted
	select @Ki6=Ki6 from inserted
	select @Ki7=Ki7 from inserted
	select @Ki8=Ki8 from inserted
	select @Ki9=Ki9 from inserted
	select @Ki10=Ki10 from inserted
	select @Ki11=Ki11 from inserted
	select @Ki12=Ki12 from inserted
	select @Ki13=Ki13 from inserted
	select @Ki14=Ki14 from inserted

	declare @tong float
	set @tong=0
	if(@Ki1 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki1
		end
	if(@Ki2 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki2
		end
	if(@Ki3 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki3
		end
	if(@Ki4 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki4
		end
	if(@Ki5 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki5
		end
	if(@Ki6 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki6
		end
	if(@Ki7 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki7
		end
	if(@Ki8 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki8
		end
	if(@Ki9 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki9
		end
	if(@Ki10 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki10
		end
	if(@Ki11 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki11
		end
	if(@Ki12 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki12
		end
	if(@Ki13 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki13
		end
	if(@Ki14 is not null) 
		begin
			set @dem=@dem+1
			set @tong=@tong+@Ki4
		end
	--tinh diem trung binh
	declare @diemtb float
	set @diemtb=ROUND(@tong/@dem,2)
	
	declare @id int
	select @id= MaKetQua from inserted

	update KetQuaHocTap
	set DiemTrungBinh=@diemtb
	where MaKetQua=@id
end