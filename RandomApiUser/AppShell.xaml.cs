using RandomApiUser.Views;

namespace RandomApiUser;

public partial class AppShell : Shell
{public AppShell()
	{
		InitializeComponent();
		RegistrarRutas();
	}

	private void RegistrarRutas()
	{
		Routing.RegisterRoute(nameof(UsersList), typeof(UsersList));
		Routing.RegisterRoute(nameof(UserDetails), typeof(UserDetails));
	}
}
