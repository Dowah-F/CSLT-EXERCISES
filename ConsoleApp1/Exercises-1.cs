using System;
using System.Text;

namespace StudentProfessionalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            bool isRunning = true;
            while (isRunning)
            {
                DisplayMenu();
                int choice = ReadInteger("Nhập lựa chọn của bạn (1-11): ");
                Console.Clear();

                switch (choice)
                {
                    case 1: ExecuteSumTwoNumbers(); break;
                    case 2: ExecuteSwapVariables(); break;
                    case 3: ExecuteMultiplyFloats(); break;
                    case 4: ExecuteFeetToMeters(); break;
                    case 5: ExecuteTemperatureConversion(); break;
                    case 6: ExecutePrintDataTypesSizes(); break;
                    case 7: ExecutePrintAsciiValue(); break;
                    case 8: ExecuteCircleArea(); break;
                    case 9: ExecuteSquareArea(); break;
                    case 10: ExecuteConvertDays(); break;
                    case 11:
                        isRunning = false;
                        Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại!");
                        break;
                }

                if (isRunning)
                {
                    Console.WriteLine("\nẤn phím bất kỳ để quay lại Menu chính...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("     CHƯƠNG TRÌNH DEMO BÀI TẬP C# - LEVEL: PRO    ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Tính tổng hai số");
            Console.WriteLine("2. Hoán vị hai biến (Sử dụng Tuple)");
            Console.WriteLine("3. Nhân hai số thực Floating-Point");
            Console.WriteLine("4. Chuyển đổi Feet sang Mét");
            Console.WriteLine("5. Chuyển đổi Celsius <=> Fahrenheit");
            Console.WriteLine("6. Kiểm tra kích thước các kiểu dữ liệu");
            Console.WriteLine("7. In mã ASCII của ký tự");
            Console.WriteLine("8. Tính diện tích hình tròn");
            Console.WriteLine("9. Tính diện tích hình vuông");
            Console.WriteLine("10. Đổi ngày sang Năm - Tuần - Ngày");
            Console.WriteLine("11. Thoát chương trình");
            Console.WriteLine("==================================================");
        }

        #region Chức năng chi tiết

        // 1. Add / Sum Two Numbers
        private static void ExecuteSumTwoNumbers()
        {
            Console.WriteLine("--- 1. TÍNH TỔNG HAI SỐ ---");
            double num1 = ReadDouble("Nhập số thứ nhất: ");
            double num2 = ReadDouble("Nhập số thứ hai: ");
            Console.WriteLine($"Kết quả: {num1} + {num2} = {num1 + num2}");
        }

        // 2. Swap Values of Two Variables (Sử dụng Generics và Tuple mang tính Pro)
        private static void ExecuteSwapVariables()
        {
            Console.WriteLine("--- 2. HOÁN VỊ HAI BIẾN ---");
            Console.Write("Nhập chuỗi A: ");
            string a = Console.ReadLine() ?? "";
            Console.Write("Nhập chuỗi B: ");
            string b = Console.ReadLine() ?? "";

            Console.WriteLine($"Trước khi hoán vị: A = {a}, B = {b}");
            (a, b) = (b, a); // C# Tuple Deconstruction (Không cần biến tạm)
            Console.WriteLine($"Sau khi hoán vị:  A = {a}, B = {b}");
        }

        // 3. Multiply two Floating Point Numbers
        private static void ExecuteMultiplyFloats()
        {
            Console.WriteLine("--- 3. NHÂN HAI SỐ THỰC (FLOAT) ---");
            float num1 = (float)ReadDouble("Nhập số float thứ nhất: ");
            float num2 = (float)ReadDouble("Nhập số float thứ hai: ");
            float result = num1 * num2;
            Console.WriteLine($"Kết quả: {num1} * {num2} = {result}");
        }

        // 4. Convert feet to meter
        private static void ExecuteFeetToMeters()
        {
            Console.WriteLine("--- 4. CHUYỂN ĐỔI FEET SANG MÉT ---");
            double feet = ReadDouble("Nhập số Feet: ");
            // 1 foot = 0.3048 m
            double meters = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {meters:F4} mét");
        }

        // 5. Convert Celsius to Fahrenheit and vice versa
        private static void ExecuteTemperatureConversion()
        {
            Console.WriteLine("--- 5. CHUYỂN ĐỔI NHIỆT ĐỘ ---");
            Console.WriteLine("1. Từ Celsius sang Fahrenheit");
            Console.WriteLine("2. Từ Fahrenheit sang Celsius");
            int type = ReadInteger("Chọn loại chuyển đổi (1-2): ");

            if (type == 1)
            {
                double c = ReadDouble("Nhập độ C: ");
                double f = c * 1.8 + 32;
                Console.WriteLine($"Kết quả: {c}°C = {f:F2}°F");
            }
            else if (type == 2)
            {
                double f = ReadDouble("Nhập độ F: ");
                double c = (f - 32) / 1.8;
                Console.WriteLine($"Kết quả: {f}°F = {c:F2}°C");
            }
            else
            {
                Console.WriteLine("Lựa chọn sai!");
            }
        }

        // 6. Find the Size of data types (Sử dụng sizeof trong môi trường an toàn)
        private static void ExecutePrintDataTypesSizes()
        {
            Console.WriteLine("--- 6. KÍCH THƯỚC CÁC KIỂU DỮ LIỆU ---");
            Console.WriteLine($"| {"Kiểu dữ liệu",-15} | {"Kích thước (Bytes)",-20} |");
            Console.WriteLine(new string('-', 44));
            Console.WriteLine($"| {"bool",-15} | {sizeof(bool),-20} |");
            Console.WriteLine($"| {"char",-15} | {sizeof(char),-20} |");
            Console.WriteLine($"| {"int",-15} | {sizeof(int),-20} |");
            Console.WriteLine($"| {"long",-15} | {sizeof(long),-20} |");
            Console.WriteLine($"| {"float",-15} | {sizeof(float),-20} |");
            Console.WriteLine($"| {"double",-15} | {sizeof(double),-20} |");
            Console.WriteLine($"| {"decimal",-15} | {sizeof(decimal),-20} |");
        }

        // 7. Print ASCII Value
        private static void ExecutePrintAsciiValue()
        {
            Console.WriteLine("--- 7. IN MÃ ASCII CỦA KÝ TỰ ---");
            Console.Write("Nhập vào một ký tự: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Xuống dòng sau khi nhấn phím
            int asciiValue = ch;
            Console.WriteLine($"Ký tự '{ch}' có mã ASCII là: {asciiValue}");
        }

        // 8. Calculate Area of Circle
        private static void ExecuteCircleArea()
        {
            Console.WriteLine("--- 8. TÍNH DIỆN TÍCH HÌNH TRÒN ---");
            double radius = ReadDouble("Nhập bán kính (r): ");
            if (radius < 0)
            {
                Console.WriteLine("Bán kính không thể âm!");
                return;
            }
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Diện tích hình tròn (r={radius}) là: {area:F4}");
        }

        // 9. Calculate Area of Square
        private static void ExecuteSquareArea()
        {
            Console.WriteLine("--- 9. TÍNH DIỆN TÍCH HÌNH VUÔNG ---");
            double side = ReadDouble("Nhập chiều dài cạnh: ");
            if (side < 0)
            {
                Console.WriteLine("Cạnh không thể âm!");
                return;
            }
            double area = side * side;
            Console.WriteLine($"Diện tích hình vuông cạnh ({side}) là: {area:F4}");
        }

        // 10. Convert days to years, weeks and days
        private static void ExecuteConvertDays()
        {
            Console.WriteLine("--- 10. ĐỔI NGÀY SANG NĂM - TUẦN - NGÀY ---");
            int totalDays = ReadInteger("Nhập số ngày cần quy đổi: ");
            if (totalDays < 0)
            {
                Console.WriteLine("Số ngày không thể âm!");
                return;
            }

            // Giả định tiêu chuẩn: 1 năm = 365 ngày
            int years = totalDays / 365;
            int weeks = (totalDays % 365) / 7;
            int days = (totalDays % 365) % 7;

            Console.WriteLine($"Kết quả quy đổi của {totalDays} ngày là:");
            Console.WriteLine($"- {years} Năm");
            Console.WriteLine($"- {weeks} Tuần");
            Console.WriteLine($"- {days} Ngày");
        }

        #endregion

        #region Các hàm Helper (Xử lý an toàn dữ liệu đầu vào)

        /// <summary>
        /// Đọc một số nguyên từ Console, bắt buộc nhập đúng định dạng.
        /// </summary>
        private static int ReadInteger(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên hợp lệ!");
            }
        }

        /// <summary>
        /// Đọc một số thực double từ Console, bắt buộc nhập đúng định dạng.
        /// </summary>
        private static double ReadDouble(string message)
        {
            double value;
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.WriteLine("Lỗi: Vui lòng nhập một số thực hợp lệ!");
            }
        }

        #endregion
    }
}