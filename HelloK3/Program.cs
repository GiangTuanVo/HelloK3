//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace HelloK3
//{
//    class Program
//    {
//        private static void PhepCong()
//        {
//            //Clearn code
//        }
//        static void Main(string[] args)
//        {
//            //Cách 3
//            string number1 = "4.67";
//            string number2 = "567854";

//            bool check_trypare = int.TryParse(number2, out int ret);


//            if (check_trypare == true)
//            {
//                Console.WriteLine($"{ret.GetType()} : {ret}");
//            }
//            else
//            {
//                Console.WriteLine($"Convert fail!");
//            }
//            Console.ReadKey();


//            //cách 2


//            float try_num1 = float.Parse(number1);
//            Int16 try_num2 = Int16.Parse(number2);

//            Console.WriteLine($"{try_num2.GetType()} : {try_num2}");
//            Console.ReadKey();

//            //Cách 1
//            string val1 = "false"; //float,double
//            string val2 = "1232";

//            bool convert_Val = Convert.ToBoolean(val1);
//            Int16 val_Int16 = Convert.ToInt16(val2);
//            Int32 val_Int32 = Convert.ToInt32(val2);
//            Int64 val_Int64 = Convert.ToInt64(val2);

//            if (convert_Val == false)
//            {
//                Console.WriteLine(val1);
//            }
//            Console.ReadKey();


//            bool val_bool1 = true;
//            bool val_bool2 = false;

//            //Biểu thức
//            int phepcong = 4 + 5;
//            float phepchia = (float)3 / 2;

//            Int16 a = 327;
//            Int16 b = 100;

//            Int16 num_Int16 = 30000;


//            const float so_PI = 3.14f;

//            //đọc từ màn hình
//            //string text = Console.ReadLine();

//            //short num = Convert.ToInt16(text);
//            ////Ghi ra màn hình
//            ////Console.WriteLine("Tra loi: " + text);

//            //Console.WriteLine($"Tra loi: {text}");

//            /*1. Kiểu dữ liệu , 2. tên biến, 3. Giá trị củ biến*/
//            /* Tên ý nghĩa ,Phân biệt chữ hoa chữ thường, không trùng từ khoá C#, Không sử dụng ký tự đb*/
            
//            int num = 123;//16bit

//            float Num = 1.0f;
//            Console.WriteLine($" Max : {float.MaxValue}, Min : {float.MinValue}");
//            Console.WriteLine($"Kiểu dữ liệu: {num.GetType()}");
//            Console.ReadLine();


//            //float ret = num / 2; //0.5->Float (16bit)-> (32bit)

//            int val = (short)num / 2;

//            char ten = 'A';
//            char Ten = 'B';

//            string tenNhanVien = "VO TUAN";//nên

//            Int16 D0 = 10;
//            //Int16 maxInt16 = Int16.MaxValue;
//            //Int16 minInt16 = Int16.MinValue;

//            short D1 = 10;

//            UInt16 D2 = 10;
//            //UInt16 maxInt16 = UInt16.MaxValue;
//            //UInt16 minInt16 = UInt16.MinValue;

//            Int32 value_int32 = 0;

//            Int32 maxInt32 = Int32.MaxValue;
//            Int32 minInt32 = Int32.MinValue;

//            Console.WriteLine($"Min: {minInt32},Max: {maxInt32}");
//            UInt32 val_Unit32;
//            Int64 val_int64;
//            UInt64 val_Unit64;

//            long val_long;
//            ulong val_ulong;

//            float val_float = 12.34f;//32bit (2 ô nhớ)

//            double val_double = 10.46;//64bit (4 ô nhớ)



//            string maNhanVIen="";//không nên
//            int tuoiNhanVien = 0;

//            Console.ReadLine();
//        }
//    }
//}
