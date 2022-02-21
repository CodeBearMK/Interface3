using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    internal interface IPass
    {
        int Score { get; set; }
        string Pass(int grade);
    }
}
