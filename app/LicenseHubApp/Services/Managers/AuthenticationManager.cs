using LicenseHubApp.Models;
namespace LicenseHubApp.Services.Managers;

public sealed class AuthenticationManager
{
    private static readonly object LockObject = new();
    private static AuthenticationManager? _instance;
    private static IUserRepository? _repository;
    private UserModel? _currentlyLoggedUser;

    private static int _failedAttempts = 0;


    private AuthenticationManager() { }

    public static AuthenticationManager GetInstance(IUserRepository repository)
    {
        // Double-check locking for thread safety
        if (_instance == null)
        {
            lock (LockObject)
            {
                if (_instance == null)
                {
                    _instance = new AuthenticationManager();
                    _repository = repository;
                }
            }
        }
        return _instance;
    }

    public void Login(string username, string password)
    {
        try
        {
            var user = (_repository.GetUserByUsernameAsync(username)?.Result) ?? throw new InvalidDataException($"User {username} doesn't exist.");
            if (user.Password == password)
            {
                _currentlyLoggedUser = user;
                _failedAttempts = 0;
                Console.WriteLine($"User '{username}' logged in successfully.");
            }
            else
            {
                // Wait when incorrect password entered
                _failedAttempts++;
                if (_failedAttempts > 5)
                {
                    Thread.Sleep(_failedAttempts * _failedAttempts * 400);
                }
                throw new IncorrectPasswordException("The entered password is incorrect.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void Logout()
    {
        if (_currentlyLoggedUser != null)
        {
            _currentlyLoggedUser = null;
            Console.WriteLine("User logged out successfully.");
        }
    }

    public UserModel? GetCurrentlyLoggedUser()
    {
        return _currentlyLoggedUser;
    }
}