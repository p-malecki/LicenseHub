using LicenseHubApp.Models;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Emit;

namespace LicenseHubApp.Services;

public class WorkstationProductBuilder
{
    private WorkstationProductModel _workstationProduct = new ();
    private LicenseModel? _license;

    public void Reset()
    {
        _workstationProduct = new WorkstationProductModel();
        _license = null;
    }

    public void AddRelease(ProductReleaseModel release)
    {
        _workstationProduct.ProductRelease = release;
    }

    public void AddPerpetualLicense()
    {
        _license = new PerpetualLicenseModel();
    }

    public void AddSubscriptionLicense(int leaseTermInDays)
    {
        _license = new SubscriptionLicenseModel(leaseTermInDays);
    }


    public WorkstationProductModel GetProduct()
    {
        if (_workstationProduct.ProductRelease == null)
            throw new InvalidOperationException("ProductRelease is not specified.");
        if (_license == null)
            throw new InvalidOperationException("License is not specified.");

        _workstationProduct.License = _license!;
        var result = _workstationProduct;

        Reset();
        return result;
    }
}