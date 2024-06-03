using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapePLC.Model
{
    class Warning
    {
        public int No { get; set; }
        public DateTime dateTime { get; set; }
        public string Tiltle { get; set; }

        public override string ToString()
        {
            return $"{No},{dateTime}, {Tiltle}";
        }
    }
}
