using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseHubApp.Models
{
    internal class EmployeeModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Profession { get; set; }
        public List<string> PhoneNums { get; set; }
        public List<string> Emails { get; set; }
        public List<string> Websites { get; set; }
        public List<string> IPs { get; set; }
        public string Description { get; set; }

    }
}
