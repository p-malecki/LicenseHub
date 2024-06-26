﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LicenseHubApp.Models;

public class ActivationCodeModel(string code) : ValidatableModel, IModelWithId
{
    [Key]
    [DisplayName("ActivationCode ID")]
    public int Id { get; set; }

    [DisplayName("Activation code")]
    public string Code { get; set; } = code;


    [Browsable(false)]
    public int LicenseId { get; set; }

    [ForeignKey("LicenseId")]
    [Browsable(false)]
    [Description("License that contains this ActivationCode.")]
    public LicenseModel License { get; set; }
}