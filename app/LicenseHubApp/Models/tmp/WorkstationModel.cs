namespace LicenseHubApp.Models
{
    internal class WorkstationModel
    {
        public string Id { get; set; }
        public bool HasFault { get; set; }
        public string HardDisk { get; set; }
        public string Cpu { get; set; }
        public string Username { get; set; }
        public string ComputerName { get; set; }
        public string BiosVersion { get; set; }
        public string Os { get; set; }
        public string OsBitVersion { get; set; }
        //public List<IWorkstationProduct> ProductsInstalled { get; set; }

    }
}
