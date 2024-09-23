using System;
using RandomApiUser.Models;

namespace RandomApiUser.ViewModels;

[QueryProperty(nameof(UserSeleccionado), "UserSeleccionado")]
public class UserDetailsViewModel : BaseViewModel
{
    private User? _UserSeleccionado;
    public User? UserSeleccionado { get { return _UserSeleccionado; } set { _UserSeleccionado = value; OnPropertyChanged(); } }
    
    public UserDetailsViewModel()
    {
    }
}
