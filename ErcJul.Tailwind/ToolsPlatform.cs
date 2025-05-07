namespace ErcJul.Tailwind;

using System.Runtime.InteropServices;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

/// <summary>
///     A helper task to resolve actual OS type and bitness.
/// </summary>
public class ToolsPlatform : Task
{
    /// <summary>
    ///     Return one of 'linux', 'macosx' or 'windows'.
    ///     If the OS is unknown, the property is not set.
    /// </summary>
    [Output]
    public string Os { get; set; } = string.Empty;

    /// <summary>
    ///     Return one of 'x64', 'x86', 'arm64'.
    ///     If the CPU is unknown, the property is not set.
    /// </summary>
    [Output]
    public string Cpu { get; set; } = string.Empty;

    public override bool Execute()
    {

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Os = "windows";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            Os = "macos";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            Os = "linux";
        }

        switch (RuntimeInformation.ProcessArchitecture)
        {
            case Architecture.X86:
                Cpu = "x86";
                break;
            case Architecture.X64:
                Cpu = "x64";
                break;
            case Architecture.Arm64:
                Cpu = "arm64";
                break;
        }

        if (Os == "windows")
        {
            Cpu = "x64";
        }

        return true;
    }
}
