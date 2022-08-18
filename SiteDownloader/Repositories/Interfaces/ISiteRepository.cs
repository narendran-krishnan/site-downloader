namespace SiteDownloader.Repositories.Interfaces;

public interface ISiteRepository
{
    Task<string> DownloadSite(string url);
}
