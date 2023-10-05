using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTheMinh_dubaothoitiethomnaymua
{
    class Calculate
    {
        private double a, b;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double Cong()
        {
            return a + b;
        }
        public double Tru()
        {
            return a - b;
        }
        public double Nhan()
        {
            return a * b;
        }
        public double Chia()
        {
            return a / b;
        }
    }
}
