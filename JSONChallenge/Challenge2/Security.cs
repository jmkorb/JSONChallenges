using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge.Challenge2
{
    public class Security
    {
        public int BadgeID { get; set; }
        public List<string> ListOfDoors { get; set; }
        public int MyProperty { get; set; }
        public bool HasSecurityClearance { get; set; }
        public string EmployeeID { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
