using System.Data;

namespace MyAPITesting.Data
{
    public class Employee
    {       
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Department { get; set; } = string.Empty;
            public decimal Salary { get; set; }          
            public int ContactNumber { get; set; }

    }
}
