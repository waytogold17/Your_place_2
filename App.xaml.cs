using hotellerie.Data;

namespace hotellerie;

public partial class App : Application
{
	public static Donnees donnes { get; private set; }
	public App(Donnees donnes )
	{
		InitializeComponent();

		MainPage = new AppShell();
		

	}
}
