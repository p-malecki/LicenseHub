using LicenseHubApp.Models.Managers;
using LicenseHubApp.Repositories;
using Moq;

namespace LicenseHubTests;
using LicenseHubApp.Models;


public class CompanyManagerTest
{

    [Theory]
    [InlineData("0")]
    [InlineData("000-000-00-00")]
    [InlineData("7680002466")]
    [InlineData("106-00-00-062")]
    [InlineData("123-456-78-19")]
    public void Given_CorrectNip_When_ValidatingNip_ReturnTrue(string nip)
    {
        // Arrange and Act
        var result = CompanyManager.IsNipValid(nip);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData("1234567890")]
    [InlineData("1060000063")]
    [InlineData("123-456-78-90")]
    [InlineData("106-00-00-062-1")]
    [InlineData("123-456-78-1")]
    public void Given_IncorrectNip_When_ValidatingNip_ReturnFalse(string nip)
    {
        // Arrange and Act
        var result = CompanyManager.IsNipValid(nip);

        // Assert
        Assert.False(result);
    }

}