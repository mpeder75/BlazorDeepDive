using Microsoft.AspNetCore.Components;
using ServerManagment.Models;

namespace ServerManagment.Components.Shared;

public partial class ServerComponent
{
    [Parameter]
    public Server? Server { get; set; } 

    private void DeleteServer(int serverId)
    {
        if (serverId > 0)
        {
            ServersRepository.DeleteServer(serverId);
            NavigationManager.NavigateTo("/servers", true);
        }
    }
}