using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class NhanVien
    {
        public int Ma { get; set; }
        public string Ten { get; set; }

        //public string LamViec(string mota)
        //{
        //    string s = "Nhân viên đang [" + mota+"]";
        //    return s;
        //}

        public void TinhLuong()
        {
            Console.WriteLine("NhanVien");
        }
        public virtual int TinhLuong(int ngayCong)
        {
            return ngayCong * 250000;
        }
    }
}
