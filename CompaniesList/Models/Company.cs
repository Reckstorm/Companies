using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesList.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CEO { get; set; }
        public int EmployeeCount { get; set; }

        public Company(int id, int employeeCount, string name, string ceo)
        {
            this.Id = id;
            this.Name = name;
            this.CEO = ceo;
            this.EmployeeCount = employeeCount;
        }
    }
}
