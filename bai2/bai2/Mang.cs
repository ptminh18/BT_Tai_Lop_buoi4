using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Mang
    {
        int[] arr = new int[10];
        int n = 0;
        public bool TimKiemGiaTri(int[] arr, int n, int x)
        {
            for (int i = 0; i <= n; i++)
            {
                if (x == arr[i]) return true;
            }
            return false;
        }
        public String InMang()
        {
            String str = " ";
            for(int i = 0; i < n; i++)
            {
                str += arr[i] + " ";
            }
            return str;
        }
        public bool TimThayThe(int[] arr, int n, int old, int neww)
        {
            bool Tim = false;

            for (int i = 0; i < n; i++)
            {
                if (old == arr[i])
                {
                    arr[i] = neww;
                    Tim = true;
                }
            }
            return Tim;
        }
        public int TongMang(int[] arr, int n)
        {
            int s = 0;
            for (int i = 0; i <= n; i++)
            {
                s += arr[i];
            }
            return s;
        }
        public int TongChan(int[] arr, int n)
        {
            int s = 0;
            for (int i = 0; i <= n; i++)
            {
                if (arr[i] % 2 == 0) s += arr[i];
            }
            return s;
        }
        public int TongLe(int[] arr, int n)
        {
            int s = 0;
            for (int i = 0; i <= n; i++)
            {
                if (arr[i] % 2 != 0) s += arr[i];
            }
            return s;
        }
        public int Min(int[] arr, int n)
        {
            int GTMin = arr[0];
            for (int i = 0; i <= n; i++)
                if (GTMin > arr[i]) GTMin = arr[i];
            return GTMin;
        }
        public int Max(int[] arr, int n)
        {
            int GTMax = arr[0];
            for (int i = 0; i <= n; i++)
                if (GTMax < arr[i]) GTMax = arr[i];
            return GTMax;
        }
    }
}
