using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class YearMonth
    {
        //4.1.1
        public int Year { get; private set; }
        public int Month { get; private set; }
        //コンストラクタ
        public YearMonth(int year,int month)
        {
            Year = year;
            Month = month;
        }
    }
}
