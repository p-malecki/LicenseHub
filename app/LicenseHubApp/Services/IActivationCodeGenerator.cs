﻿using LicenseHubApp.Models;
namespace LicenseHubApp.Services;

public interface IActivationCodeGenerator
{
    string Generate();
    string GetVersion();
}