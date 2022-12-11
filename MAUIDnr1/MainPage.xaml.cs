#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif

namespace MAUIDnr1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.Loaded += MainPage_Loaded;
    }

    private void MainPage_Loaded(object sender, EventArgs e)
    {
#if WINDOWS
        var width = DeviceDisplay.Current.MainDisplayInfo.Width;
        var height = DeviceDisplay.Current.MainDisplayInfo.Height;
        var X = Convert.ToInt32((width / 2) - ((double)AppState.WindowWidth / 2));
        var Y = Convert.ToInt32((height / 2) - ((double)AppState.WindowHeight / 2));
        var point = new PointInt32();
        point.X = X;
        point.Y = Y;
        AppState.AppWindow.Hide();
        AppState.AppWindow.Resize(new SizeInt32(AppState.WindowWidth, AppState.WindowHeight));
        AppState.AppWindow.Move(point);
        AppState.AppWindow.Show();
#endif
    }
}