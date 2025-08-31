using ServerManagment.Components;
using ServerManagment.Components.Services;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddValidatorsFromAssemblyContaining<ServerValidator>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", true);
    app.UseHsts();
}

// ------- Middleware -------- //
app.UseHttpsRedirection();

// ansvarlig for statiske roesource filer som CSS, JS, billeder osv. 
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();