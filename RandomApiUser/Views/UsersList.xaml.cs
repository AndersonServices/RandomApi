using RandomApiUser.ViewModels;

namespace RandomApiUser.Views;

public partial class UsersList : ContentPage
{
	public UsersList()
	{
		InitializeComponent();
		BindingContext = new UsersListViewModel();
	}
}