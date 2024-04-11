using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloK3
{
    public class Chuoi
    {

        // Funtion char test
        static int CompareChar(char char01, char char02)
        {
            return char01.CompareTo(char02);
        }
        static bool Equals_Funtion(char char01, char char02)
        {
            return char01.Equals(char02);
        }
        static string Is_Check(char char01)
        {
            if (Char.IsDigit(char01)) return "Degit";
            else if (Char.IsLetter(char01)) return "Letter";
            else if (Char.IsNumber(char01)) return "Number";
            else return "";
        }
        static char Upper_Lower(char char01)
        {
            if (Char.IsUpper(char01)) return Char.ToLower(char01);
            else return Char.ToUpper(char01);
        }

        static void InKyTu1()
        {
            Console.WriteLine("________Nhập chuỗi_________");
            string text;// Đoc text từ màn hình
            text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]); //Hello
            }
            Console.ReadKey();
        }

        static void InKyTu2()
        {
            Console.WriteLine("________Nhập chuỗi_________");
            string text;// Đoc text từ màn hình
            text = Console.ReadLine();// Đọc vào text
            int length = 0;
            char[] arr = text.ToCharArray();
            foreach (var item in arr)
            {
                length += 1;
                Console.WriteLine($"{length}:{item}");
            }
            Console.WriteLine($"Chieu dai chuoi: {length}");
            Console.ReadKey();
        }
        //Compare
        static int HamSoSanhChuoi(string text1, string text2)
        {
            return text1.CompareTo(text2);
        }
        //Contains
        static bool HamContains(string text1, string txtcontain)
        {
            return text1.Contains(txtcontain);
        }
        //Funtion copyto
        static void CopyTo(string text1, char[] arrText, int index, int begin, int lenth)
        {
            text1.CopyTo(index, arrText, begin, lenth);
            foreach (var item in arrText)
            {
                Console.WriteLine(item);
            }
        }
        //Funtion endWidth
        static bool HamKienTraKetThucChuoi()
        {
            string text = "";
            string check = "";
            Console.WriteLine("________Nhập chuỗi_________");
            text = Console.ReadLine();
            Console.WriteLine("________Nhập chuỗi kiểm tra_________");
            check = Console.ReadLine();
            return text.EndsWith(check);
        }
        //

        //Funtion string test
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine(HamKienTraKetThucChuoi());

            int num1 = 10;
            int num2 = 12;
            string ret = String.Format("So thu nhat {0}, So thu hai {1}", num1, num2);
            Console.WriteLine(ret);
            string s = string.Format("Giá thành sản phẩm = {0:C}", 200);
            Console.WriteLine(s);

            //string text1 = "monday";

            //Char[] arrText = new Char[text1.Length];
            //int index = 0;//vị trí bắt lấy của chuổi
            //int begin = 1;//vị trí bắt đầu của array
            //int length = 3;//chiều dài ký từ muốn copy

            //CopyTo(text1, arrText, index, begin, length);

            //Console.WriteLine($"Ket qua: {HamContains(text1, text2)}");
            //Console.WriteLine($"Ket qua: {HamSoSanhChuoi(text1, text2)}");


            //InKyTu1();
            //InKyTu2();
            //Console.WriteLine(CompareChar('A', 'B'));//=-1
            //Console.WriteLine(CompareChar('A', 'A'));//0
            //Console.WriteLine(CompareChar('B', 'A'));//1
            //Console.WriteLine(Equals('B', 'A'));//false
            //Console.WriteLine(Equals('A', 'A'));//true
            //Console.WriteLine(Is_Check('A'));
            //Console.WriteLine(Is_Check('1'));
            //Console.WriteLine(Upper_Lower('A'));
            //string text = "ABCDGF\tHello";
            //string path1 = "E:\\C#\\Windows Forms\\Basic\\Theory\\Bai14\\text.txt";
            //string path2 = "E:/C#/Windows Forms/Basic/Theory/Bai14/text.txt";
            //string path3 = @"E:\C#\Windows Forms\Basic\Theory\Bai14\text.txt";
            //string val = File.ReadAllText(path1);
            //Console.WriteLine(val);
            //val = File.ReadAllText(path2);
            //Console.WriteLine(val);
            //val = File.ReadAllText(path3);
            //Console.WriteLine(val);

            //int k = 1220;
            //string text_k = k.ToString();

            //string text = "ABCFD";
            //char[] arr = text.ToCharArray();

            Console.ReadKey();
        }
    }
}
