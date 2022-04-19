using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKapsülleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Öğrenci ogr1 = new Öğrenci();
            ogr1.setIsim("Kaan");
            string gelen = ogr1.getIsim();

            if(gelen== "Kaan")
            {
                Console.WriteLine("Başarılı");

            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Console.ReadKey();
                    
        }
    }
}
