//Ham nhap mang
        public static void GetArr(int[] arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        //Ham xuat mang
        public static void PrintArr(int[] arr)
        {
            Console.WriteLine();
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
