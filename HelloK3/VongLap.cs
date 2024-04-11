//using System;
//using System.Text;
//using System.Windows.Forms;
//using static System.Console;

//namespace HelloK3
//{
//    public class CacPhepToan
//    {
//        public float PhepCong(float num1, float num2)
//        {
//            return num1 + num2;
//        }

//    }
//    public class VongLap
//    {
//        //public static int number = 0;
//        static void HocDoWhile()
//        {
//            WriteLine("");
//            WriteLine("Vui lần nhập số");
//            string readline = ReadLine();
//            int input = int.Parse(readline);
//            int number = 0;
//            do
//            {
//                ++number;
//                if (number == 5) continue;

//                WriteLine($"Sô thứ {number}: {number}");
//                if (number >= input) break;
//            } while (true);
//        }

//        static void TestBreak()
//        {
//            string[] test = new string[] { "Nam", "Hà", "Hiển", "Huy" };
//            int index = 0;
//            do
//            {
//                //if(test[index] == "Hà")
//                //{
//                //    WriteLine(test[index]);
//                //    break;
//                //}

//                if (test[index] == "Hà")
//                {
//                    ++index;
//                    continue;
//                }
//                WriteLine(test[index]);
//                ++index;
//            } while (index < test.Length);
//        }

//        static void HocWhile()
//        {
//            WriteLine("Vui lần nhập số");
//            string readline = ReadLine();
//            int input = int.Parse(readline);
//            int number = 0;
//            while (number < input)
//            {
//                ++number;
//                if (number == 5) continue;
//                WriteLine($"Sô thứ {number}: {number}");
//            }
//        }
//        static void HocFor()
//        {
//            WriteLine("Vui lần nhập số");
//            string readline = ReadLine();
//            int input = int.Parse(readline);
//            for (int i = 1; i <= input; i++)
//            {
//                WriteLine($"Sô thứ {i}: {i}");
//            }
//        }

//        //Viết đoạn code dùng vòng lặp for 
//        //nhập số 10 từ bàn phím
//        //1. in ra màn hình từ 1 đến 10
//        //2. in đến số  thì thoát khỏi vòng lặp
//        //3. không in số 3
//        static void HocForeach()
//        {
//            //string[] test = new string[] { "Nam", "Hà", "Hiển", "Huy" };
//            string text = "ABCDEFGHKLMN";
//            foreach (char item in text)
//            {
//                if (item == 'E') break;
//                WriteLine(item);
//            }
//        }

//        static void HocGoTo() //Hàm thủ tục
//        {
//            HocForeach();
//            WriteLine("Vui lần nhập số");
//            string readline = ReadLine();
//            int input = int.Parse(readline);
//            int number = 0;
//        label01:
//            ++number;
//            WriteLine($"Sô thứ {number}: {number}");
//            if (number < input)
//                goto label01;
//        }

//        static int PhepCong(int num1, int num2)//parameter
//        {
//            return num1 + num2;
//        }
//        //Tham số hình thức(không có giá trị) để truyền giá trị vào khi gọi
//        static float PhepChia(float num1, float num2)
//        {
//            //short -> 16bit
//            //float ->32bit
//            //int ->32bit
//            num1 = 2;
//            return (float)num1 / num2;
//        }


//        //REF
//        static float TinhCanhHuyen1(float a, float b, ref float ret)
//        {
//            //ret = (float)Math.Sqrt(a * a + b * b);
//            //return ret;
//            return (float)Math.Sqrt(a * a + b * b);
//        }
//        //OUT
//        static float TinhCanhHuyen2(float a, float b, out float ret)
//        {
//            ret = (float)Math.Sqrt(a * a + b * b);
//            return ret;
//        }


//        static void Main(string[] args)
//        {
//            Console.InputEncoding = Encoding.UTF8;
//            Console.OutputEncoding = Encoding.UTF8;

//            try
//            {
//                WriteLine("Vui lần nhập số");
//                int read_Num = int.Parse(ReadLine());
//            }
//            catch (Exception ex)
//            {
//                //throw ex;
//                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
//                /////Environment.Exit(0);
//            }



//            Random random = new Random();
//            while (true)
//            {
//                WriteLine("Nhập số bạn muốn đoán vào");
//                int num_Doan = int.Parse(ReadLine());
//                int machine_Create = random.Next(1, 10);
//                if(num_Doan== machine_Create)
//                {
//                    WriteLine("Đoán đúng rồi");
//                    break;
//                }
//                else
//                {
//                    WriteLine("Bạn đã đoán sai, vui lòng đoán lại");
//                }
//            }

//            DateTime date = new DateTime(2024, 4, 8);
//            string dateTime = date.ToString("yyyy/MM/dd hh-mm");
//            DateTime time = DateTime.Now;

//            float test_Round = 1.2456734f;
//            test_Round = (float)Math.Round((double)test_Round, 3);

//            int num = int.Parse(ReadLine());

            
//            //
//            CacPhepToan phepToan = new CacPhepToan();
//            float valFuntion = phepToan.PhepCong(1, 2);

//            //Để viết được tiếng việt

//            //HocDoWhile();
//            //TestBreak();
//            //HocWhile();
//            //HocFor();
//            //HocForeach();
//            //HocGoTo();
//            //int ret1 = PhepCong(12, 20);
//            //WriteLine(ret1);
//            //int ret2 = PhepCong(13, 40);
//            //WriteLine(ret2);
//            // Giá trị truyền vào
//            float num1 = 1;
//            float num2 = 2;

//            float ret = 0;
//            //float val = PhepChia(num1, num2);
//            float value1 = TinhCanhHuyen1(num1, num2, ref ret);
//            float value2 = TinhCanhHuyen2(num1, num2, out float ret1);
//            ReadKey();
//        }
//    }
//}
