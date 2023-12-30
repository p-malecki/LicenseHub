namespace LicenseHubApp.Models
{
    internal class OrderModel
    {
        //public IOrderState State { get; set; }
        public string Id { get; set; }
        public string ContractNumber { get; set; }
        public DateTime DateOfOrder { get; set; }
        public DateTime DateOfPayment { get; set; }
        public string InvoiceFilePath { get; set; }
        //public List<IOrderProduct> OrderProducts { get; set; }
        ////public ICollection<IOrderProduct> OrderProducts { get; set; } = new HashSet<IOrderProduct>();
        public string Description { get; set; }

    }
}
