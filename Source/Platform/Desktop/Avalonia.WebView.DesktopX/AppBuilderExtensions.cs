using Avalonia.WebView.Desktop;

namespace Avalonia.WebView.DesktopX;

public static class AppBuilderExtensions
{
    public static AppBuilder UseDesktopWebView(this AppBuilder builder, bool isWslDevelop = false)
    {
#if __WINDOWS__
        builder.UseWindowWebView();
#elif __LINUX__
        builder.UseLinuxWebView(isWslDevelop);
#endif

        return builder;
    }
}

