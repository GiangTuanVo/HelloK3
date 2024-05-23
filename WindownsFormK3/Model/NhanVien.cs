using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindownsFormK3.Model
{
    class NhanVien
    {
        public NhanVien(string name,string sex, int mNV, string birthDay)
        {
            Name = name;
            MNV = mNV;
            Sex = sex;
            BirthDay = birthDay;
        }

        public string Name { get; set; }
        public int MNV { get; set; }
        public string Sex { get; set; }
        public string BirthDay { get; set; }

        public override string ToString()
        {
            return $"{Name}, {MNV}, {Sex}, {BirthDay}";
        }
    }
}
