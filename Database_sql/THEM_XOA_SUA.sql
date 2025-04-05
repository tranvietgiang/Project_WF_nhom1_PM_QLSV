-- ADD , DELETE , EDIT, UPDATE CÁC BẢNG
USE PROJECT_QLSV
GO
SET DATEFORMAT DMY
GO
-- Thêm dữ liệu vào bảng TB_FACULATY
INSERT INTO TB_FACULTY(FACULTY_ID, NAME_FY)
VALUES 
    ('FY01', N'Khoa Công nghệ thông tin'),
    ('FY02', N'Khoa Quản trị kinh doanh'),
    ('FY03', N'Khoa Kỹ thuật điện tử'),
    ('FY04', N'Khoa Môi trường'),
    ('FY05', N'Khoa Nghệ thuật');
GO

-- Thêm dữ liệu vào bảng TB_MAJOR
INSERT INTO TB_MAJOR (MAJOR_ID, MAJOR_NAME, FACULTY_ID)
VALUES 
    ('MJ01', N'Khoa học máy tính', 'FY01'),
    ('MJ02', N'Hệ thống thông tin', 'FY01'),
    ('MJ03', N'Quản trị kinh doanh', 'FY02'),
    ('MJ04', N'Quản lý tài chính', 'FY02'),
    ('MJ05', N'Thiết kế đồ họa', 'FY05');
GO
-- Thêm dữ liệu vào bảng TB_INSTRUCTORS
INSERT INTO TB_INSTRUCTORS (INSTRUCTOR_ID, FULLNAME, EMAIL, PHONE, FACULTY_ID)
VALUES 
    ('INST01', N'Lê Thọ', N'an.nguyen@university.edu', '0123456789', 'FY01'),
    ('INST02', N'Lê Thị Bình', N'binh.le@university.edu', '0987654321', 'FY01'),
    ('INST03', N'Trần Văn Cường', N'cuong.tran@university.edu', '0112233445', 'FY02'),
    ('INST04', N'Phạm Minh Châu', N'chau.pham@university.edu', '0223344556', 'FY03'),
    ('INST05', N'Vũ Hoàng Hải', N'hai.vu@university.edu', '0334455667', 'FY05');
GO
INSERT INTO TB_SUBJECT (SUBJECT_ID, NAME_ST, SOTC, SOTIET, DGTC, MAJOR_ID, INSTRUCTOR_ID)
VALUES
    ('SUBJ01', N'Toán Cao Cấp', 4, 60, 3000, 'MJ01', 'INST01'),
    ('SUBJ02', N'Lập Trình Cơ Bản', 4, 60, 3000, 'MJ02', 'INST02'),
    ('SUBJ03', N'Anh Văn Chuyên Ngành', 4, 60, 3000, 'MJ03', 'INST03'),
    ('SUBJ04', N'Mạng Máy Tính', 3, 45, 3000, 'MJ01', 'INST01'),
    ('SUBJ05', N'Quản Trị Dự Án', 3, 45, 3000, 'MJ02', 'INST02'),
    ('SUBJ06', N'Tin Học Đại Cương', 3, 45, 3000, 'MJ03', 'INST03'),
    ('SUBJ07', N'Kỹ Thuật Lập Trình', 3, 45, 3000, 'MJ01', 'INST01'),
    ('SUBJ08', N'Kinh Tế Học', 3, 45, 3000, 'MJ02', 'INST02'),
    ('SUBJ09', N'Phân Tích Dữ Liệu', 3, 45, 3000, 'MJ03', 'INST03'),
    ('SUBJ10', N'Thương Mại Điện Tử', 3, 45, 3000, 'MJ01', 'INST01'),
    ('SUBJ11', N'Cấu trúc dữ liệu và giải thuật', 4, 60, 3000, 'MJ01', 'INST01'),
    ('SUBJ12', N'Hệ điều hành', 3, 45, 3000, 'MJ01', 'INST02'),
    ('SUBJ13', N'Lập trình hướng đối tượng', 3, 45, 3000, 'MJ01', 'INST01'),
    ('SUBJ14', N'Cơ sở dữ liệu', 4, 60, 3000, 'MJ02', 'INST02'),
    ('SUBJ15', N'Mạng máy tính nâng cao', 3, 45, 3000, 'MJ01', 'INST01'),
    ('SUBJ16', N'Lập trình Web', 3, 45, 3000, 'MJ02', 'INST02'),
    ('SUBJ17', N'Thương mại điện tử nâng cao', 3, 45, 3000, 'MJ01', 'INST01'),
    ('SUBJ18', N'An ninh mạng', 3, 45, 3000, 'MJ02', 'INST02');

GO
-- Thêm dữ liệu mẫu cho bảng TB_CLASS
INSERT INTO TB_CLASS (CLASS_ID, CLASS_NAME, FACULTY_ID, MAJOR_ID, TEACHING_SESSION, SCHEDULE, SUBJECT_ID)
VALUES 
    ('CL01', N'CD23TT9', 'FY01', 'MJ01', N'SÁNG 7h', N'THỨ 2', 'SUBJ01'),
    ('CL02', N'CD23TT1', 'FY01', 'MJ02', N'SÁNG 7h', N'THỨ 3', 'SUBJ02'),
    ('CL03', N'CD23TT10', 'FY02', 'MJ03', N'SÁNG 7h', N'THỨ 5', 'SUBJ03'),
    ('CL04', N'CD23TT2', 'FY01', 'MJ01', N'SÁNG 8h', N'THỨ 2', 'SUBJ04'),
    ('CL05', N'CD23TT3', 'FY01', 'MJ02', N'SÁNG 8h', N'THỨ 3', 'SUBJ05'),
    ('CL06', N'CD23TT4', 'FY02', 'MJ03', N'SÁNG 8h', N'THỨ 4', 'SUBJ06'),
    ('CL07', N'CD23TT5', 'FY01', 'MJ01', N'SÁNG 9h', N'THỨ 2', 'SUBJ07'),
    ('CL08', N'CD23TT6', 'FY02', 'MJ02', N'SÁNG 9h', N'THỨ 3', 'SUBJ08'),
    ('CL09', N'CD23TT7', 'FY01', 'MJ03', N'SÁNG 10h', N'THỨ 4', 'SUBJ09'),
    ('CL10', N'CD23TT8', 'FY02', 'MJ01', N'SÁNG 10h', N'THỨ 5', 'SUBJ10');
GO
-- SINH VIÊN
INSERT INTO TB_STUDENTS(STUDENT_ID, FULLNAME, GENDER, EMAIL, PHONE, ADDRRES, BIRTH_OF_DATE, FACULTY_ID, MAJOR_ID, CLASS_NAME)
VALUES('23211TT2984', N'Trần Viết Giang', N'NAM', N'nguyenvana@example.com', '0123456789', N'123 Đường ABC, Quận 1', '2000-02-15', 'FY01', 'MJ01','CD23TT10'),
    ('23211TT1404', N'Phạm Cả', N'NAM', N'lethib@example.com', '0987654321', N'456 Đường DEF, Quận 2', '1999-03-20', 'FY02', 'MJ02','CD23TT9'),
    ('23211TT1234', N'Trần Văn Cong', N'NAM', N'tranvanc@example.com', '0112233445', N'789 Đường GHI, Quận 3', '2001-08-10', 'FY03', 'MJ03','CD23TT10'),
    ('23211TT5678', N'Nguyễn Thị Da', N'NỮ', 'nguyentid@example.com', '0987654321', N'123 Đường XYZ, Quận 4', '2002-05-12', 'FY01', 'MJ01','CD23TT9'),
    ('23211TT9012', N'Trần Văn Em', N'NAM', 'tranvane@example.com', '0123456789', N'456 Đường PQR, Quận 5', '2001-11-25', 'FY02', 'MJ02','CD23TT10'),
    ('23211TT3456', N'Lê Thị Floan', N'NỮ', 'lethiF@example.com', '0987654321', '789 Đường STU, Quận 6', '2000-09-08', 'FY03', 'MJ03','CD23TT10'),
    ('23211TT7890', N'Nguyễn Văn Giang', N'NAM', 'nguyenvang@example.com', '0123456789', N'123 Đường VXY, Quận 7', '2003-01-15', 'FY01', 'MJ01','CD23TT10'),
    ('23211TT1357', N'Lê Thị Hậu', N'NỮ', 'lethiH@example.com', '0987654321', N'456 Đường WZA, Quận 8', '2002-07-20', 'FY02', 'MJ02','CD23TT9'),
    ('23211TT9876', N'Trần Văn Inam', N'NAM', 'tranvani@example.com', '0112233445', '789 Đường BCD, Quận 9', '2001-12-10', 'FY03', 'MJ03','CD23TT9'),
    ('23211TT5432', N'Nguyễn Thị Joan', N'NỮ', 'nguyentij@example.com', '0987654321', '123 Đường EFG, Quận 10', '2002-04-12', 'FY01', 'MJ01','CD23TT9'),
    ('23211TT1111', N'Nguyễn Văn Khoa', N'NAM', 'nguyenvank@example.com', '0111111111', N'123 Đường ABC, Quận 1', '2003-03-15', 'FY01', 'MJ01','CD23TT10'),
    ('23211TT2222', N'Lê Thị Ly', N'NỮ', 'lethiL@example.com', '0222222222', N'456 Đường DEF, Quận 2', '2002-04-20', 'FY02', 'MJ02','CD23TT9'),
    ('23211TT3333', N'Trần Văn M', N'NAM', 'tranvanM@example.com', '0333333333', N'789 Đường GHI, Quận 3', '2001-09-10', 'FY03', 'MJ03','CD23TT10'),
    ('23211TT4444', N'Nguyễn Thị Ngân', N'NỮ', 'nguyentin@example.com', '0444444444', N'123 Đường XYZ, Quận 4', '2002-06-12', 'FY01', 'MJ01','CD23TT9'),
    ('23211TT5555', N'Trần Văn Hậu', N'NAM', 'tranvano@example.com', '0555555555', N'456 Đường PQR, Quận 5', '2001-12-25', 'FY02', 'MJ02','CD23TT9')
GO

--Thêm dữ liệu mẫu cho bảng TB_SCORE
INSERT INTO TB_SCORE (SUBJECT_ID, STUDENT_ID, SCORE)
VALUES 
	('SUBJ01', '23211TT2984', 8.5),
	('SUBJ02', '23211TT2984', 8), 
	('SUBJ03', '23211TT2984', 9), 
	('SUBJ04', '23211TT2984', 8.7), 
	('SUBJ05', '23211TT2984', 8.5), 
	('SUBJ06', '23211TT2984', 8.2), 
    ('SUBJ02', '23211TT1404', 7.0),    
    ('SUBJ03', '23211TT1234', 9.0),
    ('SUBJ01', '23211TT5678', 7.5),   
    ('SUBJ02', '23211TT9012', 8.0),    
    ('SUBJ03', '23211TT3456', 6.5),
    ('SUBJ01', '23211TT7890', 9.2),   
    ('SUBJ02', '23211TT1357', 7.8),    
    ('SUBJ03', '23211TT9876', 8.0),
    ('SUBJ01', '23211TT5432', 6.0),   
    ('SUBJ02', '23211TT1111', 8.3),    
    ('SUBJ03', '23211TT2222', 7.9),
    ('SUBJ01', '23211TT3333', 7.4),
    ('SUBJ02', '23211TT4444', 8.1),
    ('SUBJ03', '23211TT5555', 9.5);

--select * from TB_SCORE
GO

INSERT INTO TB_SCHEDULE (STUDENT_ID, DAY_OF_WEEK, START_TIME, END_TIME, SUBJECT_ID)
VALUES 
    ('23211TT2984', N'Thứ Hai', N'07:00', N'11:45', 'SUBJ01'),
    ('23211TT2984', N'Thứ Ba', N'10:00', N'12:00', 'SUBJ02'),
    ('23211TT2984', N'Thứ Tư', N'12:00', N'17:00', 'SUBJ03'),
    ('23211TT2984', N'Thứ Năm', N'10:00', N'12:00', 'SUBJ04'),
    ('23211TT2984', N'Thứ Sáu', N'13:00', N'17:00', 'SUBJ05'),
    ('23211TT2984', N'Thứ Bảy', N'13:00', N'17:45', 'SUBJ06');
GO

-- Thêm dữ liệu vào bảng TB_INVOICE (Hóa đơn đăng ký)
INSERT INTO TB_INVOICE (INVOICE_ID, STUDENT_ID, SUBJECT_ID, DATEREGISTER,TYPESUBJECT)
VALUES
    ('INV001', '23211TT2984', 'SUBJ01', NULL,N'TỰ CHỌN'),
    ('INV002', '23211TT2984', 'SUBJ02', NULL ,N'BẮT BUỘC'),
    ('INV003', '23211TT2984', 'SUBJ04', NULL ,N'BẮT BUỘC'),
    ('INV004', '23211TT2984', 'SUBJ05',  NULL,N'TỰ CHỌN'),
    ('INV005', '23211TT2984', 'SUBJ07',  NULL,N'TỰ CHỌN'),
    ('INV006', '23211TT2984', 'SUBJ08',  NULL,N'BẮT BUỘC'),
    ('INV007', '23211TT2984', 'SUBJ10',  NULL,N'TỰ CHỌN'),
    ('INV008', '23211TT2984', 'SUBJ11',  NULL,N'BẮT BUỘC'),
    ('INV009', '23211TT2984', 'SUBJ12',  NULL,N'TỰ CHỌN'),
	('INV0010', '23211TT2984', 'SUBJ13',  NULL,N'TỰ CHỌN'),
    ('INV0011', '23211TT2984', 'SUBJ14',  NULL,N'BẮT BUỘC'),
    ('INV0012', '23211TT2984', 'SUBJ15',  NULL,N'BẮT BUỘC'),
    ('INV0013', '23211TT2984', 'SUBJ16',  NULL,N'TỰ CHỌN'),
    ('INV0014', '23211TT2984', 'SUBJ17', NULL,N'TỰ CHỌN'),
    ('INV0015', '23211TT2984', 'SUBJ18',  NULL,N'BẮT BUỘC');

GO
-- Thêm dữ liệu mẫu vào bảng TB_ENROLLMENT
INSERT INTO TB_ENROLLMENT (Registration_ID, STUDENT_ID, SUBJECT_ID, ENROLLMENT_AT)
VALUES
    ('REG001', '23211TT2984', 'SUBJ01', '2024-09-01'),
    ('REG002', '23211TT5678', 'SUBJ02', '2024-09-02'),
    ('REG003', '23211TT1234', 'SUBJ03', '2024-09-03'),
    ('REG004', '23211TT9012', 'SUBJ01', '2024-09-04'),
    ('REG005', '23211TT7890', 'SUBJ02', '2024-09-05'),
    ('REG006', '23211TT1357', 'SUBJ03', '2024-09-06'),
    ('REG007', '23211TT9876', 'SUBJ01', '2024-09-07'),
    ('REG008', '23211TT1111', 'SUBJ02', '2024-09-08'),
    ('REG009', '23211TT2222', 'SUBJ03', '2024-09-09');
GO
-- Thêm dữ liệu mẫu vào bảng TB_VIOLATESV

INSERT INTO TB_VIOLATESV (VIOLATESV_ID, VIOLATION_NAME, STUDENT_ID, SUBJECT_ID)
VALUES
    ('VL012', N'Không mặc đồng phục', '23211TT2984', 'SUBJ01'),
    ('VL013', N'Vắng', '23211TT2984', 'SUBJ02'),
    ('VL014', N'Đi trễ', '23211TT2984', 'SUBJ03'),
    ('VL015', N'Không chuẩn bị bài', '23211TT2984', 'SUBJ01'),  
    ('VL016', N'Vắng', '23211TT5678', 'SUBJ02'),
    ('VL017', N'Nói chuyện trong giờ học', '23211TT5678', 'SUBJ03'),
    ('VL018', N'Sử dụng điện thoại trong lớp', '23211TT5678', 'SUBJ01'),  
    ('VL019', N'Không làm bài tập', '23211TT7890', 'SUBJ03'),
    ('VL020', N'Không tham gia hoạt động nhóm', '23211TT7890', 'SUBJ01'),
    ('VL021', N'Vắng không phép', '23211TT1234', 'SUBJ02'),
    ('VL022', N'Đi trễ', '23211TT1357', 'SUBJ03'),
    ('VL023', N'Không chuẩn bị bài', '23211TT9876', 'SUBJ01'),
    ('VL024', N'Không tham gia hoạt động nhóm', '23211TT9876', 'SUBJ02'),
    ('VL025', N'Vắng', '23211TT1111', 'SUBJ03'),
    ('VL026', N'Không làm bài tập', '23211TT4444', 'SUBJ01'),
    ('VL027', null, '23211TT5555', 'SUBJ02'),
    ('VL028', N'Không tham gia hoạt động nhóm', '23211TT5555', 'SUBJ03'); 

--DELETE FROM TB_VIOLATESV
GO
-- Thêm dữ liệu vào bảng TB_TUITIONFESS
INSERT INTO TB_TUITIONFESS(
    TUITIONFEEID_ID, 
    STUDENT_ID, 
    SEMESTER, 
    ACADEMICYEAR, 
    SUBJECT_ID, 
    CREDITUNITPRICE, 
    TOTALTUITION, 
    PAYMENTDATE, 
    STATUSHP, 
    CLASS_NAME
) 
VALUES
    ('TF001', '23211TT2984', N'Học kỳ 1', '2024-2025', 'SUBJ01', 30000, null, null, N'CHƯA ĐÓNG', 'CD23TT10'),
    ('TF002', '23211TT1404', N'Học kỳ 1', '2024-2025', 'SUBJ02', 30000, null, null, N'CHƯA ĐÓNG', 'CD23TT9'),
    ('TF003', '23211TT1234', N'Học kỳ 1', '2024-2025', 'SUBJ03', 30000, null, '2024-10-15', N'ĐÃ ĐÓNG', 'CD23TT10'),
    ('TF004', '23211TT5678', N'Học kỳ 1', '2024-2025', 'SUBJ04', 40000, null, null, N'CHƯA ĐÓNG', 'CD23TT9'),
    ('TF005', '23211TT9012', N'Học kỳ 1', '2024-2025', 'SUBJ05', 30000, null, '2024-09-20', N'ĐÃ ĐÓNG', 'CD23TT10'),
    ('TF006', '23211TT3456', N'Học kỳ 1', '2024-2025', 'SUBJ06', 30000, null, '2024-09-25', N'CHƯA ĐÓNG', 'CD23TT10'),
    ('TF007', '23211TT7890', N'Học kỳ 1', '2024-2025', 'SUBJ07', 30000, null, '2024-12-10', N'CHƯA ĐÓNG', 'CD23TT9'),
    ('TF008', '23211TT1357', N'Học kỳ 1', '2024-2025', 'SUBJ08', 30000, null, '2024-09-05', N'ĐÃ ĐÓNG', 'CD23TT10'),
    ('TF009', '23211TT9876', N'Học kỳ 1', '2024-2025', 'SUBJ09', 30000, null, '2024-11-15', N'CHƯA ĐÓNG', 'CD23TT9'),
    ('TF010', '23211TT5432', N'Học kỳ 1', '2024-2025', 'SUBJ10', 30000, null, '2024-09-28', N'ĐÃ ĐÓNG', 'CD23TT10'),
    ('TF011', '23211TT1111', N'Học kỳ 1', '2024-2025', 'SUBJ01', 40000, null, '2024-12-05', N'CHƯA ĐÓNG', 'CD23TT9'),
    ('TF012', '23211TT2222', N'Học kỳ 1', '2024-2025', 'SUBJ09', 30000, null, '2024-09-30', N'ĐÃ ĐÓNG', 'CD23TT10'),
    ('TF013', '23211TT3333', N'Học kỳ 1', '2024-2025', 'SUBJ10', 30000, null, '2024-11-25', N'CHƯA ĐÓNG', 'CD23TT9'),
    ('TF014', '23211TT4444', N'Học kỳ 1', '2024-2025', 'SUBJ07', 30000, null, '2024-09-10', N'ĐÃ ĐÓNG', 'CD23TT10'),
    ('TF015', '23211TT5555', N'Học kỳ 1', '2024-2025', 'SUBJ09', 40000, null, '2024-12-15', N'CHƯA ĐÓNG', 'CD23TT9')

--DELETE FROM TB_TUITIONFESS
GO
