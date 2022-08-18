using SiteDownloader.Repositories.Interfaces;

namespace SiteDownloader.Repositories.Implementations;

public class SiteRepository : ISiteRepository
{
    public async Task<string> DownloadSite(string url)
    {
        string result;
        using (HttpClient client = new())
        {
            var request = await client.GetAsync(url);
            result = await request.Content.ReadAsStringAsync();
        }
        return result;
    }
}
