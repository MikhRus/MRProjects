using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class SalaryHalper
    {
        public static double SetSalary(double s)
        {
            return s - (s * 0.13);
        }
    }
}
