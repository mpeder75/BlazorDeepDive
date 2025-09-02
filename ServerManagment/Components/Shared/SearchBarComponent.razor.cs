using Microsoft.AspNetCore.Components;

namespace ServerManagment.Components.Shared
{
    public partial class SearchBarComponent
    {
        [Parameter]
        public EventCallback<string> SearchServerCallback { get; set; }

        public void ClearFilter()
        {
            serverFilter = string.Empty;
        }

        private string serverFilter = "";

        private void HandleSearch()
        {
            SearchServerCallback.InvokeAsync(serverFilter);
        }
    }
}
