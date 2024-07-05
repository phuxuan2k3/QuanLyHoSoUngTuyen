using System.Data.SqlClient;
using System.Text.RegularExpressions;

try
{
	var script = File.ReadAllText(Path.Join(AppDomain.CurrentDomain.BaseDirectory, "Database", "database.sql"));
	IEnumerable<string> commandStrings = Regex.Split(script, @"GO", RegexOptions.Multiline | RegexOptions.IgnoreCase);
	SqlSingleton.Instance.ExecuteNonQuery(commandStrings);
	Console.WriteLine("Sucessfully executed!");
}
catch (SqlException e)
{
	Console.WriteLine("SQL Error: " + e.Message);
}
catch (Exception e)
{
	Console.WriteLine("Error: " + e.Message);
}
