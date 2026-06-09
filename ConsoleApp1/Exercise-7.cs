using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_HOMEWORK
{
    internal class Exercise_7
    {
        // Bài 1: Nhập và xuất mảng
        public static void Bai1()
        {
            int[] arr = NhapMang1C();
            XuatMang1C(arr, "Kết quả");
        }

        // Bài 2: Tính tổng và trung bình cộng
        public static void Bai2()
        {
            int[] arr = NhapMang1C();
            double sum = arr.Sum();
            Console.WriteLine($"{sum:F2} {(sum / arr.Length):F2}");
        }

        // Bài 3: Tìm số lớn nhất và nhỏ nhất
        public static void Bai3()
        {
            int[] arr = NhapMang1C();
            Console.WriteLine($"{arr.Max()} {arr.Min()}");
        }

        // Bài 4: Đếm số chẵn và số lẻ
        public static void Bai4()
        {
            int[] arr = NhapMang1C();
            int chan = arr.Count(x => x % 2 == 0);
            Console.WriteLine($"{chan} {arr.Length - chan}");
        }

        // Bài 5: Tìm kiếm phần tử x
        public static void Bai5(int x)
        {
            int[] arr = NhapMang1C();
            int index = Array.IndexOf(arr, x);
            Console.WriteLine(index); // Trả về index đầu tiên tìm thấy hoặc -1
        }

        // Bài 6: Đảo ngược mảng (In-place không dùng mảng phụ - Tối ưu O(N/2))
        public static void Bai6()
        {
            int[] arr = NhapMang1C();
            int l = 0, r = arr.Length - 1;
            while (l < r)
            {
                (arr[l], arr[r]) = (arr[r], arr[l]);
                l++; r--;
            }
            XuatMang1C(arr, "Mảng sau đảo ngược");
        }

        // Bài 7: Kiểm tra mảng đối xứng (Mảng Palindrome)
        public static void Bai7()
        {
            int[] arr = NhapMang1C();
            bool check = true;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i]) { check = false; break; }
            }
            Console.WriteLine(check ? "YES" : "NO");
        }

        // Bài 8: Tách mảng chẵn lẻ
        public static void Bai8()
        {
            int[] arr = NhapMang1C();
            int[] chan = arr.Where(x => x % 2 == 0).ToArray();
            int[] le = arr.Where(x => x % 2 != 0).ToArray();
            XuatMang1C(chan, "Mảng chẵn");
            XuatMang1C(le, "Mảng lẻ");
        }
        // Bài 9: Sắp xếp mảng (Bubble Sort tăng/giảm)
        public static void Bai9(bool tangDan = true)
        {
            int[] arr = NhapMang1C();
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (tangDan ? (arr[j] > arr[j + 1]) : (arr[j] < arr[j + 1]))
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
            XuatMang1C(arr, "Mảng sau sắp xếp");
        }

        // Bài 10: Xóa phần tử tại vị trí k
        public static void Bai10(int k)
        {
            int[] arr = NhapMang1C();
            if (k < 0 || k >= arr.Length) return;
            int[] res = arr.Where((val, idx) => idx != k).ToArray();
            XuatMang1C(res, "Mảng sau khi xóa");
        }

        // Bài 11: Chèn phần tử x vào vị trí k
        public static void Bai11(int x, int k)
        {
            int[] arr = NhapMang1C();
            List<int> list = arr.ToList();
            list.Insert(Math.Clamp(k, 0, list.Count), x);
            XuatMang1C(list.ToArray(), "Mảng sau chèn");
        }

        // Bài 12: Tìm số lớn thứ hai trong mảng
        public static void Bai12()
        {
            int[] arr = NhapMang1C();
            var distinctSorted = arr.Distinct().OrderByDescending(x => x).ToArray();
            if (distinctSorted.Length < 2) Console.WriteLine("NONE");
            else Console.WriteLine($"Số lớn thứ 2: {distinctSorted[1]}");
        }

        // Bài 13: Loại bỏ các phần tử trùng lặp (Giữ lại phần tử đầu tiên)
        public static void Bai13()
        {
            int[] arr = NhapMang1C();
            int[] unique = arr.Distinct().ToArray();
            XuatMang1C(unique, "Mảng duy nhất");
        }

        // Bài 14: Gộp hai mảng đã sắp xếp thành một mảng được sắp xếp (Kỹ thuật hai con trỏ O(N+M))
        public static void Bai14(int[] a, int[] b)
        {
            int i = 0, j = 0, k = 0;
            int[] c = new int[a.Length + b.Length];
            while (i < a.Length && j < b.Length)
            {
                c[k++] = (a[i] < b[j]) ? a[i++] : b[j++];
            }
            while (i < a.Length) c[k++] = a[i++];
            while (j < b.Length) c[k++] = b[j++];
            XuatMang1C(c, "Mảng gộp");
        }

        // Bài 15: Kiểm tra mảng con
        public static void Bai15(int[] con, int[] me)
        {
            bool isSub = false;
            for (int i = 0; i <= me.Length - con.Length; i++)
            {
                if (me.Skip(i).Take(con.Length).SequenceEqual(con)) { isSub = true; break; }
            }
            Console.WriteLine(isSub ? "YES" : "NO");
        }

        // Bài 16: Dịch chuyển mảng sang trái/phải k vị trí
        public static void Bai16(int k, bool sangPhai = true)
        {
            int[] arr = NhapMang1C();
            int n = arr.Length;
            k = k % n; if (!sangPhai) k = n - k;
            int[] res = new int[n];
            for (int i = 0; i < n; i++) res[(i + k) % n] = arr[i];
            XuatMang1C(res, "Mảng sau dịch chuyển");
        }
        // Bài 17: Tìm dãy con tăng dài nhất (Thuật toán Quy hoạch động)
        public static void Bai17()
        {
            int[] arr = NhapMang1C();
            int n = arr.Length;
            int[] dp = Enumerable.Repeat(1, n).ToArray();
            for (int i = 1; i < n; i++)
                for (int j = 0; j < i; j++)
                    if (arr[i] > arr[j]) dp[i] = Math.Max(dp[i], dp[j] + 1);
            Console.WriteLine($"Độ dài dãy con tăng dài nhất: {dp.Max()}");
        }

        // Bài 18: Tìm dãy con liên tiếp có tổng lớn nhất (Thuật toán Kadane nổi tiếng - O(N))
        public static void Bai18()
        {
            int[] arr = NhapMang1C();
            long maxSoFar = arr[0], maxEndingHere = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            Console.WriteLine($"Tổng con liên tiếp lớn nhất: {maxSoFar}");
        }

        // Bài 19: Tìm cặp số có tổng bằng x (Sử dụng Kỹ thuật Two-Pointers tối ưu O(N log N))
        public static void Bai19(int x)
        {
            int[] arr = NhapMang1C();
            Array.Sort(arr);
            int l = 0, r = arr.Length - 1;
            bool found = false;
            while (l < r)
            {
                int sum = arr[l] + arr[r];
                if (sum == x) { Console.WriteLine($"Cặp số: ({arr[l]}, {arr[r]})"); found = true; l++; r--; }
                else if (sum < x) l++;
                else r--;
            }
            if (!found) Console.WriteLine("NONE");
        }

        // Bài 20: Đếm số lượng số nguyên tố trong mảng
        public static void Bai20()
        {
            int[] arr = NhapMang1C();
            int count = arr.Count(n => {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) return false;
                return true;
            });
            Console.WriteLine($"Số lượng SNT: {count}");
        }

        // Bài 21: Tìm phần tử xuất hiện độc nhất (Dùng phép toán XOR - O(N) thời gian, O(1) bộ nhớ)
        public static void Bai21()
        {
            int[] arr = NhapMang1C();
            int res = 0;
            foreach (int x in arr) res ^= x; // Các số trùng đôi một tự triệt tiêu nhau về 0
            Console.WriteLine($"Số độc nhất: {res}");
        }

        // Bài 22: Liệt kê các phần tử xuất hiện nhiều hơn n/3 lần (Thuật toán Đa số Boyer-Moore)
        public static void Bai22()
        {
            int[] arr = NhapMang1C();
            var query = arr.GroupBy(x => x).Where(g => g.Count() > arr.Length / 3).Select(g => g.Key);
            Console.WriteLine(string.Join(" ", query));
        }

        // Bài 23 & 24: Đếm tần suất và tìm phần tử xuất hiện nhiều nhất (Tối ưu O(N) bằng HashTable)
        public static void Bai23_24()
        {
            int[] arr = NhapMang1C();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int x in arr)
            {
                if (dic.ContainsKey(x)) dic[x]++; else dic[x] = 1;
            }
            // Bài 23: Tần suất
            foreach (var kv in dic.OrderBy(x => x.Key)) Console.WriteLine($"{kv.Key}: {kv.Value} lần");
            // Bài 24: Nhiều nhất
            int maxFreq = dic.Values.Max();
            var elements = dic.Where(kv => kv.Value == maxFreq).Select(kv => kv.Key);
            Console.WriteLine($"Xuất hiện nhiều nhất ({maxFreq} lần): {string.Join(", ", elements)}");
        }
        // Bài 25: Nhập và xuất ma trận
        public static void Bai25()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            Console.WriteLine("--- Ma trận vừa nhập ---");
            XuatMaTran(mat, m, n);
        }

        // Bài 26: Tính tổng tất cả các phần tử trong ma trận
        public static void Bai26()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            long sum = 0;
            foreach (int x in mat) sum += x;
            Console.WriteLine($"Tổng ma trận: {sum}");
        }

        // Bài 27: Tìm phần tử lớn nhất và nhỏ nhất của ma trận
        public static void Bai27()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            int max = int.MinValue, min = int.MaxValue;
            foreach (int x in mat)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
            Console.WriteLine($"Max: {max}, Min: {min}");
        }

        // Bài 28: Tính tổng của từng hàng và từng cột
        public static void Bai28()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            for (int i = 0; i < m; i++)
            {
                long rSum = 0;
                for (int j = 0; j < n; j++) rSum += mat[i, j];
                Console.WriteLine($"Tổng hàng {i}: {rSum}");
            }
            for (int j = 0; j < n; j++)
            {
                long cSum = 0;
                for (int i = 0; i < m; i++) cSum += mat[i, j];
                Console.WriteLine($"Tổng cột {j}: {cSum}");
            }
        }

        // Bài 29: Tìm và in ra đường chéo chính, đường chéo phụ (Ma trận vuông m = n)
        public static void Bai29()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            if (m != n) return;
            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < m; i++) Console.Write(mat[i, i] + " ");
            Console.Write("\nĐường chéo phụ: ");
            for (int i = 0; i < m; i++) Console.Write(mat[i, m - 1 - i] + " ");
            Console.WriteLine();
        }

        // Bài 30: Tính tổng các phần tử trên đường chéo chính và phụ
        public static void Bai30()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            if (m != n) return;
            long mainSum = 0, subSum = 0;
            for (int i = 0; i < m; i++)
            {
                mainSum += mat[i, i];
                subSum += mat[i, m - 1 - i];
            }
            Console.WriteLine($"Tổng DC chính: {mainSum}, Tổng DC phụ: {subSum}");
        }

        // Bài 31: Kiểm tra ma trận đối xứng qua đường chéo chính (A = A^T)
        public static void Bai31()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            if (m != n) { Console.WriteLine("NO"); return; }
            bool check = true;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < i; j++)
                    if (mat[i, j] != mat[j, i]) { check = false; break; }
            Console.WriteLine(check ? "YES" : "NO");
        }

        // Bài 32: Cộng hai ma trận cùng kích thước
        public static void Bai32()
        {
            Console.WriteLine("[Ma trận 1]"); int[,] a = NhapMaTran(out int m, out int n);
            Console.WriteLine("[Ma trận 2]"); int[,] b = NhapMaTran(out m, out n);
            int[,] c = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++) c[i, j] = a[i, j] + b[j, j];
            XuatMaTran(c, m, n);
        }
        // Bài 33: Nhân hai ma trận (Ma trận A: m x n và B: n x p -> C: m x p)
        public static void Bai33()
        {
            Console.WriteLine("[Ma Trận A]"); int[,] a = NhapMaTran(out int m, out int n);
            Console.WriteLine("[Ma Trận B]"); int[,] b = NhapMaTran(out int nB, out int p);
            if (n != nB) { Console.WriteLine("Không thể nhân ma trận!"); return; }
            int[,] c = new int[m, p];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < p; j++)
                    for (int k = 0; k < n; k++) c[i, j] += a[i, k] * b[k, j];
            XuatMaTran(c, m, p);
        }

        // Bài 34: Tìm ma trận chuyển vị (A^T kích thước n x m)
        public static void Bai34()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            int[,] trans = new int[n, m];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++) trans[j, i] = mat[i, j];
            XuatMaTran(trans, n, m);
        }

        // Bài 35: Tính tích các phần tử thuộc tam giác trên và tam giác dưới (Ma trận vuông)
        public static void Bai35()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            long tgTren = 1, tgDuoi = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j >= i) tgTren *= mat[i, j];
                    if (j <= i) tgDuoi *= mat[i, j];
                }
            }
            Console.WriteLine($"Tích TG trên: {tgTren}, Tích TG dưới: {tgDuoi}");
        }

        // Bài 36: Kiểm tra ma trận thưa (Số lượng phần tử 0 chiếm > 50%)
        public static void Bai36()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            int countZero = 0;
            foreach (int x in mat) if (x == 0) countZero++;
            Console.WriteLine(countZero > (m * n) / 2 ? "YES" : "NO");
        }

        // Bài 37: In ma trận theo hình xoắn ốc (Spiral Matrix Order)
        public static void Bai37()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            int rowStart = 0, rowEnd = m - 1, colStart = 0, colEnd = n - 1;
            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                for (int i = colStart; i <= colEnd; i++) Console.Write(mat[rowStart, i] + " ");
                rowStart++;
                for (int i = rowStart; i <= rowEnd; i++) Console.Write(mat[i, colEnd] + " ");
                colEnd--;
                if (rowStart <= rowEnd)
                {
                    for (int i = colEnd; i >= colStart; i--) Console.Write(mat[rowEnd, i] + " ");
                    rowEnd--;
                }
                if (colStart <= colEnd)
                {
                    for (int i = rowEnd; i >= rowStart; i--) Console.Write(mat[i, colStart] + " ");
                    colStart++;
                }
            }
            Console.WriteLine();
        }

        // Bài 38: Sắp xếp các phần tử trên từng dòng của ma trận tăng dần
        public static void Bai38()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            for (int i = 0; i < m; i++)
            {
                int[] tempRow = new int[n];
                for (int j = 0; j < n; j++) tempRow[j] = mat[i, j];
                Array.Sort(tempRow);
                for (int j = 0; j < n; j++) mat[i, j] = tempRow[j];
            }
            XuatMaTran(mat, m, n);
        }

        // Bài 39: Tìm ma trận con vuông k x k có tổng lớn nhất (Thuật toán toán học O(M*N) Prefix Sum 2D)
        public static void Bai39(int k)
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            long[,] pref = new long[m + 1, n + 1];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    pref[i + 1, j + 1] = mat[i, j] + pref[i, j + 1] + pref[i + 1, j] - pref[i, j];

            long maxSum = long.MinValue;
            for (int i = 0; i <= m - k; i++)
            {
                for (int j = 0; j <= n - k; j++)
                {
                    long currentSum = pref[i + k, j + k] - pref[i, j + k] - pref[i + k, j] + pref[i, j];
                    if (currentSum > maxSum) maxSum = currentSum;
                }
            }
            Console.WriteLine($"Tổng ma trận con vuông {k}x{k} lớn nhất: {maxSum}");
        }

        // Bài 40: Tìm tất cả các Điểm yên ngựa của ma trận (Min hàng kiêm Max cột)
        public static void Bai40()
        {
            int[,] mat = NhapMaTran(out int m, out int n);
            int[] minRow = new int[m];
            int[] maxCol = new int[n];
            for (int i = 0; i < m; i++) minRow[i] = int.MaxValue;
            for (int j = 0; j < n; j++) maxCol[j] = int.MinValue;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < minRow[i]) minRow[i] = mat[i, j];
                    if (mat[i, j] > maxCol[j]) maxCol[j] = mat[i, j];
                }
            }

            bool found = false;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == minRow[i] && mat[i, j] == maxCol[j])
                    {
                        Console.WriteLine($"Tìm thấy điểm yên ngựa: {mat[i, j]} tại ({i}, {j})");
                        found = true;
                    }
                }
            }
            if (!found) Console.WriteLine("NONE");
        }
    }
}
