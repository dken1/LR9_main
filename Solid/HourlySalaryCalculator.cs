using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class HourlySalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.HoursWorked * employee.HourlyRate;
        }
    }
}
