namespace LicenseHubTests;
using LicenseHubApp.Models;


public class UserModelTest
{

    [Theory]
    [InlineData(0)]
    [InlineData(int.MaxValue)]
    public void Given_CorrectId_When_ValidatingModel_ReturnTrue(int id)
    {
        // Arrange
        var model = new UserModel
        {
            Id = id,
            Username = "abcd",
            Password = "Abcd123#",
            IsAdmin = false
        };

        // Act and Assert
        Assert.True(model.Validate());
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-1)]
    public void Given_IncorrectId_When_ValidatingModel_ReturnFalse(int id)
    {
        // Arrange
        var model = new UserModel
        {
            Id = id,
            Username = "abcd",
            Password = "Abcd123#",
            IsAdmin = false
        };

        // Act and Assert
        Assert.False(model.Validate());
    }


    [Theory]
    [InlineData("abc")]
    [InlineData("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwx")]
    public void Given_CorrectUsername_When_ValidatingModel_ReturnTrue(string username)
    {
        // Arrange
        var model = new UserModel
        {
            Id = 1,
            Username = username,
            Password = "Abcd123#",
            IsAdmin = false
        };

        // Act and Assert
        Assert.True(model.Validate());
    }

    [Theory]
    [InlineData("")]
    [InlineData("ab")]
    [InlineData("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxy")]
    public void Given_IncorrectUsername_When_ValidatingModel_ReturnFalse(string username)
    {
        // Arrange
        var model = new UserModel
        {
            Id = 1,
            Username = username,
            Password = "Abcd123#",
            IsAdmin = false
        };

        // Act and Assert
        Assert.False(model.Validate());
    }


    [Theory]
    [InlineData("Abcd123#")]
    [InlineData("Abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuv1#")]
    public void Given_CorrectPassword_When_ValidatingModel_ReturnTrue(string password)
    {
        // Arrange
        var model = new UserModel
        {
            Id = 1,
            Username = "abc",
            Password = password,
            IsAdmin = false
        };

        // Act
        var isValid = model.Validate();

        // Assert
        Assert.True(isValid);
    }

    [Theory]
    [InlineData("Abc123#")] // to short
    [InlineData("Abcde123")] // #
    [InlineData("abcd123#")] // A
    [InlineData("ABCD123#")] // a
    [InlineData("abcdefh#")] // 1
    [InlineData("Abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvw1#")] // to long
    public void Given_IncorrectPassword_When_ValidatingModel_ReturnFalse(string password)
    {
        // Arrange
        var model = new UserModel
        {
            Id = 1,
            Username = "abc",
            Password = password,
            IsAdmin = false
        };

        // Act
        var isValid = model.Validate();

        // Assert
        Assert.False(isValid);
    }


    [Fact]
    public void Given_MissingUsernameInModel_When_ValidatingModel_ReturnFalse()
    {
        // Arrange
        var model = new UserModel
        {
            Id = 1,
            Password = "Abcd123#",
            IsAdmin = false
        };

        // Act
        var isValid = model.Validate();

        // Assert
        Assert.False(isValid);
    }

    [Fact]
    public void Given_MissingPasswordInModel_When_ValidatingModel_ReturnFalse()
    {
        // Arrange
        var model = new UserModel
        {
            Id = 1,
            Username = "abc",
            IsAdmin = false
        };

        // Act
        var isValid = model.Validate();

        // Assert
        Assert.False(isValid);
    }
}