namespace ErcJul.Tailwind;

using System.Runtime.InteropServices;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

public class CssGenerate : ToolTask
{
    [Required]
    public required string ConfigCss { get; set; }

    public string Minify { get; set; } = string.Empty;

    [Output]
    public ITaskItem[] OutPutItems { get; set; } = [];

    public string OutputPath { get; set; } = string.Empty;

    protected override string ToolName => RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "tailwindcss.exe" : "tailwindcss";

    protected override string GenerateCommandLineCommands()
    {
        var outputPath = OutputPath;
        if (string.IsNullOrEmpty(outputPath))
        {
            outputPath = Path.Combine(Environment.CurrentDirectory, "wwwroot", "app.css");
        }
        if (!outputPath.EndsWith(".css", StringComparison.OrdinalIgnoreCase))
        {
            outputPath = Path.Combine(OutputPath, ConfigCss);
        }
        OutPutItems = [new TaskItem(outputPath)];
        var commands = new List<string>
        {
            $"--input {ConfigCss}",
            $"--output {outputPath}",
        };
        if (bool.TryParse(Minify, out var ifMinify) && ifMinify)
        {
            commands.Add("--minify");
        }
        return string.Join(' ', commands);
    }

    protected override string GenerateFullPathToTool() => ToolExe;
}
