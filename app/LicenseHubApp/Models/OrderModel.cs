using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseHubApp.Models;

public class OrderModel : ValidatableModel, IModelWithId
{
    [Key]
    [DisplayName("Order ID")]
    public int Id { get; set; }

    [DisplayName("Contract number")]
    public string ContractNumber { get; set; }

    [DisplayName("Date of order")]
    public DateTime DateOfOrder { get; set; }

    [DisplayName("Date of payment")]
    public DateTime DateOfPayment { get; set; }

    [DisplayName("Description")]
    public string Description { get; set; }

    [Browsable(false)]
    public int CompanyId { get; set; }

    [ForeignKey("CompanyId")]
    [Browsable(false)]
    [Description("The company which placed the order.")]
    public CompanyModel Company { get; set; }

    [Browsable(false)]
    [Description("WorkstationProducts included in this order.")]
    public ICollection<WorkstationProductModel> WorkstationProducts { get; set; } = new List<WorkstationProductModel>();
}