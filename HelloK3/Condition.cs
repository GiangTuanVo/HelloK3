//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Console;

//namespace HelloK3
//{
//    public class Condition
//    {
//        static void Main(string[] args)
//        {
//            //Sử dụng tiếng việt có dấu.
//            Console.InputEncoding = Encoding.UTF8;
//            Console.OutputEncoding = Encoding.UTF8;
//            int num = 1;
//            //int year = int.Parse(ReadLine());
//            //string text = "ABC1-A10-B5-D6";
//            //string[] split = text.Split('-');
//            int thang = int.Parse(ReadLine());
            
//            switch (thang)
//            {
//                case 1:
//                    //in ngày ở đây
//                    break;
//                case 2:
//                    WriteLine("Nhập năm");
//                    int nam = int.Parse(ReadLine());
//                    if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
//                        WriteLine(29);
//                    else
//                        WriteLine(28);
//                    break;
//                case 3:
//                    break;
//                default:
//                    break;
//            }



//            float numA = 20;
//            float numB = 5;
//            string readkey = ReadLine();
//            if (readkey == "*")
//            {

//            }
//            else if (readkey == "-")
//            {

//            }


//        label01:
//            //Cấu trúc switch
//            switch(num)
//            {
//                case 1:
//                    WriteLine("Đây là số 1");
//                    break;
//                case 2:
//                    WriteLine("Đây là số 2");
//                    break;
//                default:
//                    break;
//            }

//            goto label01;
//            ReadKey();

//            /*
//            Nhập điểm văn
//            Nếu điểm toán và điểm văn > 9 hssx
//            Nếu điểm toán và điểm văn >= 8 hssg
//            Nếu điểm toán và điểm văn >= 7 hssk
//            hstb
//            */
//            //WriteLine("Nhập điểm Toán");
//            //float diemToan = float.Parse(ReadLine());
//            //WriteLine("Nhập điểm Văn");
//            //float diemVan = float.Parse(ReadLine());

//            //if (diemToan > 9 && diemVan > 0)
//            //{
//            //    WriteLine("Đây là học sinh xuất sắc");
//            //}
//            //else if (diemToan >= 8 && diemVan >= 8)
//            //{
//            //    WriteLine("Đây là học sinh giỏi");
//            //}
//            //else if (diemToan >= 7 && diemVan >= 7)
//            //{
//            //    WriteLine("Đây là học sinh khá");
//            //}
//            //else
//            //{
//            //    WriteLine("Đây là học sinh trung bình");
//            //}


//            //WriteLine("Nhập năm");

//            //string nhapTuManHinh = ReadLine();
//            //int year = int.Parse(nhapTuManHinh);

//            //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
//            //    Console.WriteLine($"{year} la năm nhuận");
//            //else
//            //    Console.WriteLine($"{year} không là năm nhuận");
//        }
//    }
//}
