﻿using Microsoft.Win32;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Windows.Management.Deployment;

namespace Vocup.Util;

/// <summary>
/// Provides util methods for application metadata.
/// </summary>
public static class AppInfo
{
    /// <summary>
    /// Defines invalid characters for a path and thereby many strings in Vocup.
    /// </summary>
    public const string InvalidPathChars = "#=:\\/|<>*?\"";

    /// <summary>
    /// Gets the directory where custom special char files are stored.
    /// </summary>
    public static string SpecialCharDirectory { get; } = Path.Combine(Properties.Settings.Default.VhrPath, "specialchar");

    public static Version Version { get; } = Version.Parse(
        Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion 
        ?? throw new ApplicationException("Assembly version is undefined"));

    public static Version FileVersion { get; } = new Version(1, 0);

    public static string ProductName { get; }
        = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyProductAttribute>()?.Product
        ?? throw new ApplicationException("Assemly product name is undefined");

    public static string CopyrightInfo { get; }
        = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCopyrightAttribute>()?.Copyright
        ?? throw new ApplicationException("Assembly copyright information is undefined");

    private static readonly Lazy<bool> isUwp = new Lazy<bool>(() =>
    {
        if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 10240))
        {
            int length = 0;
            StringBuilder sb = new StringBuilder(0);
            GetCurrentPackageFullName(ref length, sb);
            sb = new StringBuilder(length);
            int result = GetCurrentPackageFullName(ref length, sb);
            return result != APPMODEL_ERROR_NO_PACKAGE;
        }
        else return false;
    });
    public static bool IsUwp => isUwp.Value;

    private static readonly Lazy<bool> isInstallation = new Lazy<bool>(() =>
    {
        return TryGetVocupInstallation(out _, out string? installLocation, out _)
            && Application.StartupPath.TrimEnd('\\').Equals(installLocation.TrimEnd('\\'), StringComparison.OrdinalIgnoreCase);
    });
    public static bool IsWindowsInstallation => isInstallation.Value;

    private static readonly Lazy<bool> isWine = new Lazy<bool>(() =>
    {
        using RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
        using RegistryKey? wine = hklm.OpenSubKey(@"SOFTWARE\Wine", writable: false);
        return wine is not null;
    });
    public static bool IsWine => isWine.Value;


    public static string GetDeployment()
    {
        return (IsUwp, IsWindowsInstallation) switch
        {
            (true, _) => "UWP",
            (false, true) => "Installer",
            (false, false) => "Portable"
        };
    }

    public static bool TryGetVocupInstallation(
        [NotNullWhen(true)] out Version? version,
        [NotNullWhen(true)] out string? installLocation,
        [NotNullWhen(true)] out string? uninstallString)
    {
        version = null;
        installLocation = null;
        uninstallString = null;

        // Vocup is installed as 32bit application
        using RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
        using RegistryKey? vocup = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Vocup_is1", writable: false);

        if (vocup == null) return false;
        if (!Version.TryParse((string?)vocup.GetValue("DisplayVersion"), out Version? temp)) return false;
        version = temp.Revision == -1 ? new Version(temp.Major, temp.Minor, temp.Build, 0) : temp;
        installLocation = (string?)vocup.GetValue("InstallLocation");
        uninstallString = (string?)vocup.GetValue("UninstallString");
        return installLocation is not null && uninstallString is not null;
    }

    [SupportedOSPlatform("windows10.0.10240.0")]
    public static bool TryGetVocupUwpApp([NotNullWhen(true)] out Version? version)
    {
        var packageManager = new PackageManager();
        string? userSecurityId = WindowsIdentity.GetCurrent().User?.Value;
        if (userSecurityId is not null)
        {
            foreach (var package in packageManager.FindPackagesForUser(userSecurityId, "9961VectorData.Vocup_ffrs9s78t67f2"))
            {
                if (!package.IsResourcePackage)
                {
                    version = new Version(package.Id.Version.Major, package.Id.Version.Minor, package.Id.Version.Build, package.Id.Version.Revision);
                    return true;
                }
            }
        }
        version = null;
        return false;
    }

    private const int APPMODEL_ERROR_NO_PACKAGE = 15700;

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern int GetCurrentPackageFullName(ref int packageFullNameLength, StringBuilder packageFullName);
}
