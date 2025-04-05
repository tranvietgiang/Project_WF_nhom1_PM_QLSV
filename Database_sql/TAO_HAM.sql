------------------------------------------- SELECT THE TABLE
USE PROJECT_QLSV
------------------------------------------- SELECT THE TABLE
GO
create proc AllTheKhoa
as
begin
	select mh.SUBJECT_ID, mh.NAME_ST, mh.SOTC,mh.SOTIET, mh.DGTC,  gv.FULLNAME, nganh.MAJOR_NAME
	from TB_SUBJECT mh, TB_MAJOR nganh, TB_INSTRUCTORS gv
	where mh.MAJOR_ID = nganh.MAJOR_ID AND mh.INSTRUCTOR_ID = gv.INSTRUCTOR_ID 
end
-- DROP PROC PrintSubjctHTTT
GO
CREATE PROC PrintSubjctCNTT
as
begin
	select mh.SUBJECT_ID, mh.NAME_ST, mh.SOTC,mh.SOTIET, mh.DGTC,  gv.FULLNAME, nganh.MAJOR_NAME
	from TB_SUBJECT mh, TB_MAJOR nganh, TB_INSTRUCTORS gv
	where mh.MAJOR_ID = nganh.MAJOR_ID AND mh.INSTRUCTOR_ID = gv.INSTRUCTOR_ID  AND nganh.MAJOR_ID = 'MJ01'
end
GO
--- 
CREATE PROC PrintSubjctHTTT
as
begin
	select mh.SUBJECT_ID, mh.NAME_ST, mh.SOTC,mh.SOTIET, mh.DGTC,  gv.FULLNAME, nganh.MAJOR_NAME
	from TB_SUBJECT mh, TB_MAJOR nganh, TB_INSTRUCTORS gv
	where mh.MAJOR_ID = nganh.MAJOR_ID AND mh.INSTRUCTOR_ID = gv.INSTRUCTOR_ID AND nganh.MAJOR_ID = 'MJ02'
end
GO
CREATE PROC PrintSubjctQTKD
as
begin
	select mh.SUBJECT_ID, mh.NAME_ST, mh.SOTC,mh.SOTIET, mh.DGTC,  gv.FULLNAME, nganh.MAJOR_NAME
	from TB_SUBJECT mh, TB_MAJOR nganh, TB_INSTRUCTORS gv
	where mh.MAJOR_ID = nganh.MAJOR_ID AND mh.INSTRUCTOR_ID = gv.INSTRUCTOR_ID AND nganh.MAJOR_ID = 'MJ03'
end
-- DROP PROC PrintSubjctTKDH
GO
CREATE PROC PrintSubjctQLTC
as
begin
	select mh.SUBJECT_ID, mh.NAME_ST, mh.SOTC,mh.SOTIET, mh.DGTC,  gv.FULLNAME, nganh.MAJOR_NAME
	from TB_SUBJECT mh, TB_MAJOR nganh, TB_INSTRUCTORS gv
	where mh.MAJOR_ID = nganh.MAJOR_ID AND mh.INSTRUCTOR_ID = gv.INSTRUCTOR_ID AND nganh.MAJOR_ID = 'MJ04'
end
GO
CREATE PROC PrintSubjctTKDH
as
begin
	select mh.SUBJECT_ID, mh.NAME_ST, mh.SOTC,mh.SOTIET, mh.DGTC,  gv.FULLNAME, nganh.MAJOR_NAME
	from TB_SUBJECT mh, TB_MAJOR nganh, TB_INSTRUCTORS gv
	where mh.MAJOR_ID = nganh.MAJOR_ID AND mh.INSTRUCTOR_ID = gv.INSTRUCTOR_ID AND nganh.MAJOR_ID = 'MJ05'
end
GO
-- DROP PROC PrintSubjct
CREATE PROC PrintINSTRUCTOR
as
begin
	select * from TB_INSTRUCTORS
end
GO
-- xuất table tb_Major
CREATE PROC PrintMajor
as
begin
	select *  from TB_MAJOR 
end
-- DROP PROC PrintMajor
GO
---------------------------------------- HÀM UPDATE

CREATE PROC Update_socre
(
    @mamon CHAR(20),
    @masv CHAR(20),
    @score FLOAT
)
AS
BEGIN

    UPDATE TB_SCORE
    SET SCORE = @score
    WHERE STUDENT_ID = @masv AND SUBJECT_ID = @mamon;
	RETURN 0;
END
--drop proc Update_socre
go
create proc TimDiemSV(@masv char(20))
as
begin
	if not exists(select 1 from TB_STUDENTS where STUDENT_ID = @masv)
	begin
		print 'sinh viên này không tồn tại'
		return -1
	end
	select *
	from TB_SCORE
	where STUDENT_ID = @masv
	return 0;
end
go
-- In sinh viên
create proc PrintSVCD23TT9
as
begin
	select * from TB_STUDENTS where CLASS_NAME = N'CD23TT9'
end
go
create proc PrintSVCD23TT4
as
begin
	select * from TB_STUDENTS where CLASS_NAME = N'CD23TT4'
end
go
create proc PrintSVCD23TT7
as
begin
	select * from TB_STUDENTS where CLASS_NAME = N'CD23TT7'
end
go
go
create proc PrintSVCD23TT10
as
begin
	select * from TB_STUDENTS where CLASS_NAME = N'CD23TT10'
end
go
create proc PrintSV
as
begin
	select * from TB_STUDENTS 
end
--drop proc PrintSV
--exec PrintSV
go
-- In Khoa
create proc PrintKhoa
as
begin
	select * from TB_FACULTY
end
--drop proc PrintKhoa
-- exec PrintKhoa
go
-- In ra lớp
create proc PrintLop
as
begin
	select * from TB_CLASS
end
--exec PrintLop
go
create proc AddSV(@maSV char(20), @nameSV nvarchar(50), @gender nvarchar(5), @email nvarchar(225), @phone nvarchar(12), @address nvarchar(225),
@ngayS date, @maKH char(20), @maNganh char(20), @class_name nvarchar(20))
as
begin

	if exists (select 1 from TB_STUDENTS where STUDENT_ID = @maSV)
	begin
		print 'Sinh Viên'
		return -1;
	end

	if exists (select 1 from TB_STUDENTS where EMAIL = @email)
	begin
		print 'Email phải là unique!';
		return -2;
	end

	insert into TB_STUDENTS
	values(@maSV, @nameSV, @gender, @email, @phone, @address, @ngayS, @maKH, @maNganh, @class_name)
	return 0;
end
-- drop proc AddSV

go
-- xóa sinh viên
create proc DeleteSV(@maSV char(20))
as
begin
	if not exists (select 1 from TB_STUDENTS where STUDENT_ID = @maSV)
	begin
		print 'SV not exited!'
		return -1;
	end

	if exists (select 1 from TB_SCORE where STUDENT_ID = @maSV and SCORE is not null )
	begin
		print 'Phải delete contraint of sv before' 
		return -2;
	end

	delete from TB_STUDENTS where STUDENT_ID = @maSV
	return 0;
end
--drop proc DeleteSV
go
-- cập nhật sv
create proc UpdateSV(@maSV char(20), @nameSV nvarchar(50), @gender varchar(10), @email nvarchar(225), @phone nvarchar(12), @address nvarchar(225),@ngayS date, @class nvarchar(20))
as
begin
	if not exists (select 1 from TB_STUDENTS where STUDENT_ID = @maSV)
	begin
		print 'SV not exited!';
		return -1;
	end
	if exists (select 1 from TB_STUDENTS where STUDENT_ID = @maSV and FULLNAME = @nameSV and GENDER = @gender and EMAIL = @email and PHONE = @phone and ADDRRES = @address and BIRTH_OF_DATE = @ngayS and CLASS_NAME = @class)
	begin
		print 'Bạn chưa thay đổi gì!'
		return -2;
	end
	update TB_STUDENTS
	set FULLNAME = @nameSV , GENDER = @gender, EMAIL = @email,PHONE = @phone , ADDRRES = @address, BIRTH_OF_DATE = @ngayS, CLASS_NAME = @class
	where STUDENT_ID = @maSV
end
--drop proc UpdateSV
go
---------------------------- TB_CLASSS
-- update
create proc UpdateClass(@CLASS_ID char(20), @SCHEDELE nvarchar(10), @TEACHING_SESSION nvarchar(50))
as
begin
	if not exists (select 1 from TB_CLASS WHERE CLASS_ID = @CLASS_ID)
	begin
		return -1;	
	end

	update TB_CLASS
	set SCHEDULE = @SCHEDELE, TEACHING_SESSION = @TEACHING_SESSION
	where CLASS_ID = @CLASS_ID
end
go
-- Print
create proc PrintClass
as
begin
	SELECT class.CLASS_ID, 
		mh.NAME_ST,
       class.SCHEDULE, 
       class.TEACHING_SESSION
FROM TB_CLASS class
JOIN TB_SUBJECT mh ON mh.SUBJECT_ID = class.SUBJECT_ID
WHERE class.CLASS_ID IN ('CL01', 'CL02', 'CL03'); 
-- drop proc GetClassID
end
go
create proc GetClassID
as
begin
	select CLASS_ID from TB_CLASS WHERE CLASS_ID IN ('CL01', 'CL02', 'CL03'); 
end
go
---------------------------------------------------------------------- QLDD

 -------------------------------------------------------------------- HỌC PHÍ
 --select * from TB_TUITIONFESS
create proc PrintHP
AS
BEGIN
	select distinct
		hp.TUITIONFEEID_ID, 
		sv.STUDENT_ID, 
		sv.FULLNAME, 
		hp.SEMESTER, 
		hp.ACADEMICYEAR, 
		hp.CREDITUNITPRICE, 
		hp.TOTALTUITION,
		hp.PAYMENTDATE, 
		hp.STATUSHP, 
		sv.CLASS_NAME
	from TB_STUDENTS sv
	JOIN TB_TUITIONFESS hp 
		on sv.STUDENT_ID = hp.STUDENT_ID
	JOIN TB_SUBJECT mh 
		on hp.SUBJECT_ID = mh.SUBJECT_ID
	where sv.CLASS_NAME = N'CD23TT9'
end
-- drop proc PrintHP 
go
--- cập nhật học phí
create proc UpdateHP(@maSV char(20), @dateSubmit date, @totalHP float , @status nvarchar(50))
as
begin
	if not exists (select 1 
	from TB_STUDENTS sv
		JOIN TB_TUITIONFESS hp 
			on sv.STUDENT_ID = hp.STUDENT_ID
		JOIN TB_SUBJECT mh 
			on hp.SUBJECT_ID = mh.SUBJECT_ID
		where sv.CLASS_NAME = N'CD23TT9' AND sv.STUDENT_ID = @maSV)
	begin
		return -1;
	end

	update TB_TUITIONFESS
		set PAYMENTDATE = @dateSubmit, TOTALTUITION = @totalHP, STATUSHP = @status
		from TB_STUDENTS sv
		JOIN TB_TUITIONFESS hp 
			on sv.STUDENT_ID = hp.STUDENT_ID
		JOIN TB_SUBJECT mh 
			on hp.SUBJECT_ID = mh.SUBJECT_ID
		where sv.CLASS_NAME = N'CD23TT9' AND sv.STUDENT_ID = @maSV

	return 0;
end
--DROP PROC UpdateHP
go
------- sv chưa đóng
create proc GetAllSVChuaDongHP
as
begin
		select distinct
		hp.TUITIONFEEID_ID, 
		sv.STUDENT_ID, 
		sv.FULLNAME, 
		hp.SEMESTER, 
		hp.ACADEMICYEAR, 
		hp.CREDITUNITPRICE, 
		hp.TOTALTUITION,
		hp.PAYMENTDATE, 
		hp.STATUSHP, 
		sv.CLASS_NAME
	from TB_STUDENTS sv
	JOIN TB_TUITIONFESS hp 
		on sv.STUDENT_ID = hp.STUDENT_ID
	JOIN TB_SUBJECT mh 
		on hp.SUBJECT_ID = mh.SUBJECT_ID
	where sv.STUDENT_ID = hp.STUDENT_ID  AND hp.STATUSHP = N'CHƯA ĐÓNG' AND sv.CLASS_NAME = N'CD23TT9'
end
go
------- sv đã đóng
create proc GetAllSVDaDongHP
as
begin
	select distinct
	hp.TUITIONFEEID_ID, 
	sv.STUDENT_ID, 
	sv.FULLNAME, 
	hp.SEMESTER, 
	hp.ACADEMICYEAR, 
	hp.CREDITUNITPRICE, 
	hp.TOTALTUITION,
	hp.PAYMENTDATE, 
	hp.STATUSHP, 
	sv.CLASS_NAME
from TB_STUDENTS sv
JOIN TB_TUITIONFESS hp 
	on sv.STUDENT_ID = hp.STUDENT_ID
JOIN TB_SUBJECT mh 
	on hp.SUBJECT_ID = mh.SUBJECT_ID
where sv.STUDENT_ID = hp.STUDENT_ID  AND hp.STATUSHP = N'ĐÃ ĐÓNG' AND sv.CLASS_NAME = N'CD23TT9'
end
go
---------------- TotalHP
create proc TotalHP(@maSV char(20))
as
begin
	select SUM(hp.CREDITUNITPRICE * mh.SOTC) AS 'TOTALHP' 
	from TB_SUBJECT mh join TB_MAJOR nganh on mh.MAJOR_ID = nganh.MAJOR_ID 
	join TB_STUDENTS sv on sv.MAJOR_ID = nganh.MAJOR_ID JOIN TB_TUITIONFESS 
	hp on hp.STUDENT_ID = sv.STUDENT_ID
	where sv.STUDENT_ID = @maSV
end
 ------------------------------------------- end Học Phí -----------------------------------------------------------------------
go
create proc FindSVMaID(@maSV char(20), @class_name nvarchar(20))
as
begin
	if	not exists (select 1 from TB_TUITIONFESS where STUDENT_ID = @maSV AND CLASS_NAME = @class_name)
	begin
		print '1'
		return -1;
	end

	select distinct
		hp.TUITIONFEEID_ID, 
		sv.STUDENT_ID, 
		sv.FULLNAME, 
		hp.SEMESTER, 
		hp.ACADEMICYEAR, 
		hp.CREDITUNITPRICE, 
		hp.PAYMENTDATE, 
		hp.STATUSHP, 
		sv.CLASS_NAME
	from TB_STUDENTS sv
	JOIN TB_TUITIONFESS hp 
		on sv.STUDENT_ID = hp.STUDENT_ID
	JOIN TB_SUBJECT mh 
		on hp.SUBJECT_ID = mh.SUBJECT_ID where sv.STUDENT_ID = @maSV  and sv.CLASS_NAME = @class_name
end
-- drop proc FindSVMaID
-- EXEC FindSVMaID '232TT2984', 'CD23TT9'
go

CREATE PROC FindSVByName(@namSV NVARCHAR(50))
AS
BEGIN
  select distinct
		hp.TUITIONFEEID_ID, 
		sv.STUDENT_ID, 
		sv.FULLNAME, 
		hp.SEMESTER, 
		hp.ACADEMICYEAR, 
		hp.CREDITUNITPRICE, 
		hp.PAYMENTDATE, 
		hp.STATUSHP, 
		sv.CLASS_NAME
	from TB_STUDENTS sv
	JOIN TB_TUITIONFESS hp 
		on sv.STUDENT_ID = hp.STUDENT_ID
	JOIN TB_SUBJECT mh 
		on hp.SUBJECT_ID = mh.SUBJECT_ID
    where LTRIM(RTRIM(sv.FULLNAME)) LIKE N'%' + @namSV + '%' 
          AND sv.CLASS_NAME = N'CD23TT9'
END

-- drop proc FindSVByName
--EXEC FindSVByName N'Trần'
go

-- proc sort từ thứ 2 -> 7
create proc PrintSchedule
as
begin
	SELECT l.DAY_OF_WEEK, l.START_TIME, l.END_TIME, mh.NAME_ST
	FROM TB_SCHEDULE l
	JOIN TB_SUBJECT mh ON l.SUBJECT_ID = mh.SUBJECT_ID
	JOIN TB_STUDENTS sv ON l.STUDENT_ID = sv.STUDENT_ID
	WHERE sv.STUDENT_ID = '23211TT2984'
	AND l.DAY_OF_WEEK IN (N'Thứ Hai', N'Thứ Ba', N'Thứ Tư', N'Thứ Năm', N'Thứ Sáu', N'Thứ Bảy')
ORDER BY
    CASE l.DAY_OF_WEEK
        WHEN N'Thứ Hai' THEN 1
        WHEN N'Thứ Ba' THEN 2
        WHEN N'Thứ Tư' THEN 3
        WHEN N'Thứ Năm' THEN 4
        WHEN N'Thứ Sáu' THEN 5
        WHEN N'Thứ Bảy' THEN 6
        ELSE 7 -- Chủ Nhật (nếu có)
    end
end

-- drop proc PrintSchedule
--exec PrintSchedule
go

-- PRINT SV CÓ MÃ '23211TT2984'
create proc PrintSocre
as
begin
	select mh.NAME_ST AS 'MÔN HỌC' , diem.SCORE
	from TB_SCORE diem join TB_STUDENTS sv on diem.STUDENT_ID = sv.STUDENT_ID join TB_SUBJECT mh on diem.SUBJECT_ID = mh.SUBJECT_ID
	where sv.STUDENT_ID = '23211TT2984' and diem.SUBJECT_ID = mh.SUBJECT_ID
end

select * from TB_SUBJECT
-- drop proc PrintSocre
-- exec PrintSocre
go
-- print sinh viên vi phạm
create proc PrintViPham
as
begin
	select vp.VIOLATESV_ID, sv.STUDENT_ID, sv.FULLNAME, sv.GENDER, vp.VIOLATION_NAME, sv.CLASS_NAME 
	from TB_VIOLATESV vp join TB_STUDENTS sv on vp.STUDENT_ID = sv.STUDENT_ID  where CLASS_NAME = N'CD23TT9'
end
-- drop proc PrintViPham
go
create proc GetAllMonHocByCD23TT9
as
begin 
	select distinct mh.SUBJECT_ID, mh.NAME_ST
	from TB_VIOLATESV vv,  TB_STUDENTS sv, TB_SUBJECT mh
	where vv.STUDENT_ID	= sv.STUDENT_ID AND mh.SUBJECT_ID = vv.SUBJECT_ID  AND sv.CLASS_NAME = N'CD23TT9'
end

-- drop proc GetAllMonHocByCD23TT9
go
create proc AddViolation(@mavp char(20),@violation_name nvarchar(100),@masv char(20), @mamh char(20))
as
begin
	if exists (select 1 from TB_VIOLATESV where VIOLATESV_ID = @mavp)
	begin
		return -1;
	end

	insert into TB_VIOLATESV values(@mavp, @violation_name,@masv, @mamh)
	return 0
end
go
create proc DSSVCamThi
as
begin
	SELECT sv.STUDENT_ID, sv.FULLNAME,  COUNT(vv.VIOLATION_NAME) AS 'Vi phạm trên >= 3 lỗi'
	FROM TB_VIOLATESV vv
	JOIN TB_STUDENTS sv ON sv.STUDENT_ID = vv.STUDENT_ID
	WHERE sv.CLASS_NAME = N'CD23TT9' 
	GROUP BY sv.STUDENT_ID, sv.FULLNAME
	HAVING COUNT(vv.VIOLATION_NAME) >= 3;
end

--drop proc DSSVCamThi
go
create proc DSSVChuaViPham
as
begin
	SELECT sv.STUDENT_ID, sv.FULLNAME
	FROM TB_STUDENTS sv
	LEFT JOIN TB_VIOLATESV vv ON sv.STUDENT_ID = vv.STUDENT_ID
	WHERE sv.CLASS_NAME = N'CD23TT9'
	AND vv.VIOLATESV_ID IS NULL;
end
go
-- chi tiết sv vi phạm
create proc DetailViPham(@maSV char(20))
as
begin
	select vp.VIOLATESV_ID, sv.STUDENT_ID, sv.FULLNAME, sv.GENDER, vp.VIOLATION_NAME, sv.CLASS_NAME 
	from TB_VIOLATESV vp join TB_STUDENTS sv on vp.STUDENT_ID = sv.STUDENT_ID
	where CLASS_NAME = N'CD23TT9' AND sv.STUDENT_ID = @maSV
end

--drop proc DetailViPham
----------------------------------------------------------------------------  End GV vi phạm --------------------
go

-- get ra tên của các sinh viên lớp cdtt9
create proc PrintSVByCD23TT9
as
begin
	select distinct * from TB_STUDENTS where CLASS_NAME = N'CD23TT9' 
end
-- drop proc PrintSVByCD23TT9
go
create proc PrintViPhamByIDSV
as
begin
	select vp.VIOLATESV_ID, mh.NAME_ST, vp.VIOLATION_NAME
	from TB_VIOLATESV vp join TB_STUDENTS sv on vp.STUDENT_ID = sv.STUDENT_ID join TB_SUBJECT mh on vp.SUBJECT_ID = mh.SUBJECT_ID
	where  sv.STUDENT_ID = N'23211TT2984'
end

--select * from  TB_STUDENTS
--select * from TB_VIOLATESV
--exec PrintViPhamByIDSV
-- drop proc PrintViPhamByIDSV
go
create proc PrintDangKyHP
as
begin
	
SELECT 
    ROW_NUMBER() OVER (ORDER BY mh.SUBJECT_ID) AS STT, 
    mh.SUBJECT_ID,
    mh.NAME_ST,
    mh.SOTC,
    MAX(dkhp.TYPESUBJECT) AS TYPESUBJECT  -- Nếu muốn lấy 1 loại môn học đại diện
FROM 
    TB_SUBJECT mh
JOIN 
    TB_MAJOR nganh ON nganh.MAJOR_ID = mh.MAJOR_ID
JOIN 
    TB_FACULTY khoa ON nganh.FACULTY_ID = khoa.FACULTY_ID
LEFT JOIN 
    TB_INVOICE dkhp ON mh.SUBJECT_ID = dkhp.SUBJECT_ID
WHERE 
    khoa.FACULTY_ID = 'FY01'
GROUP BY 
    mh.SUBJECT_ID, mh.NAME_ST, mh.SOTC;
end

GO
------------------------------------------------------------------------------------------------------------------
--------------------------------------------CẢ -------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------
-- lấy dữ liệu ngành 
go
create  proc GetAllKhoa
as 
select * from TB_FACULTY
-- thêm ngành 
go 
create proc themnganh(@manganh char(20) , @tennganh nvarchar(100),@magv char(20) )
as
insert into TB_MAJOR 
values (@manganh , @tennganh,@magv)

-- XÓA NGÀNH 
go 
create proc xoanganh(@manganh char(20))
as
delete 
from TB_MAJOR where MAJOR_ID = @manganh

go
create proc timnganhtheoma(@manganh char(20))
as
select * from TB_MAJOR 
where MAJOR_ID like '%'+@manganh+'%'

go 
-- lấy dữ liệu khoa
create proc laydlkhoa
as
select * from TB_FACULTY

--thêm dữ liệu kHOA
GO 
create proc themdlkhoa (@makhoa char(20),@tenkhoa nvarchar(100))
as
insert into TB_FACULTY 
values (@makhoa,@tenkhoa)

go
-- xóa dữ liêuj khoa
create proc xoadlkhoa(@makhoa char(20))
as
delete 
from TB_FACULTY
where FACULTY_ID = @makhoa

-- sửa dữ liệu khoa
go
create proc suadlkhoa (@makhoa char(20),@tenkhoa nvarchar(100))
as
update TB_FACULTY
set NAME_FY = @tenkhoa
where FACULTY_ID = @makhoa

-- tìm khoa
go
create proc timkhoa(@makhoa char(20))
as
select *
from TB_FACULTY 
where FACULTY_ID like '%'+ @makhoa +'%'

-- tổng số lượng  sinh viên của các khoa
go
create proc totalsinhvien 
as
select TB_MAJOR.MAJOR_NAME as 'Tên ngành', COUNT(*) as 'tổng sinh viên'
from TB_STUDENTS
join TB_MAJOR on TB_MAJOR.MAJOR_ID = TB_STUDENTS.MAJOR_ID
group by TB_MAJOR.MAJOR_NAME

go
--các sinh viên đậu
create proc cacsinhviendau 
as 
select COUNT(*) as 'số lượng sinh viên đậu'
from TB_STUDENTS 
join TB_SCORE on TB_SCORE.STUDENT_ID = TB_STUDENTS.STUDENT_ID
where TB_SCORE.SCORE >= 5

-- các sinh viên không đậu
go
create proc cacsinhkoviendau 
as 
select COUNT(*) as 'số lượng sinh không viên đậu'
from TB_STUDENTS 
join TB_SCORE on TB_SCORE.STUDENT_ID = TB_STUDENTS.STUDENT_ID
where TB_SCORE.SCORE < 5

go
-- tổng các sinh viên nữ 
create proc tongsinhviennu 
as
select COUNT(*) as 'tổng sinh viên nữ trong  trường'
from TB_STUDENTS 
where GENDER = N'NỮ'
go
-- sinh vien  nam
create proc tongsinhviennam
as
select COUNT(*) as 'tổng sinh viên nam trong  trường'
from TB_STUDENTS 
where GENDER = N'NAM'

go
create proc PrintNganh
as
begin
	select * from TB_MAJOR
end
go
---------------------------------------------------------------------------------------------------------------------
create proc PrintScore
as
begin
	select distinct diem.SUBJECT_ID, diem.STUDENT_ID, sv.FULLNAME, diem.SCORE, sv.CLASS_NAME
	from TB_SCORE diem,TB_STUDENTS sv, TB_SUBJECT mh
	WHERE diem.STUDENT_ID = sv.STUDENT_ID AND  sv.CLASS_NAME = N'CD23TT9' 
end
go
-- Thêm môn học của đào tạo
create proc AddMh(@maMh char(20), @tenMH nvarchar(50), @soTC int ,@soBuoi int, @dgtc float, @maNganh char(20), @maGV char(20))
as
begin
	if exists (select 1 from TB_SUBJECT where SUBJECT_ID = @maMh)
	begin
		return -1;
	end

	insert into TB_SUBJECT values(@maMh, @tenMH, @soTC, @soBuoi,@dgtc, @maNganh, @maGV)
	return 0;
end
-- drop proc AddMh
go

create proc DeleteMh(@maMh char(20))
as
begin
	if not exists(select 1 from TB_SUBJECT where SUBJECT_ID = @maMh)
	begin
		return -1;
	end

	delete from TB_SUBJECT where @maMh = SUBJECT_ID
	return 0
end
-- drop proc DeleteMh
go
----------------------------------------------------------------- GV_DIEM
-- laay ra sinh vieen trong lop cd23tt9
create proc GetAllSVGVDIEM
as
begin
	select sv.FULLNAME, sv.STUDENT_ID  from TB_STUDENTS sv 
	where sv.CLASS_NAME = N'CD23TT9' 
end
go
-- DROP PROC GetAllMHGVDIEM
go
create proc FindSVGV(@maSV char(20))
as
begin
	select * from TB_SCORE diem, TB_STUDENTS sv 
	where sv.STUDENT_ID = diem.STUDENT_ID and sv.CLASS_NAME = N'CD23TT9' and sv.STUDENT_ID = @maSV
	return 0
end
GO
---- CHI TIẾT ĐIỂM TỪNG SINH VIÊN
create proc GetDetailSV(@maSV char(20))
as
begin
	select diem.STUDENT_ID, mh.NAME_ST, sv.FULLNAME, diem.SCORE
	from TB_SCORE diem join TB_SUBJECT mh on diem.SUBJECT_ID = mh.SUBJECT_ID join TB_STUDENTS sv on diem.STUDENT_ID = SV.STUDENT_ID
	where diem.STUDENT_ID = @maSV AND sv.CLASS_NAME = N'CD23TT9'
end
GO
---- Điểm trung binhg
create proc GetDTBSV(@maSV char(20))
as
begin
	select diem.STUDENT_ID, sv.FULLNAME, ROUND(AVG(diem.SCORE),1) AS 'DTB'
	from TB_SCORE diem join TB_SUBJECT mh on diem.SUBJECT_ID = mh.SUBJECT_ID join TB_STUDENTS sv on diem.STUDENT_ID = sv.STUDENT_ID
	where diem.STUDENT_ID = @maSV AND sv.CLASS_NAME = N'CD23TT9'
	group by diem.STUDENT_ID, sv.FULLNAME
end
GO
-- sort sv theo điểm
create proc GetSortSV
as
begin
	select sv.STUDENT_ID, sv.FULLNAME, ROUND(AVG(diem.SCORE),1) AS 'DTB'
	from TB_SCORE diem join TB_STUDENTS sv on sv.STUDENT_ID = diem.STUDENT_ID
	where sv.CLASS_NAME = N'CD23TT9' 
	group by  sv.STUDENT_ID, sv.FULLNAME
	order by ROUND(AVG(diem.SCORE),1) desc
end
GO
------------------------------------------------------------------------------CA
--các sinh viên đậu
create proc cacsinhviendauCA
as 
select COUNT(*) as 'số lượng sinh viên đậu'
from TB_STUDENTS 
join TB_SCORE on TB_SCORE.STUDENT_ID = TB_STUDENTS.STUDENT_ID
where TB_SCORE.SCORE >= 5

-- các sinh viên không đậu
go
create proc cacsinhkoviendauCA
as 
select COUNT(*) as 'số lượng sinh không viên đậu'
from TB_STUDENTS 
join TB_SCORE on TB_SCORE.STUDENT_ID = TB_STUDENTS.STUDENT_ID
where TB_SCORE.SCORE < 5

go
-- tổng các sinh viên nữ 
create proc tongsinhviennuCA 
as
select COUNT(*) as 'tổng sinh viên nữ trong  trường'
from TB_STUDENTS 
where GENDER = N'NỮ'
go
-- sinh vien  nam
create proc tongsinhviennamCA
as
select COUNT(*) as 'tổng sinh viên nam trong  trường'
from TB_STUDENTS 
where GENDER = N'NAM'

go 
-- thong  tin sinh viên
create proc thongtinsinhvienCA
as
select * from TB_STUDENTS
where STUDENT_ID = '23211TT1404'

-- cac sinh viên đậu trong lớp
go
create proc sinhviendauCA
as
select TB_STUDENTS.FULLNAME , TB_SCORE.SCORE
from TB_STUDENTS , TB_SCORE
where TB_STUDENTS.STUDENT_ID = TB_SCORE.STUDENT_ID and 
TB_STUDENTS.CLASS_NAME = N'CD23TT9' and TB_SCORE.SCORE >=5

-- sinh viên không đậu
go
create proc sinhvienkodauCA
as
select TB_STUDENTS.FULLNAME , TB_SCORE.SCORE
from TB_STUDENTS , TB_SCORE
where TB_STUDENTS.STUDENT_ID = TB_SCORE.STUDENT_ID and 
TB_STUDENTS.CLASS_NAME = N'CD23TT9' and TB_SCORE.SCORE <5

go 
-- sinh viên nam trong lớp 
create proc sinhviennamCA
as
select TB_STUDENTS.FULLNAME , TB_SCORE.SCORE,TB_STUDENTS.GENDER
from TB_STUDENTS , TB_SCORE
where TB_STUDENTS.STUDENT_ID = TB_SCORE.STUDENT_ID and 
TB_STUDENTS.CLASS_NAME = N'CD23TT9' and TB_STUDENTS.GENDER = N'NAM'


go
create proc sinhviennuCA
as
select TB_STUDENTS.FULLNAME , TB_SCORE.SCORE,TB_STUDENTS.GENDER
from TB_STUDENTS , TB_SCORE
where TB_STUDENTS.STUDENT_ID = TB_SCORE.STUDENT_ID and 
TB_STUDENTS.CLASS_NAME = N'CD23TT9' and TB_STUDENTS.GENDER = N'NỮ'

go 
-- tìm sinh viên trong lớp
create proc timsvtronglopCA (@tensv nvarchar(100))
as
select TB_STUDENTS.FULLNAME , TB_SCORE.SCORE,TB_STUDENTS.GENDER
from TB_STUDENTS , TB_SCORE
where TB_STUDENTS.STUDENT_ID = TB_SCORE.STUDENT_ID and 
TB_STUDENTS.CLASS_NAME = N'CD23TT9' and TB_STUDENTS.FULLNAME like '%'+ @tensv+'%'
go 
create proc sinhvientronglopCA
as
select TB_STUDENTS.FULLNAME , TB_SCORE.SCORE
from TB_STUDENTS , TB_SCORE
where TB_STUDENTS.STUDENT_ID = TB_SCORE.STUDENT_ID and 
TB_STUDENTS.CLASS_NAME = N'CD23TT9'
------------------------------------------------------------------------------------
go
create proc tongsv
as
select COUNT( TB_STUDENTS.STUDENT_ID) as 'tổng sinh viên trong trường'
from TB_STUDENTS 
go 
create proc timsvtheoID (@masv char (20))
as
select *
from TB_STUDENTS 
where TB_STUDENTS.STUDENT_ID = @masv
GO
create proc UpdateMh(@maMh char(20), @tenMH nvarchar(50), @soTC int, @soBuoi int, @maGV char(20))
as
begin
	update TB_SUBJECT
	set NAME_ST = @tenMH, SOTC = @soTC, SOTIET =  @soBuoi, INSTRUCTOR_ID = @maGV
	where SUBJECT_ID = @maMh
end
go
create proc FindMHCuoi(@maMH char(20))
as
begin
	select mh.SUBJECT_ID, mh.NAME_ST, mh.SOTC,mh.SOTIET, mh.DGTC,  gv.FULLNAME, nganh.MAJOR_NAME
	from TB_SUBJECT mh, TB_MAJOR nganh, TB_INSTRUCTORS gv
	where mh.MAJOR_ID = nganh.MAJOR_ID AND mh.INSTRUCTOR_ID = gv.INSTRUCTOR_ID AND mh.SUBJECT_ID like '%' + @maMH +'%'
end
go
create proc XoaSVCuoi(@maSV char(20))
as
begin
	delete from TB_STUDENTS where STUDENT_ID = @maSV
end
go
create proc FindSVCuoi(@maSV char(20))
as
begin
	select * from TB_STUDENTS where STUDENT_ID = @maSV
end