using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_HOMEWORK
{
    //Bai1:Kiểm tra số chẵn hay số lẻ (Even or Odd)
    class Program
    {
        static void Main()
        {
            Console.Write("Nhập vào một số nguyên: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} là số chẵn (Even).");
            }
            else
            {
                Console.WriteLine($"{num} là số lẻ (Odd).");
            }
        }
    }
    //Bai2:Tìm số lớn nhất trong 3 số
    class Program
    {
        static void Main()
        {
            Console.Write("Nhập số thứ nhất: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            int c = int.Parse(Console.ReadLine());

            int max = a;

            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine($"Số lớn nhất trong 3 số là: {max}");
        }
    }
    //Bai3:Xác định góc phần tư của tọa độ XY
    class Program
    {
        static void Main()
        {
            Console.Write("Nhập tọa độ X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập tọa độ Y: ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine($"Điểm ({x}, {y}) thuộc Góc phần tư thứ I.");
            else if (x < 0 && y > 0)
                Console.WriteLine($"Điểm ({x}, {y}) thuộc Góc phần tư thứ II.");
            else if (x < 0 && y < 0)
                Console.WriteLine($"Điểm ({x}, {y}) thuộc Góc phần tư thứ III.");
            else if (x > 0 && y < 0)
                Console.WriteLine($"Điểm ({x}, {y}) thuộc Góc phần tư thứ IV.");
            else if (x == 0 && y == 0)
                Console.WriteLine($"Điểm ({x}, {y}) nằm ngay tại Gốc tọa độ.");
            else
                Console.WriteLine($"Điểm ({x}, {y}) nằm trên trục tọa độ.");
        }
    }
    //Bai4:Phân loại Tam giác
   class Program
    {
        static void Main()
        {
            Console.Write("Nhập cạnh thứ 1: ");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh thứ 2: ");
            int s2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh thứ 3: ");
            int s3 = int.Parse(Console.ReadLine());

            // Kiểm tra điều kiện tồn tại tam giác trước
            if (s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1)
            {
                if (s1 == s2 && s2 == s3)
                    Console.WriteLine("Đây là Tam giác đều (Equilateral).");
                else if (s1 == s2 || s1 == s3 || s2 == s3)
                    Console.WriteLine("Đây là Tam giác cân (Isosceles).");
                else
                    Console.WriteLine("Đây là Tam giác thường (Scalene).");
            }
            else
            {
                Console.WriteLine("Ba cạnh trên không tạo thành một tam giác hợp lệ!");
            }
        }
    }
    //Bai5:Tính tổng và trung bình cộng của 10 số nhập vào
    class Program
    {
        static void Main()
        {
            int sum = 0;
            Console.WriteLine("Nhập vào 10 số nguyên:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Số thứ {i}: ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            double average = (double)sum / 10;

            Console.WriteLine($"\nTổng của 10 số là: {sum}");
            Console.WriteLine($"Trung bình cộng của 10 số là: {average}");
        }
    }
    //Bai6:In bảng cửu chương của một số bất kỳ
   class Program
    {
        static void Main()
        {
            Console.Write("Nhập vào một số nguyên: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"--- BẢNG CỬU CHƯƠNG {n} ---");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
    //Bai7:Vẽ các mẫu hình tam giác số
   class Program
    {
        static void Main()
        {
            Console.Write("Nhập số hàng cho tam giác (ví dụ: 4): ");
            int rows = int.Parse(Console.ReadLine());

            // Mẫu 1: Tăng dần theo cột
            Console.WriteLine("\n--- Mẫu 1 ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++) Console.Write(j);
                Console.WriteLine();
            }

            // Mẫu 2: Số chạy liên tục (Floyd's Triangle)
            Console.WriteLine("\n--- Mẫu 2 ---");
            int k = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++) Console.Write(k++ + " ");
                Console.WriteLine();
            }

            // Mẫu 3: Kim tự tháp số chạy liên tục
            Console.WriteLine("\n--- Mẫu 3 ---");
            k = 1;
            for (int i = 1; i <= rows; i++)
            {
                // In khoảng trắng căn lề giữa
                for (int space = 1; space <= rows - i; space++) Console.Write(" ");
                for (int j = 1; j <= i; j++) Console.Write(k++ + " ");
                Console.WriteLine();
            }
        }
    }
    //Bai8:Tính tổng chuỗi số điều hòa
    class Program
    {
        static void Main()
        {
            Console.Write("Nhập số giới hạn n của chuỗi: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;

            Console.Write("Chuỗi hiển thị: ");
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
                if (i == 1)
                    Console.Write("1/1");
                else
                    Console.Write($" + 1/{i}");
            }

            Console.WriteLine($"\nTổng của chuỗi Harmonic gồm {n} số hạng là: {sum:F6}");
        }
    }
    //Bai9:Tìm số hoàn hảo trong một khoảng cho trước
    class Program
    {
        static void Main()
        {
            Console.Write("Nhập giới hạn tìm kiếm (ví dụ: từ 1 đến bao nhiêu): ");
            int limit = int.Parse(Console.ReadLine());

            Console.WriteLine($"Các số hoàn hảo trong khoảng từ 1 đến {limit} là:");

            for (int num = 1; num <= limit; num++)
            {
                int sumOfDivisors = 0;

                // Tìm các ước số
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0) sumOfDivisors += i;
                }

                // Nếu tổng các ước bằng chính số đó thì là số hoàn hảo
                if (sumOfDivisors == num && num != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
    }
    //Bai10:Kiểm tra số nguyên tố
    class Program
    {
        static void Main()
        {
            Console.Write("Nhập vào một số nguyên để kiểm tra: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                // Kiểm tra chia hết từ 2 đến căn bậc hai của số đó
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine($"{num} LÀ số nguyên tố (Prime number).");
            else
                Console.WriteLine($"{num} KHÔNG PHẢI số nguyên tố.");
        }
    }
}
