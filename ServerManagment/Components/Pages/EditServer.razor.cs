using Microsoft.AspNetCore.Components;
using ServerManagment.Models;

namespace ServerManagment.Components.Pages;

public partial class EditServer
{
    [Parameter] 
    public int Id { get; set; }

    [SupplyParameterFromForm]
    private Server? server { get; set; }

    protected override void OnParametersSet()
    {
        // serverobjekt hentes baseret på id fra route "@page "/servers/{id:int}"
        server ??= ServersRepository.GetServerById(Id);
    }

    private void Submit()
    {
        if (server != null)
        {
            ServersRepository.UpdateServer(server.ServerId, server);
            NavigationManager.NavigateTo("/servers");
        }
    }
}