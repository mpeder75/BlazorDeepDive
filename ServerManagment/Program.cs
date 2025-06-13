using ServerManagment.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

// ------- Middleware -------- //
app.UseHttpsRedirection();

// ansvarlig for statiske roesource filer som CSS, JS, billeder osv. 
app.UseStaticFiles();
app.UseAntiforgery();

// route http requests til App.razor class som er root 
app.MapRazorComponents<App>(); 

app.Run();
