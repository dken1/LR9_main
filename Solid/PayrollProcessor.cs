using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class PayrollProcessor
    {
        private readonly ISalaryCalculator _salaryCalculator;
        private readonly IEmployeePrint _employeePrint;

        public PayrollProcessor(ISalaryCalculator salaryCalculator, IEmployeePrint employeePrint)
        {
            _salaryCalculator = salaryCalculator;
            _employeePrint = employeePrint;
        }

        public void ProcessSalary(Employee employee)
        {
            double salary = _salaryCalculator.CalculateSalary(employee);
            _employeePrint.PrintEmployeeInfo(employee, salary);
        }
    }
}
