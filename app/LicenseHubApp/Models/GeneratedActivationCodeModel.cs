using System.ComponentModel;
namespace LicenseHubApp.Models;

public class GeneratedActivationCodeModel : ActivationCodeModel
{
    public string CodeGeneratorVersion { get; set; } = "";

    private GeneratedActivationCodeModel(string code) : base(code)
    {
    }

    public GeneratedActivationCodeModel(string code, string generatorVersion) : base(code)
    {
        CodeGeneratorVersion = generatorVersion;
    }
}