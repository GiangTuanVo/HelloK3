//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloK3
//{
//    public class ClassArray
//    {
//        static int SearchFor(int[] number, int num, int newNumber)
//        {
//            for (int i = 0; i < number.Length; i++)
//            {
//                if (number[i] == num)
//                {
//                    number[i] = newNumber;
//                    return i;
//                }
//            }
//            return -1;
//        }
//        static int SearchForearch(int[] number, int num, int newNumber)
//        {
//            int index = 0;
//            foreach (int item in number)
//            {
//                if (item == num)
//                {
//                    number[index] = newNumber;
//                    return index;
//                }
//                ++index;
//            }
//            return -1;
//        }
//        static int[] MinMax(int[] arr)
//        {
//            int[] val = new int[2];
//            Array.Sort(arr);
//            val[0] = arr[0];
//            val[1] = arr[arr.Length - 1];
//            return val;
//        }
//        static int[] RandomArray(int length)
//        {
//            Random random = new Random();
//            int[] number = new int[length];
//            for (int i = 0; i < length; i++)
//            {
//                number[i] = random.Next(0, 100);
//            }
//            return number;
//        }

//        static int Search(int[] num_array, int number)
//        {
//            int index = 0;
//            for (int i = 0; i < num_array.Length; i++)
//            {
//                if (num_array[i] == number)
//                {
//                    index = i;
//                    break;
//                }
//            }
//            return index;
//        }


//        static void Main(string[] args)
//        {
//            //int[] Numer; // Chưa khơi tạo
//            //Numer[0] = 1;
//            //int[] num_Array = RandomArray(20);

//            //for (int i = 0; i < num_Array.Length; i++)
//            //{
//            //    num_Array[i] = num_Array[i] + 1;
//            //    Console.WriteLine("Num{0} :{1}", i, num_Array[i]);
//            //    if (i == 5) break;
//            //}

//            //int index = 1;
//            //foreach (var item in num_Array)
//            //{
//            //    num_Array[index] = num_Array[index] + 1;
//            //    Console.WriteLine("Num{0} :{1}", index, item);
//            //    if (index == 5) break;
//            //    ++index;
//            //}

//            //Console.ReadKey();



//            int[] num = new int[] { 3, 1, 45, 6, 5, 23 }; // Cấp phát vùng nhớ ;FADCF 

//            Console.WriteLine("Index can tim : {0}", Search(num, 23));
//            Console.ReadKey();



//            //Thay đổi khi 1 trong hai array thay đổi
//            //int[] number = num;//Tham chiếu
//            //number[0] = 10;

//            //Copy ra vùng nhớ khác
//            //int[] number = new int[num.Length];
//            //num.CopyTo(number, 0);
//            //number[0] = 10;
//            //
//            //Sắp xếp từ lớn tới bé

//            //Array.Sort(num);
//            //Array.Reverse(num);


//            //Console.WriteLine("SLN: {0}", num[num.Length - 1]);
//            //Console.WriteLine("SBN: {0}", num[0]);
//            //Console.ReadKey();

//            int[,] array_size; // Khai báo
//            array_size = new int[2, 2];// Khơi tạo


//            string[] text = new string[] { "Tuan", "An", "Dung" };
//            Array.Sort(text);

//            int[] ret = MinMax(num);

//            Console.WriteLine(string.Join("_", ret));

//            // Tham chiếu number tới vùng nhớ num
//            //number = num;
//            //number[0] = 10;
//            //Console.WriteLine(num[0]);
//            //num.CopyTo(number, 0);
//            //number[0] = 10;
//            //Console.WriteLine(num[0]);
//            //string[] text = new string[3];
//            //string[] text2 = new string[] { "Tuan", "Tung" };
//            //Gán giá trị
//            //num[0] = 13;//1
//            //num[1] = 12;//2
//            //num[2] = 5;//3
//            //num[3] = 10;//4
//            //num[4] = 40;//5
//            //Console.WriteLine("Index:{0}", SearchForearch(num, 3, 10));
//            //for (int i = 0; i < num.Length; i++)
//            //{
//            //    Console.WriteLine(num[i]);
//            //}
//            //Console.WriteLine("Index:{0}", SearchFor(num, 3, 10));
//            //for (int i = 0; i < num.Length; i++)
//            //{
//            //    Console.WriteLine(num[i]);
//            //}
//            //foreach (var item in num)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            Console.ReadKey();

//        }
//    }
//}
