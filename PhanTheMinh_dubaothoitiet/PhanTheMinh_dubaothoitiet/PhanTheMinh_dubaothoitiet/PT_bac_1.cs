using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTheMinh_dubaothoitiet
{
    class PT_bac_1
    {
        double a, b;

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
        public double Calculate()
        {
            return (-b / a);
        }
    }
}
