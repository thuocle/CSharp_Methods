 //CS02-1-06: Bài toán đảo ngược mảng kí tự/
        public static void reverseArrChar(string str)
        {
            int n = str.Length;
            char[] charArr = str.ToCharArray();
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{charArr[i]} ");
            }
        }
