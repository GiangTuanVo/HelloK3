//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloK3
//{
//    public class Chuoi
//    {

//        // Funtion char test
//        static int CompareChar(char char01, char char02)
//        {
//            return char01.CompareTo(char02);
//        }
//        static bool Equals_Funtion(char char01, char char02)
//        {
//            return char01.Equals(char02);
//        }
//        static string Is_Check(char char01)
//        {
//            if (Char.IsDigit(char01)) return "Degit";
//            else if (Char.IsLetter(char01)) return "Letter";
//            else if (Char.IsNumber(char01)) return "Number";
//            else return "";
//        }
//        static char Upper_Lower(char char01)
//        {
//            if (Char.IsUpper(char01)) return Char.ToLower(char01);
//            else return Char.ToUpper(char01);
//        }

//        static void InKyTu1()
//        {
//            Console.WriteLine("________Nhập chuỗi_________");
//            string text;// Đoc text từ màn hình
//            text = Console.ReadLine();
//            for (int i = 0; i < text.Length; i++)
//            {
//                Console.WriteLine(text[i]); //Hello
//            }
//            Console.ReadKey();
//        }

//        static void InKyTu2()
//        {
//            Console.WriteLine("________Nhập chuỗi_________");
//            string text;// Đoc text từ màn hình
//            text = Console.ReadLine();// Đọc vào text
//            int length = 0;
//            char[] arr = text.ToCharArray();
//            foreach (var item in arr)
//            {
//                length += 1;
//                Console.WriteLine($"{length}:{item}");
//            }
//            Console.WriteLine($"Chieu dai chuoi: {length}");
//            Console.ReadKey();
//        }
//        //Compare
//        static int HamSoSanhChuoi(string text1, string text2)
//        {
//            return text1.CompareTo(text2);
//        }
//        //Contains
//        static bool HamContains(string text1, string txtcontain)
//        {
//            return text1.Contains(txtcontain);
//        }
//        //Funtion copyto
//        static void CopyTo(string text1, char[] arrText, int index, int begin, int lenth)
//        {
//            text1.CopyTo(index, arrText, begin, lenth);
//            foreach (var item in arrText)
//            {
//                Console.WriteLine(item);
//            }
//        }
//        //Funtion endWidth
//        static bool HamKienTraKetThucChuoi()
//        {
//            string text = "";
//            string check = "";
//            Console.WriteLine("________Nhập chuỗi_________");
//            text = Console.ReadLine();
//            Console.WriteLine("________Nhập chuỗi kiểm tra_________");
//            check = Console.ReadLine();
//            return text.EndsWith(check);
//        }
//        //Inset string
//        static string InsertString(string text1, string text2, int index)
//        {
//            return text1.Insert(index, text2);
//        }
//        //Check Indexof
//        static int FindString(int position)
//        {
//            int index = 0;
//            Console.WriteLine("Nhập chuỗi đầu vào");
//            string text = Console.ReadLine();
//            Console.WriteLine("Nhập chuỗi cần tìm");
//            string find_text = Console.ReadLine();
//            for (int i = 0; i <= position; i++)
//            {
//                if (i == 0)
//                    index = text.IndexOf(find_text);
//                if (i > 0) index = text.IndexOf(find_text, index + i);
//            }
//            return index;

//        }
//        //Funtion string test
//        static void Main(string[] args)
//        {
//            Console.InputEncoding = Encoding.UTF8;
//            Console.OutputEncoding = Encoding.UTF8;
//            //if (FindString(0) > 0)
//            //    Console.WriteLine("Có tồn tại ký tự trong chuỗi");
//            //else
//            //    Console.WriteLine("Không có tồn tại ký tự trong chuỗi");
//            string check = "FEPN3-P2.01-L6-B6-2";
//            string[] arr_split = check.Split('-');

//            Console.WriteLine(string.Join("_", arr_split));
//            //foreach (var item in arr_split)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            //string text1 = "Hello everybody !!!!!!!!!!!!!!!!";

//            //Console.WriteLine(text1.TrimStart());
//            //Console.WriteLine(text1.ToUpper());
//            //Console.WriteLine(text1.ToLower());
//            //string sub_string = text1.Substring(5, text1.Length - 5); ;
//            //Console.WriteLine(sub_string);

//            //if (text1.EndsWith(check))
//            //{
//            //    Console.WriteLine("Chuỗi kết thúc bằng {0}", check);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Chuỗi không kết thúc bằng {0}", check);
//            //}
//            //Console.WriteLine(text1.Replace("Hello", "Xin Chao"));

//            //Console.WriteLine(text1.Remove(10, text1.Length - 10));
//            //Console.WriteLine(text1.PadRight(text1.Length + 10,'*'));
//            //Console.WriteLine(text1.LastIndexOf("e"));
//            //string text2 = "Day";
//            //Console.WriteLine(InsertString(text1, text2, 6));
//            //Console.WriteLine(HamKienTraKetThucChuoi());
//            //https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
//            //int num1 = 10;
//            //int num2 = 12;
//            //string ret = String.Format("So thu nhat {0}, So thu hai {1}", num1, num2);
//            //Console.WriteLine(ret);
//            //string s = string.Format("Giá thành sản phẩm = {0:C}", 200);
//            //Console.WriteLine(s);

//            //DateTime date = new DateTime(2024, 5, 20, 10, 5, 5);

//            //DateTime dateTime = DateTime.Now;
//            ////Cách 1
//            //string text = string.Format("{0:dd/MM/yyyy HH:mm:ss}", dateTime);
//            ////Cách 2
//            //string text_datetime = dateTime.ToString("f");
//            //string text1 = "monday";

//            //Char[] arrText = new Char[text1.Length];
//            //int index = 0;//vị trí bắt lấy của chuổi
//            //int begin = 1;//vị trí bắt đầu của array
//            //int length = 3;//chiều dài ký từ muốn copy

//            //CopyTo(text1, arrText, index, begin, length);

//            //Console.WriteLine($"Ket qua: {HamContains(text1, text2)}");
//            //Console.WriteLine($"Ket qua: {HamSoSanhChuoi(text1, text2)}");


//            //InKyTu1();
//            //InKyTu2();
//            //Console.WriteLine(CompareChar('A', 'B'));//=-1
//            //Console.WriteLine(CompareChar('A', 'A'));//0
//            //Console.WriteLine(CompareChar('B', 'A'));//1
//            //Console.WriteLine(Equals('B', 'A'));//false
//            //Console.WriteLine(Equals('A', 'A'));//true
//            //Console.WriteLine(Is_Check('A'));
//            //Console.WriteLine(Is_Check('1'));
//            //Console.WriteLine(Upper_Lower('A'));
//            //string text = "ABCDGF\tHello";
//            //string path1 = "E:\\C#\\Windows Forms\\Basic\\Theory\\Bai14\\text.txt";
//            //string path2 = "E:/C#/Windows Forms/Basic/Theory/Bai14/text.txt";
//            //string path3 = @"E:\C#\Windows Forms\Basic\Theory\Bai14\text.txt";
//            //string val = File.ReadAllText(path1);
//            //Console.WriteLine(val);
//            //val = File.ReadAllText(path2);
//            //Console.WriteLine(val);
//            //val = File.ReadAllText(path3);
//            //Console.WriteLine(val);

//            //int k = 1220;
//            //string text_k = k.ToString();

//            //string text = "ABCFD";
//            //char[] arr = text.ToCharArray();

//            Console.ReadKey();
//        }
//    }
//}
