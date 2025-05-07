namespace ErcJul.Tailwind;

using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

public class CssGenerate : ToolTask
{
    [Required]
    public required string ConfigCss { get; set; }
    public string OutputPath { get; set; } = string.Empty;

    [Output]
    public ITaskItem[] OutPutItems { get; set; } = [];
    protected override string ToolName => RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "tailwindcss.exe" : "tailwindcss";

    protected override string GenerateFullPathToTool() => ToolExe;

    protected override string GenerateCommandLineCommands()
    {
        var outputPath = OutputPath;
        if (string.IsNullOrEmpty(outputPath))
        {
            outputPath = Path.Combine("wwwroot", ConfigCss);
        }
        OutPutItems = [new TaskItem(outputPath)];
        return $"--input {ConfigCss} " +
               $"--output {outputPath} ";
    }
}
