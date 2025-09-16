using Microsoft.AspNetCore.Components;
using ToDoApp.Models;

namespace ToDoApp.Components.Shared
{
    public partial class ItemsListComponent
    {
        // loade data fra repo
        [Parameter] public List<ToDoItem> Items { get; set; }
    }
    
}
