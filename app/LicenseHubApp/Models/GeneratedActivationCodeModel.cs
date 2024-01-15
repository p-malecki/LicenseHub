using System.ComponentModel;
namespace LicenseHubApp.Models;

public class GeneratedActivationCodeModel(string code, string generatorVersion) : ActivationCodeModel(code)
{
    [DisplayName("Code generator version")]
    public string CodeGeneratorVersion { get; set; } = generatorVersion;
}