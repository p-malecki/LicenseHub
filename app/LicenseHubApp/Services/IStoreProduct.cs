namespace LicenseHubApp.Services;

public interface IStoreProduct
{
    void AddNewRelease();
    void RestoreProductByRelease(string releaseNumber);
    string GetInstallerVerificationCode();
    void SetStatus(bool isAvailable);
}