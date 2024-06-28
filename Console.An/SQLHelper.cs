using System.Data;

namespace ConsoleTest.An;

public class SQLHelper
{
	public static void DisplayDataTable(DataTable dataTable)
	{
		if (dataTable == null || dataTable.Rows.Count == 0)
		{
			Console.WriteLine("No data found.");
			return;
		}

		// Determine column widths based on the maximum length of column names and data
		int[] columnWidths = new int[dataTable.Columns.Count];
		string[] columnNames = new string[dataTable.Columns.Count];

		// Calculate column widths
		for (int i = 0; i < dataTable.Columns.Count; i++)
		{
			columnNames[i] = dataTable.Columns[i].ColumnName;
			columnWidths[i] = columnNames[i].Length;

			foreach (DataRow row in dataTable.Rows)
			{
				if (!row.IsNull(i))
				{
					int length = row[i].ToString()!.Length;
					if (length > columnWidths[i])
						columnWidths[i] = length;
				}
			}
		}

		// Print column headers
		for (int i = 0; i < dataTable.Columns.Count; i++)
		{
			Console.Write("{0,-" + (columnWidths[i] + 2) + "}", columnNames[i]);
		}
		Console.WriteLine();

		// Print separator line
		for (int i = 0; i < dataTable.Columns.Count; i++)
		{
			Console.Write(new string('-', columnWidths[i] + 2));
		}
		Console.WriteLine();

		// Print data rows
		foreach (DataRow row in dataTable.Rows)
		{
			for (int i = 0; i < dataTable.Columns.Count; i++)
			{
				Console.Write("{0,-" + (columnWidths[i] + 2) + "}", row.IsNull(i) ? "NULL" : row[i].ToString());
			}
			Console.WriteLine();
		}
	}
}
