using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef4WindowsFormsApp1108
{
    class Lamineer
    {
        public readonly string saveText;

        public Lamineer(string a)
        {

            saveText = a;
            
            Console.WriteLine("{0},",saveText);
        }
    }
}
