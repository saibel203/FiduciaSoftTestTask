using System.Diagnostics;

namespace FiduciaSoftTestTask.Infrastructure.PowerShell;

public class PowerShellTerminal
{
    public void RunShellCommand(string argument, bool showWindow = true)
    {
        Process process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                WindowStyle = showWindow ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = $"/C {argument}",
                CreateNoWindow = showWindow,
                UseShellExecute = false,
                WorkingDirectory = Directory.GetCurrentDirectory()
            }
        };

        process.Start();
    }
}
