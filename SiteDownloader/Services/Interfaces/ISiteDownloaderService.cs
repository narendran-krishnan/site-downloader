namespace SiteDownloader.Services.Interfaces;

public interface ISiteDownloaderService
{
    Task Download(string url);
}
