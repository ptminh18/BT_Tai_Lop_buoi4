using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTheMinh_dubaothoitiet
{
    class PT_bac_2
    {
        double a, b, c, delta;

        public double Delta
        {
            get { return delta; }
            set { delta = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public int Calculate()
        {
            delta = (b * b) - (4 * a * c);
            if (delta < 0)
                return 1;
            else if (delta == 0)
                return 2;
            return 3;
        }
        
    }
}
