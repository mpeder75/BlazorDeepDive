using ServerManagment.Models;

namespace ServerManagment.Components.Pages;

public partial class Servers
{
    private string selectedCity = "Toronto";

    private string _serverFilter = "";

    private string serverFilter
    {
        get => _serverFilter;
        set
        {
            _serverFilter = value;
        }
    }

    private void HandleSearch()
    {
        //selectedCity = string.Empty;
    }

    private void HandleCitySelection(string cityName)
    {
        selectedCity = cityName;
    }
}