using Microsoft.AspNetCore.Components;
using ToDoApp.Models;

namespace ToDoApp.Components.Shared
{
    public partial class ItemComponent
    {
        [Parameter] public ToDoItem? Item { get; set; }

    }
}
