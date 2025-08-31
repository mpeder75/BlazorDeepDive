using ServerManagment.Models;

namespace ServerManagment.Components.Shared;

public partial class ServerComponent
{
    private Server? server { get; set; } = new Server { Name = "Server", City = "Toronto" };

    private void ChangeStatus()
    {
        if (server != null)
        {
            this.server.IsOnline = !this.server.IsOnline;
        }
    }
}