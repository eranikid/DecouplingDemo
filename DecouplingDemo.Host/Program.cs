using DecouplingDemo.Web;

var builder = new HostBuilder();
builder.ConfigureServices(services =>
{
    services.AddControllers()
        .AddApplicationPart(typeof(SomeController).Assembly);
});
builder.ConfigureLogging(logging =>
{
    logging.AddConsole();
});
builder.ConfigureWebHost(host =>
{
    host.UseKestrel(kestrel =>
    {
        kestrel.ListenLocalhost(5000);
    });
    host.Configure(app =>
    {
        app.UseRouting();

        app.UseEndpoints(route =>
        {
            route.MapControllers();
        });
    });
});
var app = builder.Build();

app.Run();