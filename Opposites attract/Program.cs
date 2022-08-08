using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opposites_attract
{
    class Program
    {
        static void GetLove(int quanity1, int quanity2)
        {
            if (quanity1 % 2  != quanity2 % 2 )
            {
                Console.WriteLine("True Love");
            }
            else
            {
                Console.WriteLine("False Love");
            }
        }

        static void Main(string[] args)
        {
            //Fortune telling on a flower
            Console.WriteLine("Enter the number of Sarah petals: ");

            int quantitySara = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of Petals Timmy: ");

            int quantityTimmi = int.Parse(Console.ReadLine());

            GetLove(quantitySara, quantityTimmi);

            Console.ReadLine();

        }
    }
}
