using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class List_Employee
    {
        public void ExecuteListEmployees ()
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000,
                Experience = 5
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "John",
                Salary = 4000,
                Experience = 4
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Mary",
                Salary = 6000,
                Experience = 6
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Todd",
                Salary = 3000,
                Experience = 3
            };
            Employee emp5 = new Employee()
            {
                ID = 104,
                Name = "GID",
                Salary = 1000,
                Experience = 3
            };

            // Save all employee objects into a list
            List<Employee> listEmployees = new List<Employee>() { emp1, emp2, emp3, emp4 };

            // Create a new list of employees with salary more than 4000
            Console.WriteLine(">>>>display emplyees with salary > 4000 <<<<");
            List<Employee> listEmp = listEmployees.FindAll(emp => emp.Salary > 4000);
            foreach (Employee employee in listEmp)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Experience = {3}",
                                       employee.ID, employee.Name, employee.Salary, employee.Experience);
            }

            // find employee with ID = 102
            Console.WriteLine(">>>>find employee with ID = 102<<<<");
            Employee emp = listEmployees.Find(e => e.ID == 102);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Experience = {3}",
                                                      emp.ID, emp.Name, emp.Salary, emp.Experience);
            //find employee with whose name is Mary
            Console.WriteLine(">>>>find employee with whose name is Mary<<<<");
            Employee emp6 = listEmployees.Find(e => e.Name.ToLower() == "mary");
            if (emp6 == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Experience = {3}", emp6.ID, emp6.Name, emp6.Salary, emp6.Experience);
            }

            //sorting employees list by salary
            //sort - use IComparable interface to do the sorting
            Console.WriteLine(">>>>sorting employees list by salary<<<<");
            listEmployees.Sort();
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Experience = {3}", employee.ID, employee.Name, employee.Salary, employee.Experience);
            }
        }
                                                                    
       
    }
}
