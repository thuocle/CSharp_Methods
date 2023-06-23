//CS02-1-07: Tìm vị trí đầu tiên của số trong mảng
        public static void getFirstNum(int[] arr, int n)
        {
            Array.Sort(arr);
            Console.WriteLine("Mang da sap xep la: ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine($"Vi tri dau tien cua {n} la: {i}");
                    break;
                }
            }
        }
