using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using Moq;
using Moq.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Repositories;
using System.Net.Sockets;
using Microsoft.EntityFrameworkCore.Query;


namespace LicenseHubTests
{
    [TestFixture]
    public class UserRepositoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Given_ExistingUsers_When_GettingAll_Should_ReturnAllUsers()
        {
            // Arrange
            var users = new List<UserModel>
            {
                new() { Id = 0, Name = "abcd", Password = "Password1#", IsAdmin = false },
                new() { Id = 1, Name = "efgh", Password = "Password2#", IsAdmin = true },
            };//.AsQueryable();

            var usersMock = new Mock<DbSet<UserModel>>();
            //usersMock.As<IQueryable<User>>().Setup(m => m.Provider).Returns(users.ToAsyncEnumerable().GetAsyncEnumerator);
            //usersMock.As<IQueryable<User>>().Setup(m => m.Provider).Returns(((IAsyncQueryProvider)users.Provider));

            var dataContextMock = new Mock<DataContext>();
            dataContextMock.Setup(x => x.Users).ReturnsDbSet(usersMock.Object);


            IUserRepository repository = new UserRepository(dataContextMock.Object);
            
            // Act
            var result = await repository.GetAll();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(users.ToList().Count));
        }

        [Test]
        public async Task Given_NoExistingUsers_When_AddingUser_Then_UserAdded()
        {
            // Arrange
            var expectedUserList = new List<UserModel>()
            {
                new() { Id = 0, Name = "abcd", Password = "Password1#", IsAdmin = false },
            };

            var userMockSet = new Mock<DbSet<UserModel>>();
            var dataContextMock = new Mock<DataContext>();
            dataContextMock.Setup(m => m.Users).Returns(userMockSet.Object);

            IUserRepository repository = new UserRepository(dataContextMock.Object);

            //dataContextMock.Setup(x => x.Users).ReturnsDbSet(userMockSet);

            // Act
            await repository.Add(new UserModel() { Id = 0, Name = "abcd", Password = "Password1#", IsAdmin = false });
            //var result = repository.GetAll().Result.ToList();
            var result = await repository.GetAll();

            // Assert
            Assert.That(result, Is.EqualTo(expectedUserList));
        }

        [Test]
        public async Task Given_ExistingUser_When_DeletingUser_Then_UserDeleted()
        {
            // Arrange
            var users = new List<UserModel>()
            {
                new() { Id = 0, Name = "abcd", Password = "Password1#", IsAdmin = false },
            };
            var userContextMock = new Mock<DataContext>();
            userContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            IUserRepository repository = new UserRepository(userContextMock.Object);

            // Act
            var userToDelete = new UserModel() { Id = 0, Name = "abcd", Password = "Password1#", IsAdmin = false };
            await repository.Delete(userToDelete);
            var result = repository.GetAll().Result.ToList();

            // Assert
            Assert.That(result, Is.Empty);
        }
    }
}