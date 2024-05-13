using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class NhanVienThoiVu : NhanVien
    {
        public new void TinhLuong()
        {
            Console.WriteLine("NhanVienThoiVu");
        }
    }
}
