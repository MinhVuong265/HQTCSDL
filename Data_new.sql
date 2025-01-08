insert into NhanVien values
(N'Nguyễn Thị Quỳnh', '0912456789', N'Đang làm'),
(N'Trần Văn Hải', '0983745621', N'Đang làm'),
(N'Nguyễn Trung Đức', '0908765432', N'Đang làm'),
(N'Vũ Văn Đồng', '0965123487', N'Đang làm'),
(N'Trương Minh Vương', '0937142856', N'Đang làm')



insert into TaiKhoan values
('quynhnt', '123456', 'staff', 1),
('haitv', '123456', 'staff', 2),
('ducnt', '123456', 'staff', 3),
('dongvv', '123456', 'staff', 4),
('vuongtm', '123456', 'admin', 5)


INSERT INTO NhaCungCap
VALUES
    (N'Công ty Sách Việt Nam', '0912456789', N'123 Đường Lê Lợi, Hà Nội'),
    (N'Trung tâm Phát hành Sách', '0983745621', N'456 Đường Nguyễn Huệ, TP.HCM'),
    (N'Nhà Sách ABC', '0908765432', N'789 Đường Trần Phú, Đà Nẵng'),
    (N'Phát hành Sách XYZ', '0965123487', N'321 Đường Phạm Văn Đồng, Hải Phòng'),
    (N'Công ty Sách Thiên Long', '0937142856', N'654 Đường Hoàng Diệu, Cần Thơ');

INSERT INTO TheLoai (Ten)
VALUES
    (N'Tiểu thuyết'),
    (N'Khoa học viễn tưởng'),
    (N'Truyện tranh'),
    (N'Giáo dục'),
    (N'Lịch sử');

INSERT INTO Sach (TenSach, TenTacGia, IDTheLoai, IDNhaCungCap, SoLuong, TrangThai)
VALUES
    (N'Tiểu thuyết ngắn', N'Nguyễn Nhật Ánh', 1, 1, 20, N'Còn'),
    (N'Lịch sử thế giới', N'John Green', 5, 2, 15, N'Còn'),
    (N'Khoa học kỳ thú', N'Isaac Asimov', 2, 3, 10, N'Hết'),
    (N'Truyện tranh Conan', N'Aoyama Gosho', 3, 4, 50, N'Còn'),
    (N'Giáo dục hiện đại', N'Maria Montessori', 4, 5, 25, N'Còn'),
	(N'Harry Potter và Hòn Đá Phù Thủy', N'J.K. Rowling', 3, 1, 35, N'Còn'),
    (N'Đắc Nhân Tâm', N'Dale Carnegie', 4, 2, 50, N'Còn'),
    (N'Lập trình Python từ cơ bản đến nâng cao', N'John Doe', 2, 3, 40, N'Còn'),
    (N'Trí tuệ nhân tạo và tương lai', N'Elon Musk', 2, 4, 15, N'Hết'),
    (N'Toán học trong cuộc sống', N'Alan Turing', 2, 5, 30, N'Còn'),
    (N'Tâm lý học hành vi', N'B.F. Skinner', 5, 1, 10, N'Còn'),
    (N'Cuộc đời của Pi', N'Yann Martel', 3, 2, 25, N'Còn'),
    (N'Marketing 4.0', N'Philip Kotler', 4, 3, 20, N'Còn'),
    (N'Kiến trúc xanh hiện đại', N'Frank Lloyd Wright', 5, 4, 5, N'Hết'),
    (N'Cẩm nang hướng dẫn startup', N'Eric Ries', 4, 5, 12, N'Còn'),
    (N'Tiếng Việt lớp 1', N'Nhóm giáo viên', 1, 1, 100, N'Còn'),
    (N'Truyện Kiều', N'Nguyễn Du', 1, 2, 80, N'Còn'),
    (N'Số đỏ', N'Vũ Trọng Phụng', 1, 3, 60, N'Còn'),
    (N'Chuyện ngụ ngôn', N'La Fontaine', 1, 4, 50, N'Còn'),
    (N'Tiếng Anh giao tiếp cơ bản', N'Lisa Brown', 2, 5, 45, N'Còn'),
    (N'Lịch sử Việt Nam từ 1945 đến nay', N'Phan Huy Lê', 5, 1, 10, N'Còn'),
    (N'Trinh thám Sherlock Holmes', N'Arthur Conan Doyle', 3, 2, 40, N'Còn'),
    (N'Những giấc mơ lớn', N'Barack Obama', 5, 3, 15, N'Còn'),
    (N'Một đời thương thuyết', N'Nguyễn Khắc Viện', 4, 4, 25, N'Còn'),
    (N'Triết học phương Đông', N'Khổng Tử', 5, 5, 8, N'Còn');


INSERT INTO DocGia (Ten, SoDienThoai, DiaChi)
VALUES
    (N'Nguyễn Minh Hoàng', '0912345678', N'Hà Nội'),
    (N'Lê Thị Hương', '0987654321', N'TP.HCM'),
    (N'Phạm Tuấn Anh', '0934567890', N'Đà Nẵng'),
    (N'Trần Ngọc Mai', '0971122334', N'Bình Dương'),
    (N'Hoàng Văn Tùng', '0965566778', N'Hải Phòng'),
    (N'Đỗ Thị Thanh', '0954433221', N'Cần Thơ'),
    (N'Võ Anh Tuấn', '0943211234', N'Quảng Ninh'),
    (N'Ngô Thị Phượng', '0922110099', N'Hà Nam'),
    (N'Bùi Minh Trí', '0915567788', N'Quảng Bình'),
    (N'Tôn Nữ Thảo Vy', '0988899999', N'Huế');


INSERT INTO TheMuon (IDDocGia)
VALUES 
    (1), 
    (2), 
    (3), 
    (4), 
    (5), 
    (6), 
    (7), 
    (8), 
    (9), 
    (10);

INSERT INTO SachMuon (IDTheMuon, IDSach, NgayMuon, NgayTra, IDNhanVien)
VALUES 
    (1, 1, '2025-01-01', '2025-01-15', 1),
    (1, 2, '2025-01-01', NULL, 1),
    (2, 3, '2025-01-02', '2025-01-10', 2),
    (2, 4, '2025-01-02', NULL, 2),
    (3, 5, '2025-01-03', NULL, 3),
    (3, 6, '2025-01-03', '2025-01-12', 3),
    (4, 7, '2025-01-04', NULL, 4),
    (4, 8, '2025-01-04', '2025-01-18', 4),
    (5, 9, '2025-01-05', '2025-01-20', 5),
    (5, 10, '2025-01-05', NULL, 5),
    (6, 1, '2025-01-06', '2025-01-15', 1),
    (6, 3, '2025-01-06', NULL, 1),
    (7, 2, '2025-01-07', '2025-01-16', 2),
    (7, 4, '2025-01-07', NULL, 2),
    (8, 5, '2025-01-08', '2025-01-17', 3),
    (8, 6, '2025-01-08', NULL, 3),
    (9, 7, '2025-01-09', '2025-01-18', 4),
    (9, 8, '2025-01-09', NULL, 4),
    (10, 9, '2025-01-10', '2025-01-19', 5),
    (10, 10, '2025-01-10', NULL, 5);



