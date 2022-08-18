using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiteDownloader.Repositories.Implementations;
using SiteDownloader.Repositories.Interfaces;
using SiteDownloader.Services.Implementations;
using SiteDownloader.Services.Interfaces;

namespace SiteDownloader.Configuration;

public static class HostBuilderConfiguration
{
    public static IHostBuilder CreateHost(string[] args) 
    {
        return Host.CreateDefaultBuilder(args)
               .ConfigureServices((_, services) =>
        services
            .AddScoped<IFileRepository, FileRepository>()
            .AddScoped<ISiteRepository, SiteRepository>()
            .AddScoped<IFolderRepository, FolderRepository>()
            .AddScoped<ISiteDownloaderService, SiteDownloaderService>());
    }
}
