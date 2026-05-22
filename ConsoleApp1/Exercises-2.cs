using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_HOMEWORK
{
    //Bai1:Print Hello and Name
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello:");
            Console.WriteLine("Alexandra Abramov");
        }
    }
    //Bai2:Sum of Two Numbers
  class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine($"Sum: {sum}");
        }
    }
    //Bai3:Divide Two Numbers
    class Program
    {
        static void Main()
        {
            Console.Write("Enter dividend: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter divisor: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num2 != 0)
            {
                Console.WriteLine($"Result: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
    }
    //Bai4:Specified Operations Results
    class Program
    {
        static void Main()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
    }
    //Bai5:Swap Two Numbers
    class Program
    {
        static void Main()
        {
            Console.Write("Input the First Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            int num2 = int.Parse(Console.ReadLine());

            // Sử dụng biến tạm (phong cách sinh viên cơ bản)
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping :");
            Console.WriteLine($"First Number : {num1}");
            Console.WriteLine($"Second Number : {num2}");
        }
    }
    //Bai6:Multiply Three Numbers
    class Program
    {
        static void Main()
        {
            Console.Write("Input the first number to multiply: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            int num3 = int.Parse(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine($"{num1} x {num2} x {num3} = {result}");
        }
    }
    //Bai7:Arithmetic Operations
    class Program
    {
        static void Main()
        {
            Console.Write("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} mod {num2} = {num1 % num2}");
        }
    }
    //Bai8:Multiplication Table
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    }
    //Bai9:Average of Four Numbers
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the First number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double n3 = double.Parse(Console.ReadLine());
            Console.Write("Enter the four number: ");
            double n4 = double.Parse(Console.ReadLine());

            double average = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine($"The average of {n1}, {n2}, {n3}, {n4} is: {average}");
        }
    }
    //Bai10:Specified Formula with Three Numbers
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number - ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number - ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter third number - ");
            int z = int.Parse(Console.ReadLine());

            int res1 = (x + y) * z;
            int res2 = x * y + y * z;

            Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x+y).z is {res1} and x.y + y.z is {res2}");
        }
    }
    //Bai11:Print Age Message
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your age - ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"You look older than {age}");
        }
    }
    //Bai12:Repeat Number in Rowsusing System;
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a digit: ");
            int num = int.Parse(Console.ReadLine());

            // Cách 1: Sử dụng cấu trúc Console.Write thô
            Console.Write(num + " " + num + " " + num + " " + num + "\n");
            Console.Write(num.ToString() + num + num + num + "\n");

            // Cách 2: Sử dụng định dạng {0} như yêu cầu đề bài
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
    //Bai13:Rectangle Pattern with Number
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n}{n}{n}");
            Console.WriteLine($"{n} {n}");
            Console.WriteLine($"{n} {n}");
            Console.WriteLine($"{n} {n}");
            Console.WriteLine($"{n}{n}{n}");
        }
    }
    //Bai14:Celsius to Kelvin and Fahrenheit
    class Program
    {
        static void Main()
        {
        Console.Write("Enter the amount of celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double kelvin = celsius + 273;
        double fahrenheit = celsius * 1.8 + 32;

        Console.WriteLine($"Kelvin = {kelvin}");
        Console.WriteLine($"Fahrenheit = {fahrenheit}");
        }
    }
    //Bai15:Remove Character by Index
   class Program
    {
        static void Main()
        {
            string text = "w3resource";

            // Sử dụng hàm Remove(index, count) của class String
            Console.WriteLine(text.Remove(1, 1));
            Console.WriteLine(text.Remove(9, 1));
            Console.WriteLine(text.Remove(0, 1));
        }
    }
    //Bai16:Swap First and Last Characters
    class Program
    {
        static void Main()
        {
            Console.WriteLine(SwapChars("w3resource"));
            Console.WriteLine(SwapChars("Python"));
        }

        static string SwapChars(string str)
        {
            if (str.Length <= 1) return str;

            char first = str[0];
            char last = str[str.Length - 1];
            string middle = str.Substring(1, str.Length - 2);

            return last + middle + first;
        }
    }
    //Bai17:Add First Character to Front and Back
    class Program
    {
        static void Main()
        {
            Console.Write("Input a string : ");
            string input = Console.ReadLine();

            if (input.Length >= 1)
            {
                char firstChar = input[0];
                Console.WriteLine(firstChar + input + firstChar);
            }
        }
    }
    //Bai18:Check Positive and Negative Pair
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input first integer:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int second = int.Parse(Console.ReadLine());

            bool result = (first < 0 && second > 0) || (first > 0 && second < 0);
            Console.WriteLine($"Check if one is negative and one is positive: {result}");
        }
    }
    //Bai19:Sum or Triple Sum of Integers
    class Program
    {
        static void Main()
        {
            Console.Write("Input first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input second integer: ");
            int b = int.Parse(Console.ReadLine());

            int result = (a == b) ? (a + b) * 3 : (a + b);
            Console.WriteLine($"Result: {result}");
        }
    }
    //Bai20:Absolute Difference or Double It
   class Program
    {
        static void Main()
        {
            Console.Write("Input first number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int n2 = int.Parse(Console.ReadLine());

            int absDiff = Math.Abs(n1 - n2);

            if (n1 > n2)
            {
                Console.WriteLine($"Result: {absDiff * 2}");
            }
            else
            {
                Console.WriteLine($"Result: {absDiff}");
            }
        }
    }