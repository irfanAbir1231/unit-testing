using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnittTesting1
{
    public abstract class Employee
    {
        public string Name { get; set; } = " ";
        public string Address { get; set; } = " ";
        public string PhoneNumber { get; set; } = " ";
        public string Email { get; set; } = " ";
        public DateTime HireDate { get; set; }

        public abstract int ShowDetails();
        public abstract int CalculateYearsOfService();
    }

}
