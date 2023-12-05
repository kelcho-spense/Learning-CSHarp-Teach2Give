namespace Collections
{
    public class Employee : IComparable<Employee>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public int CompareTo(Employee otherEmployees)
        {
            if (this.Salary > otherEmployees.Salary)
                return -1;
            else if (this.Salary < otherEmployees.Salary)
                return 1;
            else
                return 0;
        }
    }
    
}