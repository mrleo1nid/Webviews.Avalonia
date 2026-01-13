using System.Runtime.InteropServices;
#if WINDOWS || NET10_0_WINDOWS || NET8_0_WINDOWS
using Avalonia.WebView.Windows;
#endif

#if LINUX
using Avalonia.WebView.Linux;
#endif

namespace Avalonia.WebView.Desktop;

public static class AppBuilderExtensions
{
    public static AppBuilder UseDesktopWebView(this AppBuilder builder, bool isWslDevelop = false)
    {
#if WINDOWS || NET10_0_WINDOWS || NET8_0_WINDOWS
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            builder.UseWindowWebView();
#endif
#if LINUX
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            builder.UseLinuxWebView(isWslDevelop);
#endif

        return builder;
    }
}
