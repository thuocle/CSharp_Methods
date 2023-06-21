using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharpMethods
{

    class Program
    {
        //Ham nhap mangg
        public static void GetArr(int[] arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        //Ham xuat mangg
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
        //Ham kiem tra so nguyen too
        public static bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
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

        //CS02-1-06: Bài toán đảo ngược mảng kí tự
        public static void reverseArrChar(string str)
        {
            int n = str.Length;
            char[] charArr = str.ToCharArray();
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{charArr[i]} ");
            }
        }

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

        //CS02-1-08: Tính giá trị trung bình của mảng
        public static double avgArr(int[] arr)
        {
            double avg = arr.Average();
            return avg;
        }

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

        //CS02-1-11: Thuật toán sắp xếp nổi bọt tang dan
        public static void bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        //CS02-1-12: Bài toán tính tổng bình phương max/min
        public static double squareMinMax(int[] arr)
        {
            double sum = 0;
            bubbleSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                /*double min = (double)arr[0];*/
                sum = Math.Pow(arr[0], 2) + Math.Pow(arr[arr.Length - 1], 2);
            }
            return sum;
        }

        //CS02-1-18: Tính độ dài của chuỗi trong mảng chuỗi
        public static void lengthStrArr(string[] str)
        {
            foreach (string item in str)
            {
                char[] length = item.ToCharArray();
                Console.Write(length.Length + " ");
            }
        }

        //CS02-1-02: Tính tổng các phần tử của mảng
        public static int sumArr(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }

        //Viết chương trình C# nhập một mảng số nguyên và tính tích các số nguyên tố của mảng số nguyên
        public static int productPrimeArr(int[] arr)
        {
            int product = 1;
            foreach (int item in arr)
            {
                if (isPrime(item) == true)
                {
                    product *= item;
                }
            }
            return product;
        }

        

        //CS02-1-10: Bài toán tìm số đầu tiên trong mảng chia hết cho 10
        public static void getFisrtNumDivisible10(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 10 == 0)
                {
                    Console.WriteLine($"So dau tien chia het cho 10 la: {arr[i]} o vi tri {i}");
                    break;
                }
            }
        }

        //CS02-1-04: Nhập mảng vào thực hiện chia mảng theo điều kiện
        public static void createArr(int[] arr)
        {
            int[] arrb = new int[10];
            int[] arrc = new int[10];
            int j = 0, k = 0, count = 0, count2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrb[k] = arr[i];
                    k++;
                    count++;
                }
                else
                {
                    arrc[j] = arr[i];
                    j++;
                    count2++;
                }
            }
            Console.WriteLine("Mang ban dau: ");
            PrintArr(arr);
            Console.WriteLine("Mang so chan: ");
            PrintArr(arrb);
            Console.WriteLine("Mang so le: ");
            PrintArr(arrc);
        }

        //CS02-1-15: Bài toán kiểm tra tính chất mảng
        public static void checkArr(int[] arr)
        {
            int count = 0, count2 = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    count++;
                }
                else if (arr[i] > arr[i + 1])
                {
                    count2++;
                }
            }
            if (count == arr.Length - 1)
            {
                Console.WriteLine("Mang tang dan");
            } else if (count2 == arr.Length - 1)
            {
                Console.WriteLine("Mang giam dan");
            }
            else
            {
                Console.WriteLine("Mang hon don");
            }
        }

        //CS02-1-16: Bài toán kiểm tra mảng đối xứng
        public static void isSymmetryArr(int[] arr)
        {
            bool check = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    check = false;
                }
            }
            if (check == true)
            {
                Console.WriteLine("Mang doi xung");
            }
            else
            {
                Console.WriteLine("Mang khong doi xung");
            }
        }
        /*VD: a[] = {1,4,2,6,3,9,5,7} 
        - Cac phan tu cua mang la: 1,4,2,6,3,9,5,7
        - Cac phan tu le la: 1,3,9,5,7
        - Cac phan tu le la so nguyen to la: 3,5,7
        - Tich cac so nguyen to o vi tri chan la : 2*3*5 = 30*/
        public static void summary(int[] arr)
        {
            Console.WriteLine("Cac phan tu cua mang la: ");
            PrintArr(arr);
            Console.WriteLine("Cac phan tu le la: ");
            foreach (var item in arr)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Cac phan tu le la so nguyen to: ");
            foreach (var item in arr)
            {
                if (item % 2 != 0 && isPrime(item))
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && isPrime(arr[i]) && i % 2 == 0)
                {
                    product *= arr[i];
                }
            }
            Console.WriteLine("Tich Cac phan tu le la so nguyen to o vi tri chan: {0}", product);
        }

        //CS02-1-19: Sắp xếp mảng chuỗi
        public static void sortStrArr(string[] s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].Length < s[j].Length)
                    {
                        string tmp = s[i];
                        s[i] = s[j];
                        s[j] = tmp;
                    }
                }
            }
            foreach (string item in s)
            {
                Console.Write($"{item}, ");
            }
        }

        //Cho một mảng số nguyên gồm n phần tử. Sắp xếp các phần tử chẵn tăng dần, phần tử lẻ giảm dần
        public static void sortEvenOdd(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j] && arr[i] % 2 == 0 && arr[j] % 2 == 0)
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    } else if (arr[i] < arr[j] && arr[i] % 2 != 0 && arr[j] % 2 != 0)
                    {
                        int tmp2 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp2;
                    }
                }
            }
            PrintArr(arr);
        }

        //Cho một mảng số nguyên gồm n phần tử. Sắp xếp các phần tử lẻ theo thứ tự tăng dần,
        //các phần tử còn lại giữ nguyên vị trí
        public static void sortOdd(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j] && arr[i] % 2 != 0 && arr[j] % 2 != 0)
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            PrintArr(arr);
        }
        //CS-List-01: Khai báo danh sách cơ bản in DS
        public static void printList(List<int> listDS)
        {
            /*List<int> listDS = new List<int>();*/
            /*int n = listDS.Count;*/
            foreach (int item in listDS)
            {
                Console.Write(item + " ");
            }
        }

        //CS-List-03: Bài tập in một danh sách là đảo ngược của 1 danh sách truyền vào
        public static void reverseList(List<string> listStr)
        {
            listStr.Reverse();
            foreach (var item in listStr)
            {
                Console.Write(item + " ");
            }
        }

        //CS02-2-02: Xoá phần tử trong danh sách
        public static void removeOfList(List<int> listDS)
        {
            bool check = true;
            Console.WriteLine("Nhap vao so x muon xoa: ");
            int x = int.Parse(Console.ReadLine());

            while (check == true)
            {
                Console.WriteLine("Khong co so {0} trong List", x);
                Console.WriteLine("Nhap vao so x muon xoa: ");
                x = int.Parse(Console.ReadLine());
                foreach (int item in listDS)
                {
                    if (item == x)
                    {
                        check = false;
                    }
                }
            }
            listDS.Remove(x);
            printList(listDS);
        }

        //CS02-2-04: Tìm Min, Max trong danh sách
        static void minMaxList(List<int> listDS)
        {
            int min = listDS.Min();
            int max = listDS.Max();
            Console.WriteLine("GTNN la {0}", min);
            Console.WriteLine("GTLN la {0}", max);
        }

        //CS-List-04: Bài tập in các chuỗi có độ dài lớn hơn n từ một danh sách chuỗi truyền vào.
        static void printStrOfList(List<string> listStr)
        {
            Console.WriteLine("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            foreach (string item in listStr)
            {
                if (item.Length > n)
                {
                    Console.Write(item + ", ");
                }
            }
        }

        //CS02-2-01: Thay thế phần tử trong danh sách
        static void replaceList(List<int> listDS)
        {
            for (int i = 0; i < listDS.Count; i++)
            {
                if (listDS[i] < 0)
                {
                    listDS[i] = 0;
                }
            }
            printList(listDS);
        }

        //Kiem tra number co cac chu so tang dan vd: 12345, 3456,...
        static bool isNumAscending(int n)
        {
            int count = 0;
            char[] charArr = n.ToString().ToCharArray();
            for (int j = 0; j < charArr.Length - 1; j++)
            {
                if ((int)charArr[j] <= (int)charArr[j + 1])
                {
                    count++;
                }
            }
            if (count == charArr.Length - 1)
            {
                return true;
            }

            return false;
        }
        //tim cac so tang dan trong list
        static void getNumAscendingOfList(List<int> listDS)
        {
            Console.WriteLine("Cac so tang trong danh sach: ");
            foreach (int item in listDS)
            {
                if (isNumAscending(item))
                {
                    Console.Write(item + " ");
                }
            }
        }

        //Cho một danh sách các số nguyên: 
        /*-      Tạo ra một list mới mà mỗi phần tử trong đó bằng bình phương của lần lượt các phần tử trong danh sách cũ.
          -     Kiểm tra xem trong danh sách mới có bao nhiêu phần tử lớn hơn 20.*/

        static void listSN(List<int>listDS)
{
            List<int> listDS2 = new List<int>();
            int count = 0;
            for (int i = 0; i < listDS.Count-1; i++)
            {
                listDS2.Add(listDS[i] * listDS[i]);
            }
            foreach (var item in listDS2)
            {
                Console.WriteLine(item + " ");
                if (item > 20)
                {
                    count++;
                }
            }
            Console.WriteLine("So phan tu lon hon 20: {0}", count);
}
        //Cho danh sách C sau: { "Cam", "Quyt", "Mit", "Dua", "Dua", "Le", "Tao", "Oi" }.
        //Viết chương trình sắp xếp các chuỗi trên theo thứ tự bảng chữ cái từ a -> z
        //sau đó in danh sách C ra màn hình
        static void sortStr(List<string> listStr)
        {
            listStr.Sort();
            foreach (string item in listStr)
            {
                Console.WriteLine(item + " ");
            }
        }

        //CS-Hàm-10: Hàm đếm số khoảng trống trong một chuỗi
        static int countBlankStr(string str)
        {
            int count = 0;
            char[] charArr = str.ToCharArray();
            foreach (char item in charArr)
            {
                if (item == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        //Cho 2 số thực a, b. Viết hàm để tính tích 2 số thực
        static double product2Num(double a, double b)
        {
            double product = a * b;
            return product;
        }
        //CS02-3-02: Hàm nhập xuất cơ bản

        //Cho số nguyên dương n. Viết hàm kiểm tra số đó có phải là số chính phương không?
        //Số chính phương là bình phương của một số tự nhiên.Ví dụ: 4,9 là số chính phương(4=2^2, 9=3^2)
        static bool isSqrtNum(int n)
        {
            if (Math.Sqrt(n) % 1 == 0)
            {
                return true;
            }
            return false;
        }

        //CS02-3-04: Hàm nhập một số nguyên
        static void nhapN()
        {
            Console.WriteLine("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            while (n<0)
            {
                Console.WriteLine("Khong hop le! Nhap n nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("So vua nhap la: {0}", n);
        }

        //CS02-3-06: Hàm sinh ngẫu nhiên số nguyên
        static int createRandomNum()
        {
            Random rand = new Random();
            return rand.Next(0, 9999999);
        }

        //CS-Hàm-09: Hàm hiển thị danh sach chuỗi nhập vào từ bàn phím
        static void PrintListS()
        {
            Console.WriteLine("So chuoi muon nhap: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cac chuoi: ");
            string[] s = new string[10];
            
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }

        // Ham kiem tra quy cach nhap lieu
        static void checkInput()
        {
            Console.WriteLine("Nhap so nguyen trong khoang tu 2 den 100: ");
            int n;
            string s = Console.ReadLine();
            
            while(int.TryParse(s, out n)==false)
            {
                Console.WriteLine("Sai quy cach, nhap lai: ");
                s = Console.ReadLine();
            }
            n = int.Parse(s);
            while(!(n>0 && n<100))
            {
                Console.WriteLine("Nhap lai: ");
                s = Console.ReadLine();
                if(int.TryParse(s, out n)== true)
                {
                    n = int.Parse(s);
                }
            }
            Console.WriteLine($"{s}");
        }

        //Viết hàm nhập một chuỗi và trả lại chuỗi nhập được có độ dài trong một khoảng cho trước.
        //Yêu cầu khi nhập liệu: Nếu sai khoảng giá trị cũng cần báo ra thông điệp lỗi

        static void checkStr()
        {
            string msg = "Nhap dung!";
            string err = "Nhap sai!";
            Console.WriteLine("Nhap chuoi tren 8 ky tu va it hon 20 ky tu:");
            string s = Console.ReadLine();
            while(s.Length < 8 || s.Length > 20)
            {
                Console.WriteLine(err + "Nhap chuoi tren 8 ky tu va it hon 20 ky tu:");
                s = Console.ReadLine();
            }
            Console.WriteLine($"{msg} {s}");
        }

        //Viết hàm nhập một ngày tháng (DateTime) và trả lại ngày tháng nhập được trong một khoảng cho trước.
        //Yêu cầu khi nhập liệu: Cần kiểm tra được quy cách nhập liệu, nếu sai quy cách thì báo ra.
        //Nếu sai khoảng giá trị cũng cần báo ra thông điệp lỗi

        static void checkDate()
        {
            bool check;
            DateTime date;
            DateTime min = new DateTime(2023, 01, 01);
            DateTime max = new DateTime(2023, 12, 31);
            do
            {
                Console.WriteLine("Nhap vao ngay thang nam: ");
                check = DateTime.TryParse(Console.ReadLine(), out date);
                if (!check)
                {
                    Console.WriteLine("Sai dinh dang!");
                }
                check = check && date > min && date < max;
                if (!check)
                {
                    Console.WriteLine("Khong thoa man dieu kien!");
                }
            } while (!check);
            Console.WriteLine(date.ToShortDateString());
        }

        //Cho ma trận số nguyên mxn. Hãy xây dựng hàm nhập, hiển thị ma trận này.
        static void printArrMatrix(int[,] matrix, int n, int m)
        {
          
            Console.WriteLine("Nhap cac phan tu: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"[{i}][{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Ma tran da nhap: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"[{i}][{j}] = {matrix[i, j]}     ");
                    if (j == m - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        //CS-Hàm-12: Hàm tính tích 2 ma trận
        static void productMatrix()
        {
            int i, j, k, r1, c1, r2, c2, sum = 0;
            int[,] matrix1 = new int[50, 50];
            int[,] matrix2 = new int[50, 50];
            int[,] ma_tran_tich = new int[50, 50];
            Console.WriteLine("Nhap kich thuoc ma tran thu nhat: ");
            r1 = int.Parse(Console.ReadLine());
            c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap kich thuoc ma tran thu hai: ");
            r2 = int.Parse(Console.ReadLine());
            c2 = int.Parse(Console.ReadLine());
            if(c1 != r2)
            {
                Console.WriteLine("vi pham nguyen tac nhan ma tran");
            }
            else
            {
                Console.WriteLine("MA TRAN 1:");
                printArrMatrix(matrix1, r1, c1);
                Console.WriteLine("MA TRAN 2:");
                printArrMatrix(matrix2, r2, c2);
                //nhan hai ma tran
                for (i = 0; i < r1; i++)
                    for (j = 0; j < c2; j++)
                        ma_tran_tich[i, j] = 0;
                for (i = 0; i < r1; i++)    //hang cua ma tran thu nhat 
                {
                    for (j = 0; j < c2; j++)    //cot cua ma tran thu hai 
                    {
                        sum = 0;
                        for (k = 0; k < c1; k++)
                            sum = sum + matrix1[i, k] * matrix2[k, j];
                        ma_tran_tich[i, j] = sum;
                    }
                }
                Console.Write("\nMa tran tich cua hai ma tran tren la: \n");
                for (i = 0; i < r1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("{0}\t", ma_tran_tich[i, j]);
                    }
                }
            }
            
        }
        //CS02-1-21: Chuẩn hóa chuỗi
        //“   NgUyen VaN   An    ”    => AnNV @hvitclan.vn
        static void verifyEmail(string str)
        {
            string tmp = str.Trim().ToLower();//cat khoang trang 2 dau
            while (tmp.Contains("  "))
            {
                tmp = tmp.Replace("  ", " ");
            }
            string[] s = tmp.Split(' ');// cat cac tu
            int n = s.Length;
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            /*if (n == 1)
            {
                result = s[0];
            }
            else
            {
                char[] reSultArr = s[n - 1].ToCharArray();//1: lay ra ten -> mang char 2:ky tu dau in hoa
                string tm = reSultArr[0].ToString();
                reSultArr[0] = char.Parse(tm.ToUpper());
                result = new string(reSultArr);
                for (int i = 0; i <= n - 2; i++)
                {
                    result = result + s[i][0].ToString().ToUpper();// lay cac chu dau cua ho va ten dem in hoa
                }
            }
            result = string.Concat(result, "@hvitclan.vn");*/
           /* return result;*/
            /*Console.WriteLine("email: {0}", result);*/
        }
        /*Viết hàm trả lại danh sách các chuỗi tên người đã được chuẩn hoa từ một danh sách đầu vào. 
         * Yêu cầu chuẩn hóa: Đầu và cuối chuỗi cùng với giữa các từ không có dấu cách, 
         * ký tự đầu viết hoa, có ít nhất 2 từ.*/
        //chuan hoa chuoi ten
        static string verifyName(string str)
        {
            string tmp = str.Trim().ToLower();
            while (tmp.Contains("  "))
            {
                tmp = tmp.Replace("  ", " ");
            }
            string[] s = tmp.Split(' ');
            string nameResult = "";
            foreach (var item in s)
            {
                nameResult += item.Substring(0, 1).ToUpper() + item.Substring(1);
            }
            return nameResult;
        }
        //CHo cac ten da chuan hoa vao list
        static void listNameVerified()
        {
            List<string> listName = new List<string>() { "   nGuyeN   vAN   nAm  ", "  NGuyen  Van qUANG  " };
            List<string> newList = new List<string>();
            foreach (var item in listName)
            {
                newList.Add(verifyName(item));
            }
            Console.WriteLine("Cac chuoi da chuan hoa: ");
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }

        //CS02-3-05: Lấy ra ký tự giữa chuỗi
        static void getMidCharStr(string str)
        {
            int n = str.Length;
            if(n %2 == 0)
            {
                Console.WriteLine("Ky tu giua chuoi la: ");
                Console.Write(str.Substring((n/2)-1, 2));
            }
            else
            {
                Console.WriteLine("Ky tu giua chuoi la: ");
                Console.WriteLine(str.Substring((n-1)/2, 1));
            }
        }

        //Đầu vào: 1 chuỗi là họ tên và có dạng chưa chuẩn hóa . Ví dụ: " Nguyen van     a "
        //Đầu ra: 1 chuỗi là họ tên có dạng "Nguyen van a"
        static void processStr2()
        {
            Console.WriteLine("Nhap ho ten:");
            string str = Console.ReadLine();
            str = str.Trim();
            while(str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            Console.WriteLine("Chuoi da chuan hoa la \n{0}", str);
        }


        //CS02-3-09: In một danh sách là đảo ngược của 1 danh sách truyền vào

        static void reverseList()
        {
            List<string> liststr = new List<string>() { "Nguyen Duc Toan", "Nguyen Hoang Truong", "Nguyen Dong Khanh" };
            liststr.Reverse();
            foreach (var item in liststr)
            {
                Console.Write(item + ", ");
            }
        }

        //Viết hàm trả lại danh sách các chuỗi email cá nhân của hvitclan từ một danh sách chuỗi truyền vào.
        //Nếu có email bị trùng thì thêm số đếm vào sau tên 
        //chuan hoa chuoi ten
        static string verifyNameOfEmail(string str)
        {
            string tmp = str.Trim().ToLower();
            while (tmp.Contains("  "))
            {
                tmp = tmp.Replace("  ", " ");
            }
            string[] s = tmp.Split(' ');
            int n = s.Length;
            string resulName = s.Last();
            for (int i = 0; i <= n-2; i++)
            {
                resulName = resulName + s[i].Substring(0, 1);
            }
            return resulName;
        }
        static List<string> verifyListEmail(List<string> listName)
        {
            int count = 1;
            List<string> newList = new List<string> { };
            listName.ForEach(x => newList.Add(verifyNameOfEmail(x)));
            for (int i = 0; i < newList.Count-1; i++)
            {
                for (int j = i+1; j < newList.Count; j++)
                {
                    if(string.Compare(newList[i], newList[j]) == 0)
                    {
                        newList[j] = newList[j] + count.ToString();
                        count++;
                    }
                }
                newList[i]  += "@hvitclan";
            }
            newList[newList.Count-1] = newList[newList.Count - 1] + "@hvitclan";
            return newList;
            /*nameResult = string.Concat(nameResult, "@hvitclan.vn");*/
        }

        //Đầu vào: 2 biến kiểu DateTime
        //Đầu ra: Những ngày thứ 4 trong khoảng 2 ngày đó
        //VD: 4/5/2020 - 17/5/2020 có 2 ngày thứ 4 đó là 6/5/2020 và 13/5/2020
        static List<DateTime> dayOfWeek(DateTime startday, DateTime endday)
        {
            List<DateTime> listWeds = new List<DateTime> { };
            DateTime date = startday;
            while(date.DayOfWeek != DayOfWeek.Wednesday)
            {
                if (date > endday) return null;
                date = date.AddDays(1);
            }
            /*do
            {
                listWeds.Add(date);
                date = date.AddDays(7);
            } while (date <= endday);*/
            while(date <= endday)
            {
                listWeds.Add(date);
                date = date.AddDays(7);
            }
            return listWeds;
        }
        static void Main(string[] args)
        {
            /*char c;
            int n;
            int[] arr = new int[] { 10,9,8,7,6,5,4,3,2,1 };
            *//*string[] s = { "dsadasdasd", "dsada", "ưeqeqweqwewqeewqeww", "fsdfaasf" };*//*
            List<int> listDS = new List<int>() {1,2,3,4,5,6,7,8,9};
            List<string> listStr = new List<string>() { "Cam", "Quyt", "Mit", "Dua", "Dua", "Le", "Tao", "Oi" };*/
            List<string> list = new List<string> { "Nguyen Duc Toan", "Nguyen Hoang Truong", "Nguyen Dong Khanh", "Nguyen Duc Toan", "Nguyen Duc Toan" };
            /*verifyListEmail(list).ForEach(x => Console.WriteLine(x));*/
            DateTime max = new DateTime(2023,06,06);
            DateTime min = new DateTime(2023,05,01);
            dayOfWeek(min, max).ForEach(x => Console.WriteLine(x.ToShortDateString()));
        }
    }
}
