using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр12
{
    public partial class Form1 : Form
    {
        // Источники данных (списки с данными о сотрудниках и компьютерах)
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, Name = "Иван", DepartmentId = 1 },
            new Employee { EmployeeId = 2, Name = "Мария", DepartmentId = 2 },
            new Employee { EmployeeId = 3, Name = "Петр", DepartmentId = 1 },
            new Employee { EmployeeId = 4, Name = "Елена", DepartmentId = 2 },
            new Employee { EmployeeId = 5, Name = "Алексей", DepartmentId = 1 }
        };

        List<Computer> computers = new List<Computer>
        {
            new Computer { ComputerId = 1, Model = "Dell", EmployeeId = 1 },
            new Computer { ComputerId = 2, Model = "HP", EmployeeId = 2 },
            new Computer { ComputerId = 3, Model = "Lenovo", EmployeeId = 3 },
            new Computer { ComputerId = 4, Model = "Asus", EmployeeId = 4 },
            new Computer { ComputerId = 5, Model = "Acer", EmployeeId = 5 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Выполнение LINQ-запроса для выборки данных
            var query = from emp in employees
                        join comp in computers on emp.EmployeeId equals comp.EmployeeId
                        select new
                        {
                            EmployeeName = emp.Name,
                            ComputerModel = comp.Model
                        };

            // Отображение результатов выборки в ListBox
            foreach (var item in query)
            {
                listBox1.Items.Add($"{item.EmployeeName} - {item.ComputerModel}");
            }
        }
    }
}
