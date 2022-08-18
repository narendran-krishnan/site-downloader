namespace SiteDownloader.Repositories.Interfaces;

public interface IFileRepository
{
    void WriteToFile(string folderPath, string fileName, string htmlContent);
}
