﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseHubApp.Models;

public abstract class LicenseModel : ValidatableModel, IModelWithId
{
    [Key]
    [DisplayName("LicenseID")]
    public int Id { get; set; }

    [DisplayName("Register date")]
    public DateTime? RegisterDate { get; set; }

    [DisplayName("Activation date")]
    public DateTime? ActivationDate { get; set; }

    [DisplayName("Activation code")]
    public ActivationCodeModel? ActivationCode { get; set; }
    
    [Browsable(false)]
    public int WorkstationProductId { get; set; }

    [ForeignKey("WorkstationProductId")]
    [Browsable(false)]
    public WorkstationProductModel WorkstationProduct { get; set; }


    public abstract bool IsActive();
    public abstract DateTime ExpirationDate();
}