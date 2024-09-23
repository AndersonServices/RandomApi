using RandomApiUser.ViewModels;

namespace RandomApiUser;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}
}


