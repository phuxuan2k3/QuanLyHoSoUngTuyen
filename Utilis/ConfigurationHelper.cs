using System.Configuration;
namespace Utilis;

public static class ConfigurationHelper
{
	public static string GetConnectionString()
	{
		return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
	}
}
