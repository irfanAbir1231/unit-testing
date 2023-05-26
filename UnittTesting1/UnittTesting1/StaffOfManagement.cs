using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnittTesting1
{
    public class StaffOfManagement : Employee
    {
        public string Department { get; set; } = " ";
        public string Position { get; set; } = " ";

        public override int ShowDetails()
        {
            return DateTime.Today.Year - HireDate.Year;
        }

        public override int CalculateYearsOfService()
        {
            return DateTime.Today.Year - HireDate.Year;
        }
    }
}
