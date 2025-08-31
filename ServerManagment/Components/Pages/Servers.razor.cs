using ServerManagment.Models;

namespace ServerManagment.Components.Pages;

public partial class Servers
{
    private List<Server> serversList = ServersRepository.GetServersByCity("Toronto");

    private List<String> cities = CitiesRepository.GetCities();

    private void DeleteServer(int serverId)
    {
        if (serverId > 0)
        {
            ServersRepository.DeleteServer(serverId);
            NavigationManager.NavigateTo("/servers");
        } 
    }
}