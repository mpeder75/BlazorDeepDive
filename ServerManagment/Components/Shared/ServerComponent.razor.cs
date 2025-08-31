using Microsoft.AspNetCore.Components;
using ServerManagment.Models;

namespace ServerManagment.Components.Shared;

public partial class ServerComponent
{
    [SupplyParameterFromForm] private Server? server { get; set; }

    protected override void OnParametersSet()
    {
        server ??= new Server
        {
            Name = "Server 1",
            City = "Toronto"
        };
    }

    private void ChangeServerStatus()
    {
        if (server != null)
        {
            server.IsOnline = !server.IsOnline;
        }
    }
}