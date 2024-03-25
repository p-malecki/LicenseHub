using LicenseHubApp.Models;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Emit;

namespace LicenseHubApp.Services;

public class WorkstationProductBuilder
{
    private WorkstationProductModel _workstationProduct = new();
    private LicenseModel? _license;

    public void Reset()
    {
        _workstationProduct = new WorkstationProductModel();
        _license = null;
    }

    public void AddRelease(ProductReleaseModel release)
    {
        _workstationProduct.ReleaseId = release.Id;
        _workstationProduct.ProductRelease = release;
    }

    public void AddLicense(string licenseType, int leaseTermInDays)
    {
        _license = new LicenseModel
        {
            LeaseTermInDays = (licenseType == "Subscription") ? leaseTermInDays : 0
            // TODO add activation code, generated or passed manually 
        };
    }


    public WorkstationProductModel GetProduct()
    {
        if (_workstationProduct.ProductRelease == null)
            throw new InvalidOperationException("ProductRelease is not specified.");
        if (_license == null)
            throw new InvalidOperationException("License is not specified.");

        _workstationProduct.Workstation = null;
        _workstationProduct.Order = null;
        _workstationProduct.License = _license!;
        var result = _workstationProduct;

        Reset();
        return result;
    }
}