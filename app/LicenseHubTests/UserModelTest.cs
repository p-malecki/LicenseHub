namespace LicenseHubTests
{
    [TestFixture]
    public class UserModelTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(0, ExpectedResult = true)]
        [TestCase(int.MaxValue, ExpectedResult = true)]
        [TestCase(int.MinValue, ExpectedResult = false)]
        [TestCase(-1, ExpectedResult = false)]
        public bool Test_IdCorrectness(int id)
        {
            // Arrange
            var model = new UserModel
            {
                Id = id,
                Name = "abcd",
                Password = "Abcd123#",
                IsAdmin = false
            };

            // Act and Assert
            return model.Validate();
        }

        [Test]
        [TestCase("", ExpectedResult = false)]
        [TestCase("ab", ExpectedResult = false)]
        [TestCase("abc", ExpectedResult = true)]
        [TestCase("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwx", ExpectedResult = true)]
        [TestCase("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxy", ExpectedResult = false)]
        public bool Test_NameCorrectness(string name)
        {
            // Arrange
            var model = new UserModel
            {
                Id = 1,
                Name = name,
                Password = "Abcd123#",
                IsAdmin = false
            };

            // Act and Assert
            return model.Validate();
        }

        [Test]
        [TestCase("Abc123#")] // to short
        [TestCase("Abcde123")] // #
        [TestCase("abcd123#")] // A
        [TestCase("ABCD123#")] // a
        [TestCase("abcdefh#")] // 1
        [TestCase("Abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvw1#")] // to long
        public void Test_IncorrectPassword_ReturnFalse(string password)
        {
            // Arrange
            var model = new UserModel
            {
                Id = 1,
                Name = "abc",
                Password = password,
                IsAdmin = false
            };

            // Act
            var isValid = model.Validate();

            // Assert
            Assert.That(isValid, Is.False);
        }

        [Test]
        [TestCase("Abcd123#")]
        [TestCase("Abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuv1#")]
        public void Test_CorrectPassword_ReturnTrue(string password)
        {
            // Arrange
            var model = new UserModel
            {
                Id = 1,
                Name = "abc",
                Password = password,
                IsAdmin = false
            };

            // Act
            var isValid = model.Validate();

            // Assert
            Assert.That(isValid, Is.True);
        }

        [Test]
        public void Test_MissingName()
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
            Assert.That(isValid, Is.False);
        }

        [Test]
        public void Test_MissingPassword()
        {
            // Arrange
            var model = new UserModel
            {
                Id = 1,
                Name = "abc",
                IsAdmin = false
            };

            // Act
            var isValid = model.Validate();

            // Assert
            Assert.That(isValid, Is.False);
        }


    }
}