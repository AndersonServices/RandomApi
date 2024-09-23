using RandomApiUser.ViewModels;

namespace RandomApiUser.Views;

public partial class UserDetails : ContentPage
{
	public UserDetails()
	{
		InitializeComponent();
		BindingContext = new UserDetailsViewModel();
	}
}