using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseHubApp.Models
{
    internal class OrderProductModel
    {
        public IStoreProduct StoreProduct { get; set; }
        public List<ILicense> Licenses { get; set; }

    }
}
