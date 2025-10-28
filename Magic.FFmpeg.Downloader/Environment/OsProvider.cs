using System.Text;

namespace Magic.FFmpeg.Downloader.Environment;

public static class OsProvider
{
    public static string Name
    {
        get
        {
            StringBuilder name = new StringBuilder();
            if (OperatingSystem.IsLinux())
            {
                name.Append("linux")
                if (IsArm64)
                {
                    name.Append("-arm64");
                }
                else
                {
                    name.Append("-armhf")
                }
            }
            else if (OperatingSystem.IsWindows())
            {
                name.Append("windows-64");
            }
            else if (OperatingSystem.IsMacOS())
            {
                name.Append("osx")
            }

            if (Is64)
            {
                name.Append("-64");
            }
            else if (Is32)
            {
                name.Append("-32");
            }

            return name.ToString();
        }
    }
    public static bool IsArm => IsArm64 || IsArm32;
    public static bool IsArm64 => System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture == System.Runtime.InteropServices.Architecture.Arm64;
    public static bool IsArm32 => System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture == System.Runtime.InteropServices.Architecture.Arm;
    public static bool Is64 => System.Runtime.InteropServices.RuntimeEnvironment.ProcessArchitecture == System.Runtime.InteropServices.Architecture.X64;
    public static bool Is32 => System.Runtime.InteropServices.RuntimeEnvironment.ProcessArchitecture == System.Runtime.InteropServices.Architecture.X86;
}
