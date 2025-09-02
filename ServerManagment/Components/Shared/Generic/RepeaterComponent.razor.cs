using Microsoft.AspNetCore.Components;

namespace ServerManagment.Components.Shared.Generic;

public partial class RepeaterComponent<TItem>
{
    [Parameter] 
    public List<TItem>? Items { get; set; }

    [Parameter]
    public RenderFragment<TItem>? Row { get; set; }

    [Parameter]
    public RenderFragment? Header { get; set; }
    
    [Parameter]
    public RenderFragment? Footer { get; set; }
}