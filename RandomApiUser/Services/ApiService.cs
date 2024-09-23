using System;
using System.Collections.ObjectModel;
using System.Text.Json;
using RandomApiUser.Models;

namespace RandomApiUser.Services;

public class ApiService
{
    string endpoint = "https://random-data-api.com/api/v2/users?size=20";
    private HttpClient client;

    public ApiService()
    {
        client = new HttpClient();
        client.BaseAddress = new Uri(endpoint);
    }

    public async Task<ObservableCollection<User>> GetUsersAsync()
    {
        ObservableCollection<User>? Users = new ObservableCollection<User>();
        try
        {
            HttpResponseMessage response = await client.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Users = JsonSerializer.Deserialize<ObservableCollection<User>>(content);
            }

        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Mensaje de Error", ex.Message, "Cerrar");
        }

        return Users;
    }
}
