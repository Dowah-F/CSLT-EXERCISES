using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_HOMEWORK
{
    class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                // ==========================================
                // PHẦN 1: THAO TÁC VỚI MẢNG
                // ==========================================
                Console.WriteLine("=== PHẦN 1: THAO TÁC VỚI MẢNG SỐ NGUYÊN ===");

                // Khởi tạo mảng ngẫu nhiên
                Random rnd = new Random();
                int[] arr = new int[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(1, 20); // Random từ 1 đến 19 để dễ có số trùng lặp
                }
                Console.WriteLine($"Mảng ban đầu: {string.Join(", ", arr)}\n");

                // 1. Tính trung bình
                Console.WriteLine($"1. Trung bình cộng: {CalculateAverage(arr):F2}");

                // 2 & 3. Kiểm tra tồn tại và tìm index
                int target = arr[rnd.Next(0, arr.Length)]; // Chọn 1 số có sẵn để test
                Console.WriteLine($"2. Mảng có chứa {target} không? {ContainsValue(arr, target)}");
                Console.WriteLine($"3. Vị trí (Index) đầu tiên của {target} là: {FindIndex(arr, target)}");

                // 4. Xóa phần tử (Vì mảng trong C# có kích thước cố định, ta trả về mảng mới)
                int[] arrayAfterRemoval = RemoveFirstOccurrence(arr, target);
                Console.WriteLine($"4. Mảng sau khi xóa '{target}': {string.Join(", ", arrayAfterRemoval)}");

                // 5. Tìm Min / Max (Sử dụng Tuple của C# hiện đại để trả về 2 giá trị)
                var (min, max) = FindMinMax(arr);
                Console.WriteLine($"5. Giá trị Nhỏ nhất: {min}, Lớn nhất: {max}");

                // 6. Đảo ngược mảng (In-place swap để tối ưu bộ nhớ)
                int[] arrToReverse = (int[])arr.Clone(); // Clone để không ảnh hưởng mảng gốc cho các test sau
                ReverseArray(arrToReverse);
                Console.WriteLine($"6. Mảng đảo ngược: {string.Join(", ", arrToReverse)}");

                // 7. Tìm các giá trị trùng lặp (Sử dụng HashSet để đạt độ phức tạp O(N))
                var duplicates = FindDuplicates(arr);
                Console.WriteLine($"7. Các phần tử trùng lặp: {(duplicates.Count > 0 ? string.Join(", ", duplicates) : "Không có")}");

                // 8. Xóa phần tử trùng lặp
                int[] uniqueArray = RemoveDuplicates(arr);
                Console.WriteLine($"8. Mảng sau khi xóa trùng lặp: {string.Join(", ", uniqueArray)}\n");


                // ==========================================
                // PHẦN 2: BUBBLE SORT & LINEAR SEARCH
                // ==========================================
                Console.WriteLine("=== PHẦN 2: THUẬT TOÁN BUBBLE SORT VÀ LINEAR SEARCH ===");

                // BUBBLE SORT
                int[] userArray = new int[10];
                Console.WriteLine("Vui lòng nhập 10 số nguyên:");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Số thứ {i + 1}: ");
                    while (!int.TryParse(Console.ReadLine(), out userArray[i]))
                    {
                        Console.Write("Lỗi! Vui lòng nhập một số nguyên hợp lệ: ");
                    }
                }

                BubbleSort(userArray);
                Console.WriteLine($"\nMảng sau khi sắp xếp (Bubble Sort): {string.Join(", ", userArray)}\n");

                // LINEAR SEARCH
                Console.Write("Nhập vào một câu (sentence): ");
                string sentence = Console.ReadLine();

                Console.Write("Nhập vào từ (word) cần tìm kiếm: ");
                string searchWord = Console.ReadLine();

                bool isFound = LinearSearchWord(sentence, searchWord);
                if (isFound)
                    Console.WriteLine($"=> Từ '{searchWord}' CÓ xuất hiện trong câu.");
                else
                    Console.WriteLine($"=> Từ '{searchWord}' KHÔNG xuất hiện trong câu.");

                Console.ReadKey();
            }

            #region Các hàm cho Phần 1
            // 1. Tính trung bình
            static double CalculateAverage(int[] arr)
            {
                if (arr == null || arr.Length == 0) return 0;
                long sum = 0;
                foreach (int num in arr) sum += num;
                return (double)sum / arr.Length;
            }

            // 2. Kiểm tra tồn tại
            static bool ContainsValue(int[] arr, int value)
            {
                return FindIndex(arr, value) != -1;
            }

            // 3. Tìm Index
            static int FindIndex(int[] arr, int value)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == value) return i;
                }
                return -1;
            }

            // 4. Xóa phần tử (trả về mảng mới)
            static int[] RemoveFirstOccurrence(int[] arr, int value)
            {
                int index = FindIndex(arr, value);
                if (index == -1) return arr; // Không tìm thấy thì trả về mảng gốc

                int[] newArr = new int[arr.Length - 1];
                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (i == index) continue;
                    newArr[j++] = arr[i];
                }
                return newArr;
            }

            // 5. Tìm Min và Max (Dùng Tuple của C# 7.0+)
            static (int Min, int Max) FindMinMax(int[] arr)
            {
                if (arr == null || arr.Length == 0) throw new ArgumentException("Mảng rỗng!");
                int min = arr[0], max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min) min = arr[i];
                    if (arr[i] > max) max = arr[i];
                }
                return (min, max);
            }

            // 6. Đảo ngược mảng (In-place bằng 2 con trỏ, O(N/2))
            static void ReverseArray(int[] arr)
            {
                int left = 0, right = arr.Length - 1;
                while (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }

            // 7. Tìm phần tử trùng lặp (Dùng HashSet để tối ưu tra cứu O(1))
            static List<int> FindDuplicates(int[] arr)
            {
                HashSet<int> seen = new HashSet<int>();
                HashSet<int> duplicates = new HashSet<int>();

                foreach (int num in arr)
                {
                    if (!seen.Add(num)) // Nếu Add trả về false => đã tồn tại trong seen
                    {
                        duplicates.Add(num);
                    }
                }
                return new List<int>(duplicates);
            }

            // 8. Xóa phần tử trùng lặp (Giữ lại thứ tự xuất hiện)
            static int[] RemoveDuplicates(int[] arr)
            {
                HashSet<int> uniqueElements = new HashSet<int>();
                List<int> result = new List<int>();

                foreach (int num in arr)
                {
                    if (uniqueElements.Add(num))
                    {
                        result.Add(num);
                    }
                }
                return result.ToArray();
            }
            #endregion

            #region Các hàm cho Phần 2
            // Bubble Sort với cờ (flag) tối ưu
            static void BubbleSort(int[] arr)
            {
                int n = arr.Length;
                bool swapped;
                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            // Swap
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            swapped = true;
                        }
                    }
                    // Nếu không có phần tử nào hoán đổi, mảng đã được sắp xếp xong
                    if (!swapped) break;
                }
            }

            // Linear Search cho chuỗi
            static bool LinearSearchWord(string sentence, string targetWord)
            {
                if (string.IsNullOrWhiteSpace(sentence) || string.IsNullOrWhiteSpace(targetWord))
                    return false;

                // Tách câu thành các từ dựa trên khoảng trắng và dấu câu
                char[] separators = { ' ', '.', ',', ';', ':', '!', '?' };
                string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                // Linear search duyệt qua mảng từ vựng (không phân biệt hoa/thường)
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Equals(targetWord, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
                return false;
            }
            #endregion
        }
    }
}
}
