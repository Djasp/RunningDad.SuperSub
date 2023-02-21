namespace RunningDad.SuperSub;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		
		//MainPage = new AppShell();
		
		var navPage = new NavigationPage(new MainPage())
		{
				BarBackgroundColor = Colors.Orange,
				BarTextColor = Colors.White
						
				
		};

		MainPage = navPage;
	}
}