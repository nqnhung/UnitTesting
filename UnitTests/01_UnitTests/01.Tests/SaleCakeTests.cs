using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_UnitTests._01.Tests
{
    public static class SaleCakeTests
    {
        public static void TinhTienBanhNgot()
        {
			try
			{
                int num;
                Console.Write("Nhap gia tri hang chuc chua 2 chu so: ");
                num = Convert.ToInt32(Console.ReadLine());
                SaleCakeFunction saleCake = new SaleCakeFunction();

                string price = saleCake.TinhGiaTien(num);

                if (price == "10k")
                {
                    Console.WriteLine("Price: 10.000");
                    Console.WriteLine();
                }
                else if (price == "12k")
                {
                    Console.WriteLine("Price: 12.000");
                    Console.WriteLine();
                }
                else if (price == "15k")
                {
                    Console.WriteLine("Price: 15.000");
                    Console.WriteLine();
                }
                else if (price == "0")
                {
                    Console.WriteLine("Thanks for using. Bye!");
                    Environment.Exit(0);
                }
                else
                    Console.WriteLine("Khong tim thay");
            }
			catch (Exception ex)
			{
				throw new Exception($"{ex}");
			}
        }
    }
}
