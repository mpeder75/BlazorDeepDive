using ToDoApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Enabler Server interactivity
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

// Enabler Server interactivity
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
