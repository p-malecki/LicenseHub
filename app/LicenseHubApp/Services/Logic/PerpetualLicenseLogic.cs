﻿namespace LicenseHubApp.Models;

public partial class PerpetualLicenseModel
{
    public override bool IsActive() => true;

    public override DateTime ExpirationDate()
    {
        throw new NotImplementedException();
    }
}

