namespace LicenseHubApp.Services;

public class IncorrectPasswordException : Exception
{
    public IncorrectPasswordException() : base("Incorrect password.") { }
    public IncorrectPasswordException(string message) : base(message) { }
    public IncorrectPasswordException(string message, Exception innerException) : base(message, innerException) { }
}