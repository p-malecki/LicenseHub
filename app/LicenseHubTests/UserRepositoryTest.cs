namespace LicenseHubTests;

using Moq;
using Moq.EntityFrameworkCore;
using AutoFixture;


using LicenseHubApp.Models;
using LicenseHubApp.Repositories;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Microsoft.VisualBasic.ApplicationServices;
using LicenseHubApp.Services.Managers;

public class UserRepositoryTest
{
    private static readonly Fixture Fixture = new();

    [Fact]
    public async Task Given_ExistingUsers_When_GettingAllAsync_Should_ReturnAllUsers()
    {
        // Arrange
        IList<UserModel> users = new List<UserModel>();
        var newUser1 = Fixture.Build<UserModel>().Create();
        var newUser2 = Fixture.Build<UserModel>().Create();
        users.Add(newUser1);
        users.Add(newUser2);

        var dataContextMock = new Mock<DataContext>();
        dataContextMock.Setup(x => x.Users).ReturnsDbSet(users);
        var sut = new UserRepository(dataContextMock.Object);

        // Act
        var result = await sut.GetAllAsync();

        // Assert
        Assert.Equal([newUser1, newUser2], result);
    }

    [Fact]
    public void Given_ExistingUsersWithoutRequestedIds_When_CheckingIfIdIsUniqueAsync_Should_ReturnTrue()
    {
        // Arrange
        IList<UserModel> users = new List<UserModel>
        {
            Fixture.Build<UserModel>().With(u => u.Id,1).Create(),
            Fixture.Build<UserModel>().With(u => u.Id, 2).Create(),
            Fixture.Build<UserModel>().With(u => u.Id, 4).Create(),
        };

        var dataContextMock = new Mock<DataContext>();
        dataContextMock.Setup(x => x.Users).ReturnsDbSet(users);
        var sut = new UserRepository(dataContextMock.Object);

        // Act
        var result = sut.IsIdUnique(3);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Given_ExistingUserWithRequestedId_When_CheckingIfIdIsUniqueAsync_Should_ReturnFalse()
    {
        // Arrange
        IList<UserModel> users = GenerateUsersWithIdAndUsernames(); // contains id= 1..3

        var dataContextMock = new Mock<DataContext>();
        dataContextMock.Setup(x => x.Users).ReturnsDbSet(users);
        var sut = new UserRepository(dataContextMock.Object);

        // Act
        var result = sut.IsIdUnique(2);

        // Assert
        Assert.False(result);
    }


    [Fact]
    public async Task Given_ExistingSoughtUser_When_FindingUserNameAsync_Should_ReturnWantedUser()
    {
        // Arrange
        IList<UserModel> users = GenerateUsersWithIdAndUsernames();
        var usernameToFind = "usernameToFind";
        var userToFind = Fixture.Build<UserModel>().With(u => u.Username, usernameToFind).Create();
        users.Add(userToFind);

        var dataContextMock = new Mock<DataContext>();
        dataContextMock.Setup(x => x.Users).ReturnsDbSet(users);
        var sut = new UserRepository(dataContextMock.Object);

        // Act
        var result = await sut.GetUserByUsernameAsync(usernameToFind);

        // Assert
        Assert.Equal(userToFind, result);
    }

    [Fact]
    public async Task Given_NoSoughtUser_When_FindingUserNameAsync_Should_ReturnNull()
    {
        // Arrange
        IList<UserModel> users = GenerateUsersWithIdAndUsernames();
        var usernameToFind = "usernameToFind";
        var userToFind = Fixture.Build<UserModel>().With(u => u.Username, usernameToFind).Create();

        var dataContextMock = new Mock<DataContext>();
        dataContextMock.Setup(x => x.Users).ReturnsDbSet(users);
        var sut = new UserRepository(dataContextMock.Object);

        // Act
        var result = await sut.GetUserByUsernameAsync(usernameToFind);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public async Task Given_NoUsers_When_AddingUserAsync_Should_AddUser()
    {
        // Arrange
        IList<UserModel> users = new List<UserModel>();
        IList<UserModel> expected = new List<UserModel>();
        var newUser1 = Fixture.Build<UserModel>().With(u => u.Id, 1).Create();
        expected.Add(newUser1);

        var dataContextMock = new Mock<DataContext>();
        dataContextMock.Setup(x => x.Users).ReturnsDbSet(users);

        var sut = new UserRepository(dataContextMock.Object);

        // Act
        await sut.AddAsync(newUser1);

        // Assert
        Assert.Equal(expected, users);
    }

    public async Task Given_ExistingUser_When_DeletingUserAsync_Should_RemoveUser()
    {
        // Arrange
        IList<UserModel> users = new List<UserModel>();
        IList<UserModel> expected = new List<UserModel>();
        var newUser1 = Fixture.Build<UserModel>().With(u => u.Id, 1).Create();
        var newUser2 = Fixture.Build<UserModel>().With(u => u.Id, 2).Create();
        users.Add(newUser1);
        users.Add(newUser2);
        expected.Add(newUser1);
        expected.Add(newUser2);


        var idToDelete = 123;
        var userToDelete = Fixture.Build<UserModel>().With(u => u.Id, idToDelete).Create();
        users.Add(userToDelete);

        var dataContextMock = new Mock<DataContext>();
        dataContextMock.Setup(x => x.Users).ReturnsDbSet(users);
        var sut = new UserRepository(dataContextMock.Object);

        // Act
        await sut.DeleteAsync(idToDelete);

        // Assert
        Assert.Equal(expected, users);
    }


    private static IList<UserModel> GenerateUsersWithIdAndUsernames()
    {
        IList<UserModel> users = new List<UserModel>()
        {
            Fixture.Build<UserModel>().With(u => u.Id, 1).With(u => u.Username,"u1").Create(),
            Fixture.Build<UserModel>().With(u => u.Id, 2).With(u => u.Username,"u2").Create(),
            Fixture.Build<UserModel>().With(u => u.Id, 3).With(u => u.Username,"u3").Create(),
        };

        return users;
    }


    [Fact]
    public async Task TEST()
    {
        //// Arrange
        //IList<CompanyModel> cos = new List<CompanyModel>();
        //var dataContextMock = new Mock<DataContext>();
        //dataContextMock.Setup(x => x.Companies).ReturnsDbSet(cos);
        //var repoMock = new CompanyRepository(dataContextMock.Object);

        //var sut = CompanyManager.GetInstance(repoMock);

        //// Act
        //var newCo = Fixture.Build<CompanyModel>().Create();

        //sut.SaveCompany(newCo);

        //// Assert
        ////Assert.Equal(expected, users);
    }

}