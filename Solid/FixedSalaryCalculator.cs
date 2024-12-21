using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class FixedSalaryCalculator : ISalaryCalculator
    {
        private readonly double _fixedSalary;

        public FixedSalaryCalculator(double fixedSalary)
        {
            _fixedSalary = fixedSalary;
        }

        public double CalculateSalary(Employee employee)
        {
            return _fixedSalary;
        }
    }
}
