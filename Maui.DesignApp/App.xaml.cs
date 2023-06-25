using Maui.DesignApp.Views;

namespace Maui.DesignApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Dashboard();
	}
}
