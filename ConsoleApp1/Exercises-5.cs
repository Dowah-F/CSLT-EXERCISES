using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_HOMEWORK
{
    class BaiTapCSharp
    {
        // Bài 1: Tính tổng hai số nguyên
        static int TinhTong(int a, int b)
        {
            return a + b;
        }

        // Bài 2: Kiểm tra số chẵn lẻ
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        // Bài 3: Tìm số lớn nhất trong ba số
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        // Bài 4: Tính giai thừa
        static long TinhGiaiThua(int n)
        {
            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }

        // Bài 5: Đảo ngược chuỗi ký tự
        static string DaoNguocChuoi(string input)
        {
            char[] mangKyTu = input.ToCharArray();
            Array.Reverse(mangKyTu);
            return new string(mangKyTu);
        }

       // Bài 6: Kiểm tra số nguyên tố
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Bài 7: In dãy Fibonacci
        static void InFibonacci(int n)
        {
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int tiep = a + b;
                a = b;
                b = tiep;
            }
            Console.WriteLine();
        }

        // Bài 8: Đếm số lượng nguyên âm trong chuỗi
        static int DemNguyenAm(string s)
        {
            string nguyenAm = "aeiouAEIOU";
            int dem = 0;
            foreach (char c in s)
            {
                if (nguyenAm.Contains(c)) dem++;
            }
            return dem;
        }

        // Bài 9: Tính lũy thừa (không dùng Math.Pow)
        static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1;
            for (int i = 0; i < y; i++)
            {
                ketQua *= x;
            }
            return ketQua;
        }

        // Bài 10: Tính điểm trung bình của mảng
        static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;
            foreach (int phanTu in arr)
            {
                tong += phanTu;
            }
            return (double)tong / arr.Length;
        }

        // Bài 11: Kiểm tra chuỗi đối xứng (Palindrome)
        static bool KiemTraDoiXung(string s)
        {
            string chuoiDao = DaoNguocChuoi(s);
            return s.Equals(chuoiDao, StringComparison.OrdinalIgnoreCase);
        }

        // Bài 12: Chuyển đổi nhiệt độ Celsius → Fahrenheit
        static double CelsiusToFahrenheit(double c)
        {
            return c * 9.0 / 5.0 + 32;
        }

        // Bài 13: Tìm giá trị nhỏ nhất trong mảng
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            foreach (int phanTu in arr)
            {
                if (phanTu < min) min = phanTu;
            }
            return min;
        }

        // Bài 14: Tính tổng các chữ số của một số nguyên
        static int TongCacChuSo(int n)
        {
            n = Math.Abs(n); // Xử lý số âm
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }
            return tong;
        }

        // Bài 15: Sắp xếp mảng tăng dần (Bubble Sort)
        static void SapXepMang(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tam = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tam;
                    }
                }
            }
            foreach (int phanTu in arr)
            {
                Console.Write(phanTu + " ");
            }
            Console.WriteLine();
        }

        // Bài 16: Xóa ký tự trùng lặp
        static string XoaTrungLap(string s)
        {
            StringBuilder ketQua = new StringBuilder();
            foreach (char c in s)
            {
                if (ketQua.ToString().IndexOf(c) == -1)
                {
                    ketQua.Append(c);
                }
            }
            return ketQua.ToString();
        }

        // Bài 17: Tìm ước chung lớn nhất (Thuật toán Euclid)
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int du = a % b;
                a = b;
                b = du;
            }
            return a;
        }

        // Bài 18: Chuyển đổi thập phân sang nhị phân
        static string DecimalToBinary(int n)
        {
            if (n == 0) return "0";
            string ketQua = "";
            while (n > 0)
            {
                ketQua = (n % 2) + ketQua;
                n /= 2;
            }
            return ketQua;
        }

        // Bài 19: Kiểm tra năm nhuận
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Bài 20: Đếm số từ trong câu
        static int DemSoTu(string sentence)
        {
            // Tách theo khoảng trắng, loại bỏ phần tử rỗng
            string[] tuMang = sentence.Trim().Split(
                new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries
            );
            return tuMang.Length;
        }

        //  HÀM MAIN – CHẠY VÀ IN KẾT QUẢ TẤT CẢ CÁC BÀI    
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("========================================");
            Console.WriteLine("   KẾT QUẢ 20 BÀI TẬP C#");
            Console.WriteLine("========================================\n");

            // --- Phần 1 ---
            Console.WriteLine("--- PHẦN 1: BÀI TẬP CÓ HƯỚNG DẪN ---\n");

            Console.WriteLine("Bài 1 – Tính tổng hai số nguyên:");
            Console.WriteLine($"  TinhTong(3, 7)   = {TinhTong(3, 7)}");
            Console.WriteLine($"  TinhTong(-5, 10) = {TinhTong(-5, 10)}\n");

            Console.WriteLine("Bài 2 – Kiểm tra số chẵn lẻ:");
            Console.WriteLine($"  KiemTraChan(4) = {KiemTraChan(4)}");
            Console.WriteLine($"  KiemTraChan(7) = {KiemTraChan(7)}\n");

            Console.WriteLine("Bài 3 – Tìm số lớn nhất trong ba số:");
            Console.WriteLine($"  TimMax(3, 7, 5)   = {TimMax(3, 7, 5)}");
            Console.WriteLine($"  TimMax(10, 2, 8)  = {TimMax(10, 2, 8)}\n");

            Console.WriteLine("Bài 4 – Tính giai thừa:");
            Console.WriteLine($"  TinhGiaiThua(5)  = {TinhGiaiThua(5)}");
            Console.WriteLine($"  TinhGiaiThua(10) = {TinhGiaiThua(10)}\n");

            Console.WriteLine("Bài 5 – Đảo ngược chuỗi:");
            Console.WriteLine($"  DaoNguocChuoi(\"hello\")   = \"{DaoNguocChuoi("hello")}\"");
            Console.WriteLine($"  DaoNguocChuoi(\"abcdef\")  = \"{DaoNguocChuoi("abcdef")}\"\n");

            // --- Phần 2 ---
            Console.WriteLine("--- PHẦN 2: BÀI TẬP CÓ KẾT QUẢ MẪU ---\n");

            Console.WriteLine("Bài 6 – Kiểm tra số nguyên tố:");
            Console.WriteLine($"  KiemTraNguyenTo(7)  = {KiemTraNguyenTo(7)}");
            Console.WriteLine($"  KiemTraNguyenTo(10) = {KiemTraNguyenTo(10)}\n");

            Console.WriteLine("Bài 7 – In dãy Fibonacci (6 số đầu):");
            Console.Write("  ");
            InFibonacci(6);
            Console.WriteLine();

            Console.WriteLine("Bài 8 – Đếm nguyên âm:");
            Console.WriteLine($"  DemNguyenAm(\"Hello World\") = {DemNguyenAm("Hello World")}\n");

            Console.WriteLine("Bài 9 – Tính lũy thừa:");
            Console.WriteLine($"  TinhLuyThua(2, 3) = {TinhLuyThua(2, 3)}");
            Console.WriteLine($"  TinhLuyThua(3, 4) = {TinhLuyThua(3, 4)}\n");

            Console.WriteLine("Bài 10 – Tính trung bình mảng:");
            int[] mang10 = { 4, 5, 6, 7 };
            Console.WriteLine($"  TinhTrungBinh([4,5,6,7]) = {TinhTrungBinh(mang10)}\n");

            Console.WriteLine("Bài 11 – Kiểm tra chuỗi đối xứng:");
            Console.WriteLine($"  KiemTraDoiXung(\"radar\") = {KiemTraDoiXung("radar")}");
            Console.WriteLine($"  KiemTraDoiXung(\"hello\") = {KiemTraDoiXung("hello")}\n");

            Console.WriteLine("Bài 12 – Celsius → Fahrenheit:");
            Console.WriteLine($"  CelsiusToFahrenheit(25) = {CelsiusToFahrenheit(25)}\n");

            Console.WriteLine("Bài 13 – Tìm giá trị nhỏ nhất:");
            int[] mang13 = { 10, 5, 8, 2, 9 };
            Console.WriteLine($"  TimMin([10,5,8,2,9]) = {TimMin(mang13)}\n");

            Console.WriteLine("Bài 14 – Tổng các chữ số:");
            Console.WriteLine($"  TongCacChuSo(1234) = {TongCacChuSo(1234)}\n");

            Console.WriteLine("Bài 15 – Sắp xếp mảng tăng dần:");
            int[] mang15 = { 3, 1, 4, 2 };
            Console.Write("  SapXepMang([3,1,4,2]) = ");
            SapXepMang(mang15);

            Console.WriteLine("Bài 16 – Xóa ký tự trùng lặp:");
            Console.WriteLine($"  XoaTrungLap(\"programming\") = \"{XoaTrungLap("programming")}\"\n");

            Console.WriteLine("Bài 17 – Ước chung lớn nhất (UCLN):");
            Console.WriteLine($"  UCLN(12, 18) = {UCLN(12, 18)}\n");

            Console.WriteLine("Bài 18 – Thập phân → Nhị phân:");
            Console.WriteLine($"  DecimalToBinary(10) = \"{DecimalToBinary(10)}\"\n");

            Console.WriteLine("Bài 19 – Kiểm tra năm nhuận:");
            Console.WriteLine($"  KiemTraNamNhuan(2024) = {KiemTraNamNhuan(2024)}");
            Console.WriteLine($"  KiemTraNamNhuan(2023) = {KiemTraNamNhuan(2023)}\n");

            Console.WriteLine("Bài 20 – Đếm số từ trong câu:");
            Console.WriteLine($"  DemSoTu(\"Học lập trình C# rất thú vị\") = {DemSoTu("Học lập trình C# rất thú vị")}\n");

            Console.WriteLine("========================================");
            Console.WriteLine("           HOÀN THÀNH!");
            Console.WriteLine("========================================");
        }
    }

}
