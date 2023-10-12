using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PanasenkoRA.Sprint1.Task5.V0.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            int res = int.Parse(Convert.ToString(k)[-3].ToString());
            return res;
        }
    }
}
