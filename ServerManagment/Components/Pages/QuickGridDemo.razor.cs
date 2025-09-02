using Microsoft.AspNetCore.Components.QuickGrid;
using ServerManagment.Models;

namespace ServerManagment.Components.Pages;

public partial class QuickGridDemo
{
    private readonly List<Server>? servers = ServersRepository.GetServers();

    private PaginationState paginationState = new PaginationState { ItemsPerPage = 5 };

    private void DeleteServer(int serverId)
    {
        if (serverId > 0)
        {
            ServersRepository.DeleteServer(serverId);
            NavigationManager.NavigateTo("/Quickgrid", true);
        }
    }
}