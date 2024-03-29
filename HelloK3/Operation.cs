using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloK3
{
    class Operation
    {
        static void Main(string[] args)
        {
            //
            var value = false;

            var a = int.Parse(ReadLine());

            object b = int.Parse(ReadLine());

            WriteLine(a.GetType());
            WriteLine(b.GetType());
            ReadKey();

            



            //if (!(a > b))
            //{
            //    Write("Lon hon");
            //}
            //else
            //{
            //    Write("Nho hon");
            //}

            ReadKey();
            //if (!(a > b))
            //{

            //}

            //bool k = true;
            //if (k)
            //{
            //    Write("DK True");
            //}
            //if(!k)
            //{
            //    Write("DK False");
            //}
            //ReadKey();
            ////Toán tử 1 ngôi
            //int a = 10;
            //int b = 5;



            //Prefit
            //++a;
            //--a;
            //Postfit
            //a++;
            //a--;

            //1.Prefit
            //2.Các phép toán
            //3.Gán
            //Postfit
            //       11     4
            //int c = ++a - --b;
            int d = a++ - b--;
            WriteLine(d);
            WriteLine(a);
            Write(b);
            
            //Toán tử số học
            //int a = +10;
            //double b = Math.Round((double)10 / 3,2);
            //float c = (float)Math.PI * 2;

            //int d = 5 % 2;
            //WriteLine(d);
            ReadKey();

            //string num = "5.5";
            ////biến đổi num về đúng kiểu giá trị có tên "value" 
            ////value+=5;
            ////value-=5;
            ////value*=5;
            ////value/=5;
            //int a = 10;
            //a += 2;// a=a+2;
            //WriteLine(a);
            //a -= 1;//a=a-1;
            //WriteLine(a);
            //a *= 2;//a=a*2
            //a /= 2;//a=a/2;
            //ReadKey();
        }
    }
}
