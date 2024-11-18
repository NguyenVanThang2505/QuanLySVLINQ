using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySVLINQ
{
    public class StudentQuery
    {
        // In danh sách toàn bộ sinh viên
        public static void InDanhSachSV(List<SinhVien> students)
        {
            Console.WriteLine("Danh sach toan bo sinh vien:");
            foreach (var student in students)
            {
                Console.WriteLine($"Ma: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }
        }

        // Tìm sinh viên có tên bắt đầu bằng chữ "A"
        public static void InDanhSachTenStartWithA(List<SinhVien> students)
        {
            Console.WriteLine("Sinh vien có ten bat dau bang chu 'A':");
            var filteredStudents = students.Where(s => s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"Ma: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }
        }

        // Tính tổng tuổi của tất cả sinh viên
        public static void InDanhSachTongTuoi(List<SinhVien> students)
        {
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"Tong so tuoi cua tat ca sinh vien: {totalAge}");
        }

        // Sắp xếp sinh viên theo tuổi tăng dần và in ra danh sách
        public static void SapXepTuoiTangDan(List<SinhVien> students)
        {
            Console.WriteLine("Danh sach sinh vien sap xep theo tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Ma: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }
        }

        // Tìm sinh viên từ độ tuổi min đến max
        public static void TimMinMax(List<SinhVien> students, int minAge, int maxAge)
        {
            Console.WriteLine($"Sinh vien tu {minAge} den {maxAge} tuoi:");
            var filteredStudents = students.Where(s => s.Age >= minAge && s.Age <= maxAge);
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"Ma: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }
        }

        // Tìm sinh viên có tuổi lớn nhất
        public static void TimSVLonNhat(List<SinhVien> students)
        {
            int maxAge = students.Max(s => s.Age);
            var oldestStudents = students.Where(s => s.Age == maxAge);

            Console.WriteLine("Sinh vien co tuoi lon nhat:");
            foreach (var student in oldestStudents)
            {
                Console.WriteLine($"Ma: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }
        }
    }
}
