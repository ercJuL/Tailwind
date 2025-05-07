namespace ErcJul.Tailwind;

using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

public class CssGenerate : ToolTask
{
    [Required]
    public required string ConfigCss { get; set; }
    [Required]
    public required string OutputPath { get; set; }

    [Output]
    public ITaskItem[] OutPutItems { get; set; } = [];
    protected override string ToolName => RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "tailwindcss.exe" : "tailwindcss";

    protected override string GenerateFullPathToTool() => ToolExe;

    protected override string GenerateCommandLineCommands()
    {
        OutPutItems = [new TaskItem(OutputPath)];
        return $"--input {ConfigCss} " +
               $"--output {OutputPath} ";
    }
}
