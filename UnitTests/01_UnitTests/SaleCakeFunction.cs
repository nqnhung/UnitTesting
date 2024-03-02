using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_UnitTests
{
    public class SaleCakeFunction
    {
        public string TinhGiaTien(int num)
        {
            if (num == 10) return "10k";
            else if (num == 12) return "12k";
            else if (num == 15) return "15k";
            else if (num == 0) return "0";
            
            else return "not exist";
        }
    }
}
