using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectInCShape.Lop;


namespace ObjectInCShape
{

    class Program
    {
        class Rectang
        {
            public int Height;
            public int Width;

            public Rectang(int height, int with)
            {
                Height = height;
                Width = with;
            }
        }
        class XeHoi//Object
        {
            //Attriute
            public Color MauXe;
            public int slBanhXe;
            //Method
            public void RunSpeed()
            {
                Console.WriteLine("100K/h");
            }
        }

        //class NhanVien
        //{
        //    //fields
        //    private string Ten;
        //    public string BoPhan;
        //    public readonly string NgaySinh="10/5/2000";
        //    public static int Luong; //Sử dụng không cần khơi tạo

        //    public void NhapTenVN(string name)
        //    {
        //        Ten = name;
        //    }
        //    public string LayThongTin()
        //    {
        //        return $"{Ten}, {BoPhan}, {Luong}, {NgaySinh}";
        //    }

        //}

        //class NhanVien
        //{
        //    //Định nghĩa Lớp kiểu POCO
        //    public string Ten { get; set; }
        //    public string BoPhan { get; set; }
        //    public string NgaySinh { get; set; }
        //    public int Luong { get; set; }

        //    public NhanVien()
        //    {
        //        //Luong = 1000000;
        //        //Contructor mặc định
        //    }
        //    public NhanVien(string Ten, string BoPhan, string NgaySinh, int Luong)
        //    {
        //        if (Ten.Length > 10)
        //        {
        //            this.Ten = Ten;
        //            this.BoPhan = BoPhan;
        //            this.NgaySinh = NgaySinh;
        //            this.Luong = Luong;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Nhap sai ten");
        //        }
        //    }
        //    public NhanVien(string ten, string ngaySinh)
        //    {
        //        Ten = ten;
        //        NgaySinh = ngaySinh;
        //    }

        //    public string LayThongTin()
        //    {
        //        return $"{Ten}, {BoPhan}, {Luong}, {NgaySinh}";
        //    }

        //}

        //class NhanVien
        //{
        //    //sử dụng thuộc tính
        //    private string ten;
        //    private string boPhan;
        //    private string ngaySinh;
        //    private int luongtheongay;
        //    public int Luong;
        //    public NhanVien()
        //    {
        //    }

        //    public NhanVien(string ten, string boPhan, string ngaySinh, int luong)
        //    {
        //        if (Check(ten))
        //        {
        //            this.ten = ten;
        //            this.boPhan = boPhan;
        //            this.ngaySinh = ngaySinh;
        //            this.luongtheongay = luong;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Nhap sai ten");
        //        }
        //    }

        //    private bool Check(string text)
        //    {
        //        if (text.Length < 10) return false;
        //        else return true;
        //    }
        //    public string Ten
        //    {
        //        get => ten;
        //        set => ten = value;
        //    }
        //    public string BoPhan
        //    {
        //        get => boPhan;
        //        set => boPhan = value;
        //    }
        //    public string NgaySinh
        //    {
        //        get => ngaySinh;
        //        set => ngaySinh = value;
        //    }
        //    public int LuongTheoNgay
        //    {
        //        get => luongtheongay;
        //        set => luongtheongay = value;
        //    }
        //    public string LayThongTin()
        //    {
        //        return $"{ten}, {boPhan}, {luongtheongay}, {ngaySinh}";
        //    }

        //    public void TinhLuong(int ngaycong)
        //    {
        //        Luong = ngaycong * luongtheongay;
        //    }
        //    public void TinhLuong(int ngaycong, int luongngay)
        //    {
        //        Luong = ngaycong * luongngay;
        //    }
        //}

        class Car
        {
            public string thuongHieu { get; set; }
            public string mauSon { get; set; }
            public Car(string thuongHieu, string mauSon)
            {
                this.thuongHieu = thuongHieu;
                this.mauSon = mauSon;
            }
            public Car Copy()
            {
                return this.MemberwiseClone() as Car;
            }
            public override string ToString()
            {
                return $"{thuongHieu}, {mauSon}";
            }
        }
        private static DateTime dateTime;
        private static int PhepCong(int a, int b)
        {
            return a + b;
        }


        public static int Sum(params int[] arr)
        {
            int s = 0;
            foreach (int x in arr)
            {
                s += x;
            }
            return s;
        }


        static void Main(string[] args)
        {
            int ret1 = Sum(1, 2, 3, 4);
            int ret2 = Sum();

            int a = 1;//gán


            Car BMW = new Car("BMW", "Đen");//cấp phát 1 vùng nhớ cho BMW

            Car BMW2 = BMW;

            BMW2.mauSon = "Do";





            Console.WriteLine(BMW.ToString());
            Console.ReadLine();


            //dateTime = DateTime.Now;

            //int ret = PhepCong(12, 20);

            //NhanVien nhanVien1 = new NhanVien();
            //NhanVien nhanVien2 = new NhanVien("Võ Văn Tèo", "5/3/1988");
            //NhanVien nhanVien3 = new NhanVien("Nguyen VănTèo", "Ky Thuat", "5/3/1988", 350000);
            //nhanVien3.TinhLuong(10);
            //Console.WriteLine(nhanVien3.Luong);
            //nhanVien3.TinhLuong(10,450000);
            //Console.WriteLine(nhanVien3.Luong);
            ////nhanVien.Ten = "Nguen Van Teo";
            ////nhanVien.BoPhan = "Ky Thuat";
            //////nhanVien.NgaySinh = "10/5/2000";
            //Console.WriteLine(nhanVien3.LayThongTin());
            //Console.ReadLine();

            //ConnectionRS232 connection0 = new ConnectionRS232();
            //ConnectionRS232 connection1 = new ConnectionRS232("COM5", 9600);
            ConnectionRS232 Adruino = new ConnectionRS232("COM6", 19200);

            Console.WriteLine("{0},{1}", Adruino.comName, Adruino.baudRate);
            bool isConnect = Adruino.Open();
            if (isConnect) Console.WriteLine("Connect OK!");
            else Console.WriteLine("Connect Fail!");

            Adruino.Write("Welcome");
            string result = Adruino.Read();
            Console.WriteLine(result);

            bool isClose = Adruino.Close();
            if (isConnect) Console.WriteLine("Close Com OK!");
            else Console.WriteLine("Close Com Fail!");

            //ConnectionRS232 LoadCell = new ConnectionRS232("COM1", 19200);

            Console.ReadKey();
            //PhanSo.number1 = 10;
            //PhanSo.number2 = 5;
            //int ret= PhanSo.PhepTru();


            //PhanSo phanSoA = new PhanSo();
            //phanSoA.tuso = 10;
            //phanSoA.mauso = 2;
            //float ret = phanSoA.PhepChia();
            //int ret= phanSoA.PhepCong(12,10);
        }
    }
}
