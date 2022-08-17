// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Hosting;
using SiteDownloader.Configuration;

using IHost host = HostBuilderConfiguration.CreateHost(args).Build();

Console.WriteLine("SiteDownloader Started Sucessfully");