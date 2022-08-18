// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiteDownloader.Configuration;
using SiteDownloader.Services.Implementations;
using SiteDownloader.Services.Interfaces;

using IHost host = HostBuilderConfiguration.CreateHost(args).Build();

Console.WriteLine("SiteDownloader Started Sucessfully");

await ExemplifyScoping(host.Services);

await host.RunAsync();

async static Task ExemplifyScoping(IServiceProvider services)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    var siteDownloaderService = provider.GetRequiredService<ISiteDownloaderService>();

    await siteDownloaderService.Download("https://tretton37.com/");

    Console.ReadLine();
}