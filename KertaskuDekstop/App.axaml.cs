using System.Globalization;

using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using KertaskuDesktop.ViewModels;
using KertaskuDesktop.Views;

namespace KertaskuDesktop;

public partial class App : Application
{
		public override void Initialize()
		{
				AvaloniaXamlLoader.Load(this);
		}

		public override void OnFrameworkInitializationCompleted()
		{
				//KertaskuDesktop.Assets.Resource.ResourceManager.GetString("Abc");
				//Assets.Resource.Culture = new CultureInfo("id-ID");
				if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
				{
						desktop.MainWindow = new MainWindow
						{
								DataContext = new MainViewModel()
						};
				}
				else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
				{
						singleViewPlatform.MainView = new MainView
						{
								DataContext = new MainViewModel()
						};
				}

				base.OnFrameworkInitializationCompleted();
		}
}
