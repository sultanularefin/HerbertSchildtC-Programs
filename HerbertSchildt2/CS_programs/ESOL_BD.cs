using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ESOL_BD
    {
        public int x, y = 0;

        public void f1()
        {

            int z;
            for (z = 0; z < 6; z++)
            {
                if ((++x > 2) || (++y > 2))
                {
                    x++;
                }
            }

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        static void Main()
        {
            ESOL_BD obj = new ESOL_BD();
            obj.f1();

        }
    }
}

   

