using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using RandomApiUser.Models;

namespace RandomApiUser.ViewModels;

public class UsersListViewModel : BaseViewModel
{
    ApiService apiService;
    private ObservableCollection<User> _Users;
    private User _UserSeleccionado;
    public ICommand UserCommand { get; set; }
    public ObservableCollection<User> Users { get { return _Users; } set { _Users = value; OnPropertyChanged(); } }
    public User? UserSeleccionado { get { return _UserSeleccionado; } set { _UserSeleccionado = value; OnPropertyChanged(); } }

    public UsersListViewModel()
    {
        UserCommand = new Command(SeleccionarUser);
        apiService = new ApiService();
        CargarUsers();
    }

    private async void SeleccionarUser()
    {
        if (UserSeleccionado != null)
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "UserSeleccionado", UserSeleccionado}
            };
            string ruta = $"{nameof(UserDetails)}";
            await Shell.Current.GoToAsync(ruta, navigationParameter);
            UserSeleccionado = null;
        }
    }
    private async void CargarUsers()
    {
        Users = await apiService.GetUsersAsync();
    }
}
