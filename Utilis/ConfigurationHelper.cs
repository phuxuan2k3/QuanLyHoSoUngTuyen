using System.Configuration;
namespace Utilis;

public static class ConfigurationHelper
{
	public static string GetConnectionString()
	{
		var defaultConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"] ?? throw new ConfigurationErrorsException("No DefaultConnection connection string found!");
		return defaultConnection.ConnectionString;
	}
}
