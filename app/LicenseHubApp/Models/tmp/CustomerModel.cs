using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseHubApp.Models
{
    internal class CustomerModel
    {
        public string Name { get; set; }
        public string Nip { get; set; }
        public List<string> Localizations { get; set; }
        public List<string> Websites { get; set; }
        public string Description { get; set; }
        public IEmployeeManager EmployeeManager { get; set; }
        public IWorkstationManager WorkstationManager { get; set; }
        public IOrderManager OrderManager { get; set; }

    }
}
