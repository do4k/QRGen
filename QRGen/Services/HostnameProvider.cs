using System.Net;

namespace QRGen.Services;

public interface IHostnameProvider
{
    public string Hostname { get; }
}

public class HostnameProvider(IConfiguration configuration) : IHostnameProvider
{
    public string Hostname
    {
        get
        {
            var hostname = configuration.GetValue<string>("hostname");
            return hostname ?? "localhost";
        }
    }
}