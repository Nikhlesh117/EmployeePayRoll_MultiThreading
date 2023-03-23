using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultiThreading
{
    public class EmployeePayroll
    {
        public List<EmployeeDetails> employeePayrollDetailsList = new List<EmployeeDetails>();
        // UC1- Without Use of Thread
        public void AddEmployeeToPayroll(List<EmployeeDetails> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.Name);
                this.AddEmployeePayroll(employeeData);
                Console.WriteLine("Employee added: " + employeeData.Name);
            });
            Console.WriteLine(this.employeePayrollDetailsList.Count());
        }
        public void AddEmployeePayroll(EmployeeDetails emp)
        {
            employeePayrollDetailsList.Add(emp);
        }

    }
}
