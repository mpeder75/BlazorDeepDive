using Microsoft.AspNetCore.Components;

namespace ServerManagment.Components.Shared;

public partial class CityComponent
{
    [Parameter] public string selectedCity { get; set; } = "Toronto";

    [Parameter] public string city { get; set; } = "";

    [Parameter] public EventCallback<string> SelectCityCallback { get; set; }

    private void SelectCity(string cityName)
    {
        SelectCityCallback.InvokeAsync(cityName);
    }
}