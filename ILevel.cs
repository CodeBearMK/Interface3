using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    internal interface ILevel
    {
        int High { get; set; }
        int Low { get; set; }
        string Level(int grade);
    }
}
