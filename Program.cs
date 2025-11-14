
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConn")));

var app = builder.Build();

app.MapRazorPages();

app.Run();

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<MessageItem> TestTable { get; set; }
}

public class MessageItem
{
    public int Id { get; set; }
    public string Message { get; set; }
}
