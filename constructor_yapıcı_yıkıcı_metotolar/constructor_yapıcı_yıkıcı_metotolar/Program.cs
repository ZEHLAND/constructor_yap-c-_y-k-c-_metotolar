using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_yapıcı_yıkıcı_metotolar
{
    class Program
    {
        static void Main(string[] args)
        {
            bilgi blg = new bilgi();
            Console.WriteLine(blg.AD);
            Console.WriteLine(blg.Soyad);
            Console.WriteLine(blg.YAS);
            Console.WriteLine(blg.MEMLEKET);
            Console.WriteLine(blg.CİNSİYET);
            Console.Read();
        }
    }
}
