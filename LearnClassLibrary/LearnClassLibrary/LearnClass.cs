using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassLibrary
{
    public class LearnClass
    {
        public int TimeInSecunds(int h, int m)
        {
            return h * 3600 + m * 60 ;
        }

        public int GetHour(int sec)
        {
            int totalMinuts = sec / 60;
            return totalMinuts / 60;
        }

        public int GetMin(int sec)
        {
            int totalMinuts = sec / 60;
            return totalMinuts % 60;
        }
    }
}
