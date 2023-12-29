using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseHubApp.Models
{
    internal class WorkstationProductModel
    {
        public string StoreId { get; set; } // ?
        //public ILicense License { get; set; }
        public string ReleaseNumber { get; set; }
        public string InstallerVerificationCode { get; }

    }
}
