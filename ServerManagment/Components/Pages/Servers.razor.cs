using ServerManagment.Components.Shared;
using ServerManagment.Models;

namespace ServerManagment.Components.Pages;

public partial class Servers
{
    private string selectedCity = "Toronto";

    private string searchFilter = "";

    private CityListComponent? cityListComponent;
    private SearchBarComponent? searchBarComponent;

    private void HandleCitySelection(string cityName)
    {
        selectedCity = cityName;
        this.searchFilter = string.Empty;
        searchBarComponent?.ClearFilter();
    }

    private void HandleSearchServer(string searchFilter)
    {
        this.searchFilter = searchFilter;

        cityListComponent?.ClearSelection();
    }
}