using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm3
{
    internal class TinhToan
    {
        public static long TinhTong(int n)
        {
            long kq = 0;
            for(int i = 1; i <= n; i++)
                kq += i;
            return kq;
        }

        public static long TinhGiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i <= n; i++)
                kq *= i;
            return kq;
        }
    }
}
