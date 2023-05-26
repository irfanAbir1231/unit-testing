using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnittTesting1
{

    public class Nurse : Employee
    {
        public string Position { get; set; }
        public string Department { get; set; }

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
