using System;
using System.Windows.Input;
using RandomApiUser.Views;

namespace RandomApiUser.ViewModels;

public class MainPageViewModel : BaseViewModel
{
    public ICommand VerListadoCommand {get; set;}

    public MainPageViewModel()
    {
        VerListadoCommand = new Command(VerListado);
    }

    private async void VerListado()
    {
        var ruta = $"{nameof(UsersList)}";
        await Shell.Current.GoToAsync(ruta);        
    }
}
