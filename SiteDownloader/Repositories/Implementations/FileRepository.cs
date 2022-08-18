using SiteDownloader.Repositories.Interfaces;

namespace SiteDownloader.Repositories.Implementations;

public class FileRepository : IFileRepository
{
    public void WriteToFile(string folderPath, string fileName, string htmlContent)
    {
        Console.WriteLine($"Started - Write to File {fileName} in Path {folderPath}");

        File.WriteAllText($"{folderPath}//{fileName}.html", htmlContent);

        Console.WriteLine("Completed - Write to File");
    }
}
