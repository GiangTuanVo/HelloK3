﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapePLC.Model
{
    class ReadPLC
    {
        public DateTime dateTime { get; set; }
        public short Value { get; set; }

        public override string ToString()
        {
            return $"{dateTime}, {Value}";
        }
    }
}
