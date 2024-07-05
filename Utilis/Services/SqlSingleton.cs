using System.Data;
using System.Data.SqlClient;
using Utilis;

public sealed class SqlSingleton
{
	private static readonly Lazy<SqlSingleton> lazyInstance =
		new Lazy<SqlSingleton>(() => new SqlSingleton());

	private SqlConnection connection;

	private SqlSingleton()
	{
		// Replace the connection string with your own in App.config.
		// Replace the connection string with your own in App.config.
		// Replace the connection string with your own in App.config.

		string connectionString = ConfigurationHelper.GetConnectionString();
		connection = new SqlConnection(connectionString);
	}

	public static SqlSingleton Instance
	{
		get
		{
			return lazyInstance.Value;
		}
	}

	public SqlConnection Connection
	{
		get
		{
			return connection;
		}
	}

	private void EnsureConnectionOpen()
	{
		if (connection.State != ConnectionState.Open)
		{
			connection.Open();
		}
	}

	private void EnsureConnectionClosed()
	{
		if (connection.State != ConnectionState.Closed)
		{
			connection.Close();
		}
	}

	public int ExecuteNonQuery(string query, params SqlParameter[] parameters)
	{
		try
		{
			EnsureConnectionOpen();

			using (SqlCommand cmd = new SqlCommand(query, connection))
			{
				if (parameters != null)
				{
					cmd.Parameters.AddRange(parameters);
				}

				return cmd.ExecuteNonQuery();
			}
		}
		finally
		{
			EnsureConnectionClosed();
		}
	}

	public object ExecuteScalar(string query, params SqlParameter[] parameters)
	{
		try
		{
			EnsureConnectionOpen();

			using (SqlCommand cmd = new SqlCommand(query, connection))
			{
				if (parameters != null)
				{
					cmd.Parameters.AddRange(parameters);
				}

				return cmd.ExecuteScalar();
			}
		}
		finally
		{
			EnsureConnectionClosed();
		}
	}

	public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
	{
		try
		{
			EnsureConnectionOpen();

			using (SqlCommand cmd = new SqlCommand(query, connection))
			{
				if (parameters != null)
				{
					cmd.Parameters.AddRange(parameters);
				}

				using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
				{
					DataTable resultTable = new DataTable();
					adapter.Fill(resultTable);
					return resultTable;
				}
			}
		}
		finally
		{
			EnsureConnectionClosed();
		}
	}

	public void ExecuteNonQuery(IEnumerable<string> queries, params SqlParameter[] parameters)
	{
		try
		{
			EnsureConnectionOpen();
			foreach (string query in queries)
			{
				if (!string.IsNullOrWhiteSpace(query.Trim()))
				{
					using (var command = new SqlCommand(query, Connection))
					{
						command.ExecuteNonQuery();
					}
				}
			}
		}
		finally
		{
			EnsureConnectionClosed();
		}
	}
}
