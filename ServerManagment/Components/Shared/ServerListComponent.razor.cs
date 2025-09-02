using Microsoft.AspNetCore.Components;
using ServerManagment.Models;

namespace ServerManagment.Components.Shared;

public partial class ServerListComponent
{
    [Parameter] public string SearchFilter { get; set; }

    [Parameter] public string? CityName { get; set; } = ""; 

    private List<Server>? servers;

    protected override void OnParametersSet()
    {
        if (string.IsNullOrWhiteSpace(this.SearchFilter))
        {
            servers = ServersRepository.GetServersByCity(CityName ?? "Toronto");
        }
        else
        {
            servers = ServersRepository.SearchServers(SearchFilter);

        }
    }
}