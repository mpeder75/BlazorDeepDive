using Microsoft.AspNetCore.Components;
using ServerManagment.Models;

namespace ServerManagment.Components.Pages;

public partial class Servers
{
    private List<Server> servers = ServersRepository.GetServersByCity("Toronto");

    private List<String> cities = CitiesRepository.GetCities();

    private string selectedCity = "Toronto";

    private string _serverFilter = "";

    private string serverFilter
    {
        get => _serverFilter;
        set
        {
            _serverFilter = value;
            servers = ServersRepository.SearchServers(_serverFilter);

        }
    }

    private void DeleteServer(int serverId)
    {
        if (serverId > 0)
        {
            ServersRepository.DeleteServer(serverId);
            NavigationManager.NavigateTo("/servers");
        } 
    }

    private void SelectCity(string cityName)
    {
        this.selectedCity = cityName;

        this.servers = ServersRepository.GetServersByCity(selectedCity);
    }

    private void HandleSearch()
    {
        servers = ServersRepository.SearchServers(serverFilter);

        selectedCity = string.Empty;
    }
}