using System;
using System.Collections.Generic;
using QuanLySVLINQ;

namespace QuanLySVLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách sinh viên
            List<SinhVien> students = new List<SinhVien>
            {
                new SinhVien { Id = 1, Name = "An", Age = 16 },
                new SinhVien { Id = 2, Name = "Binh", Age = 18 },
                new SinhVien { Id = 3, Name = "Cuong", Age = 15 },
                new SinhVien { Id = 4, Name = "Dung", Age = 20 },
                new SinhVien { Id = 5, Name = "Anh", Age = 17 }
            };

            // In toàn bộ danh sách sinh viên
            StudentQuery.InDanhSachSV(students);

            Console.WriteLine(); // Dòng trống

            // Tìm sinh viên từ 15 đến 18 tuổi
            StudentQuery.TimMinMax(students, 15, 18);

            Console.WriteLine(); // Dòng trống

            // Tìm sinh viên có tuổi lớn nhất
            StudentQuery.TimSVLonNhat(students);

            Console.WriteLine(); // Dòng trống

            // Tìm sinh viên có tên bắt đầu bằng chữ "A"
            StudentQuery.InDanhSachTenStartWithA(students);

            Console.WriteLine(); // Dòng trống

            // Tính tổng số tuổi của tất cả sinh viên
            StudentQuery.InDanhSachTongTuoi(students);

            Console.WriteLine(); // Dòng trống

            // Sắp xếp sinh viên theo tuổi tăng dần
            StudentQuery.SapXepTuoiTangDan(students);
        }
    }
}
