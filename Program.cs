using Microsoft.EntityFrameworkCore;
using Phd_Port.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
var connectionString = builder.Configuration.GetConnectionString("Book_mark_hub");
builder.Services.AddDbContextPool<BookmarkhubContext>(option => option.UseMySQL(connectionString));
builder.Services.AddDbContextFactory<BookmarkhubContext>(option => option.UseMySQL($"Data Source={nameof(BookmarkhubContext.Database)}.db"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
