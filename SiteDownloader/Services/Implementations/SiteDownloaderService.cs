using SiteDownloader.Repositories.Interfaces;
using SiteDownloader.Services.Interfaces;
using System.Text.RegularExpressions;

namespace SiteDownloader.Services.Implementations;

public class SiteDownloaderService : ISiteDownloaderService
{
    private readonly IFolderRepository _folderRepository;
    private readonly IFileRepository _fileRepository;
    private readonly ISiteRepository _siteRepostory;

    public SiteDownloaderService(IFolderRepository folderRepository, ISiteRepository siteRepository, IFileRepository fileRepository)
    {
        _folderRepository = folderRepository;
        _fileRepository = fileRepository;
        _siteRepostory = siteRepository;
    }
    
    public async Task Download(string url)
    {
        var folderPath = _folderRepository.ClearAndCreateBaseDownloadDirectory();
        var result = await _siteRepostory.DownloadSite(url);
        Regex regex = new Regex(@"<a\s+(?:[^>]*?\s+)?href=""([^""]*)""");
        var matches = regex.Matches(result);
        foreach (Match match in matches)
        {
            var value = match.Groups[1].Value;
            if (value.StartsWith("/") && value.Length > 2)
                Console.WriteLine(value);
        }
        _fileRepository.WriteToFile(folderPath, "main", result);
    }
}
