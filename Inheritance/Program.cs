using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Rectang
    {
        public Rectang(int with, int length)
        {
            With = with;
            Height = length;
        }

        public int With { get; set; }
        protected int Height { get; set; }
    }
    class Square : Rectang
    {
        public Square(int with, int length) : base(with, length)
        {
        }
    }

    interface IQuanTri
    {
        string GiaoViec(string tenViec, string tenNguoiNhan);
    }

    interface IWorked
    {
        string LamViec(string vieclam);
    }
    class SinhVien : IWorked, IQuanTri
    {
        public string HoTen { get; set; }

        public string GiaoViec(string tenViec, string tenNguoiNhan)
        {
            return tenNguoiNhan + " dang " + tenViec;
        }

        public string LamViec(string vieclam)
        {
            return "Sinh Vien " + HoTen + " dang " + vieclam;
        }
    }
    class DiLam : IWorked
    {
        public string HoTen { get; set; }
        public string LamViec(string vieclam)
        {
            return "Sinh Vien " + HoTen + " dang " + vieclam;
        }
    }

    class Car
    {
        public Car(int soBanhXe, Color mauSon)
        {
            SoBanhXe = soBanhXe;
            MauSon = mauSon;
        }

        public int SoBanhXe { get; set; }
        public Color MauSon { get; set; }

        public void MaxSpeed(int tocdo)
        {
            Console.WriteLine(tocdo);
        }
        public void MinSpeed(int tocdo)
        {
            Console.WriteLine(tocdo);
        }
        public virtual void SpeedControl(int speed)
        {
            Console.WriteLine(speed *100);
        }

    }

    class XeDap : Car
    {
        public XeDap(int soBanhXe, Color mauSon) : base(soBanhXe, mauSon)
        {
        }
        public new void MaxSpeed(int tocdo)
        {
            Console.WriteLine(tocdo);
        }
        public new void MinSpeed(int tocdo)
        {
            Console.WriteLine(tocdo);
        }
        public override void SpeedControl(int speed)
        {
            Console.WriteLine(speed);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.HoTen = "Nguyen Thi No";
            IWorked worked = sv;
            Console.WriteLine(worked.LamViec("Hoc Bai"));
            //NhanVien nhanVien = new NhanVienChinhThuc();
            //Console.WriteLine(nhanVien.TinhLuong(10));
            Console.ReadKey();
        }
    }
}
