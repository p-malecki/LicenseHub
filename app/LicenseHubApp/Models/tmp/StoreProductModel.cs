using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseHubApp.Models
{
    internal class StoreProductModel
    {
        public string StoreId { get; set; }
        public string Name { get; set; }
        public string RecentReleaseNumber { get; set; }
        public string InstallerVerificationPasscode { get; set; }
        public bool IsAvailable { get; set; }

    }
}
