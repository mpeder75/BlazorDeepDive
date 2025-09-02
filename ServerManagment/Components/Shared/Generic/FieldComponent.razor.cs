using Microsoft.AspNetCore.Components;

namespace ServerManagment.Components.Shared.Generic
{
    public partial class FieldComponent
    {
        [Parameter] public string? Label { get; set; }

        [Parameter] public RenderFragment? Control { get; set; }
    }
}
