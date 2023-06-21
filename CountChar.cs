 //CS02-1-03: Đếm số lần xuất hiện của ký tự trong chuỗi
        public static int countCharOfStr(string str, char c)
        {
            int count = 0;
            char[] arrChar = str.ToCharArray();
            foreach (char item in arrChar)
            {
                if (item == c)
                {
                    count++;
                }
            }
            return count;
        }
