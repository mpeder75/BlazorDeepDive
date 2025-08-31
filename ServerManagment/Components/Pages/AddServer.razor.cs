using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using ServerManagment.Models;

namespace ServerManagment.Components.Pages
{
    public partial class AddServer
    {
        [SupplyParameterFromForm]
        private Server server { get; set; } = new Server()
        {
            IsOnline = false
        };

        private void Submit()
        {
            if (server != null)
            {
                ServersRepository.AddServer(server);
                NavigationManager.NavigateTo("/servers");
            }
        }
    }
}
