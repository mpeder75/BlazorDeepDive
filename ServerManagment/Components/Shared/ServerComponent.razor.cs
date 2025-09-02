using System.Diagnostics;
using Microsoft.AspNetCore.Components;
using ServerManagment.Models;

namespace ServerManagment.Components.Shared;

public partial class ServerComponent
{
    [Parameter]
    public Server? Server { get; set; }

    [CascadingParameter(Name = "SelectedCity")]
    public string? SelectedCity { get; set; }


    private void DeleteServer(int serverId)
    {
        if (serverId > 0)
        {
            ServersRepository.DeleteServer(serverId);
            NavigationManager.NavigateTo("/servers", true);
        }
    }

    private string GetBackgroundColor()
    {
        if (SelectedCity != null)
        {
            switch(this.SelectedCity)
            {
                case "Toronto": return "powderblue";
                case "Montreal": return "lightgray";
                case "Ottawa": return "palegreen";
                case "Calgary": return "pink";
                case "Halifax": return "white";
                default:
                    return "white";
            }
        }
        else
        {
            return "white";
        }
    }
}