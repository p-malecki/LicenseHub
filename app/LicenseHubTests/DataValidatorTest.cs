namespace LicenseHubTests;
using LicenseHubApp.Utils;


public class DataValidatorTest
{

    [Theory]
    [InlineData("0")]
    [InlineData("000-000-00-00")]
    [InlineData("7680002466")]
    [InlineData("106-00-00-062")]
    [InlineData("123-456-78-19")]
    [InlineData("1060000062")]
    public void Given_CorrectNip_When_ValidatingNip_ReturnTrue(string nip)
    {
        // Arrange
        nip = nip.Replace(" ", "").Replace("-", "").Replace("�", "").Replace("_", "").Replace("O", "0").Replace("o", "0");

        // Act
        var result = DataValidator.IsNipValid(nip);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData("1234567890")]
    [InlineData("1060000063")]
    [InlineData("123-456-78-90")]
    [InlineData("106-00-00-062-1")]
    [InlineData("123-456-78-1")]
    [InlineData("1060000061")]
    public void Given_IncorrectNip_When_ValidatingNip_ReturnFalse(string nip)
    {
        // Arrange and Act
        var result = DataValidator.IsNipValid(nip);

        // Assert
        Assert.False(result);
    }

}