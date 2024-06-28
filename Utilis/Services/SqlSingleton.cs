using System.Data;
using System.Data.SqlClient;

public sealed class SqlSingleton
{
	private static readonly Lazy<SqlSingleton> lazyInstance =
		new Lazy<SqlSingleton>(() => new SqlSingleton());

	private SqlConnection connection;
	private SqlTransaction? transaction;

	private SqlSingleton()
	{
		// Replace the connection string with your own.
		string connectionString = "your_connection_string_here";
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
		if (connection.State != ConnectionState.Closed && transaction == null)
		{
			connection.Close();
		}
	}

	public void BeginTransaction()
	{
		EnsureConnectionOpen();
		transaction = connection.BeginTransaction();
	}

	public void CommitTransaction()
	{
		if (transaction != null)
		{
			transaction.Commit();
			transaction.Dispose();
			transaction = null;
			EnsureConnectionClosed();
		}
	}

	public void RollbackTransaction()
	{
		if (transaction != null)
		{
			transaction.Rollback();
			transaction.Dispose();
			transaction = null;
			EnsureConnectionClosed();
		}
	}

	public int ExecuteNonQuery(string query, params SqlParameter[] parameters)
	{
		EnsureConnectionOpen();

		using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
		{
			if (parameters != null)
			{
				cmd.Parameters.AddRange(parameters);
			}

			return cmd.ExecuteNonQuery();
		}
	}

	public object ExecuteScalar(string query, params SqlParameter[] parameters)
	{
		EnsureConnectionOpen();

		using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
		{
			if (parameters != null)
			{
				cmd.Parameters.AddRange(parameters);
			}

			return cmd.ExecuteScalar();
		}
	}

	public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
	{
		EnsureConnectionOpen();

		using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
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
}
