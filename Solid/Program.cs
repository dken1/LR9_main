using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee hourlyEmployee = new Employee { Name = "Иван", HoursWorked = 160, HourlyRate = 10 };
            Employee fixedEmployee = new Employee { Name = "Ольга", HoursWorked = 0, HourlyRate = 0 };

            ISalaryCalculator hourlyCalculator = new HourlySalaryCalculator();
            ISalaryCalculator fixedCalculator = new FixedSalaryCalculator(3000);
            IEmployeePrint print = new ConsoleEmployeePrint();

            PayrollProcessor hourlyProcessor = new PayrollProcessor(hourlyCalculator, print);
            PayrollProcessor fixedProcessor = new PayrollProcessor(fixedCalculator, print);

            hourlyProcessor.ProcessSalary(hourlyEmployee);
            fixedProcessor.ProcessSalary(fixedEmployee);
            Console.ReadKey();
        }
    }
}
