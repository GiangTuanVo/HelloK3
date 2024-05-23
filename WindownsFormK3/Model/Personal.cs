using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindownsFormK3.Model
{
    class Personal
    {
        public Personal(string name, int age, string sex, string birthDay)
        {
            Name = name;
            Age = age;
            Sex = sex;
            BirthDay = birthDay;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string BirthDay { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Age}, {Sex}, {BirthDay}";
        }
    }
}
