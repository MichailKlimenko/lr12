using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр12
{
    // Класс, представляющий сотрудника
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }

    // Класс, представляющий компьютер
    public class Computer
    {
        public int ComputerId { get; set; }
        public string Model { get; set; }
        public int EmployeeId { get; set; }
    }
}
