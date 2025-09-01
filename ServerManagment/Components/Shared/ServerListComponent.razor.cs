using Microsoft.AspNetCore.Components;
using ServerManagment.Models;

namespace ServerManagment.Components.Shared;

/// <summary>
///     Viser en liste af servere for en valgt by.
///     By-navnet modtages som parameter fra parent-komponenten.
/// </summary>
public partial class ServerListComponent
{
    // Indeholder listen af servere for den valgte by.
    private List<Server>? servers;

    /// <summary>
    ///     Navnet på den by, som listen skal vise servere for.
    ///     Sættes af parent-komponenten via parameter-binding.
    /// </summary>
    [Parameter]
    public string? CityName { get; set; }

    /// <summary>
    ///     Kaldes automatisk af Blazor, når parameteren CityName ændres.
    ///     Henter servere for den nye by fra repository.
    /// </summary>
    protected override void OnParametersSet()
    {
        servers = ServersRepository.GetServersByCity(CityName??"Toronto");
    }
   
}