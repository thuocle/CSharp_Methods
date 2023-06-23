//CS02-1-09: Bài toán tính tỉ lệ xuất hiện
        public static void ratioOdd(int[] arr)
        {
            int count = 0;
            Console.Write("Cac phan tu le la: ");
            foreach (int item in arr)
            {
                if (item % 2 != 0)
                {
                    Console.Write($"{item} ");
                    count++;
                }
            }
            Console.WriteLine();
            double ratio = (count * 1.0 / arr.Length);
            Console.WriteLine($"Ti le xuat hien phan tu le la: {Math.Round(ratio * 100, 2)}%");
        }
