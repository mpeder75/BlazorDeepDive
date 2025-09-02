using Microsoft.AspNetCore.Components;
using ServerManagment.Models;

namespace ServerManagment.Components.Shared;

public partial class CityListComponent
{
    [Parameter] public EventCallback<string> SelectCityCallback { get; set; }

    private List<string>? cities = CitiesRepository.GetCities();

    private string selectedCity = "Toronto";

    private void HandleCitySelection(string cityName)
    {
        selectedCity = cityName;

        SelectCityCallback.InvokeAsync(cityName);
    }

    public void ClearSelection()
    {
        this.selectedCity = string.Empty;
    }
}