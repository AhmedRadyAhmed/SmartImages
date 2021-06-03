using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesApp
{
    public static class MyRound
    {
        public static int RoundByLimit(double _size, double limit = 0.66)
        {
            int i;
            double j;
            i = Convert.ToInt32(_size);
            j = _size - i;
            if (j >= limit)
                i += 1;
            return i;
        }
    }
}
