using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInCShape
{
    class PhanSo
    {
        //int tuso = 0;
        //int mauso = 0;
        //Thuoc tinh
        public int tuso { get; set; }
        public int mauso { get; set; }

        public static int number1 = 0;
        public static int number2 = 0;
        //private int check = 0;

        public float PhepChia()
        {
            return this.tuso / this.mauso;
        }

        public int PhepCong(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int PhepTru()
        {
            return number1 - number2;
        }
    }
}
