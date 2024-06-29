using System.Data.SqlClient;
using System.Data;
using ConsoleTest.An;

SqlSingleton dbInstance = SqlSingleton.Instance;

try
{
	// Example: Insert a new record
	// Sample data for insertion
	var dataToInsert = new[]
	{
new { MADN = 1, SONGAYDT = 30, MAHTDT = 1, THOIGIANXETTUYEN = 7, TRANGTHAI = "Hợp lệ", TINHTRANG = "Đã đăng tuyển", TENVITRI = "Kỹ sư phần mềm", SOLUONG = 5, YEUCAU = "Tốt nghiệp đại học, 2 năm kinh nghiệm." },
	new { MADN = 2, SONGAYDT = 15, MAHTDT = 2, THOIGIANXETTUYEN = 5, TRANGTHAI = "Không hợp lệ", TINHTRANG = "Cần hiệu chỉnh", TENVITRI = "Chuyên viên IT", SOLUONG = 3, YEUCAU = "Tốt nghiệp cao đẳng, 1 năm kinh nghiệm." },
	new { MADN = 3, SONGAYDT = 20, MAHTDT = 3, THOIGIANXETTUYEN = 10, TRANGTHAI = "Chưa xét duyệt", TINHTRANG = "Chưa đăng tuyển", TENVITRI = "Nhân viên kinh doanh", SOLUONG = 2, YEUCAU = "Tốt nghiệp đại học, không yêu cầu kinh nghiệm." },
	new { MADN = 4, SONGAYDT = 25, MAHTDT = 1, THOIGIANXETTUYEN = 15, TRANGTHAI = "Hợp lệ", TINHTRANG = "Đã đăng tuyển", TENVITRI = "Kỹ sư điện", SOLUONG = 4, YEUCAU = "Tốt nghiệp đại học, 3 năm kinh nghiệm." },
	new { MADN = 5, SONGAYDT = 10, MAHTDT = 2, THOIGIANXETTUYEN = 3, TRANGTHAI = "Hợp lệ", TINHTRANG = "Cần hiệu chỉnh", TENVITRI = "Nhân viên hành chính", SOLUONG = 1, YEUCAU = "Tốt nghiệp trung cấp, 1 năm kinh nghiệm." }
		};

	// SQL insert query with parameters
	string insertQuery = @"
            INSERT INTO [dbo].[THONGTINDANGTUYEN] 
                ([MADN], [SONGAYDT], [MAHTDT], [THOIGIANXETTUYEN], [TRANGTHAI], [TINHTRANG], [TENVITRI], [SOLUONG], [YEUCAU]) 
            VALUES 
                (@MADN, @SONGAYDT, @MAHTDT, @THOIGIANXETTUYEN, @TRANGTHAI, @TINHTRANG, @TENVITRI, @SOLUONG, @YEUCAU)";

	foreach (var item in dataToInsert)
	{
		// Create SqlParameter objects for each parameter
		SqlParameter[] parameters =
		{
				new SqlParameter("@MADN", item.MADN),
				new SqlParameter("@SONGAYDT", item.SONGAYDT),
				new SqlParameter("@MAHTDT", item.MAHTDT),
				new SqlParameter("@THOIGIANXETTUYEN", item.THOIGIANXETTUYEN),
				new SqlParameter("@TRANGTHAI", item.TRANGTHAI),
				new SqlParameter("@TINHTRANG", item.TINHTRANG),
				new SqlParameter("@TENVITRI", item.TENVITRI),
				new SqlParameter("@SOLUONG", item.SOLUONG),
				new SqlParameter("@YEUCAU", item.YEUCAU)
			};

		try
		{
			// Execute the command
			int rowsAffected = dbInstance.ExecuteNonQuery(insertQuery, parameters);
			Console.WriteLine($"Rows affected: {rowsAffected}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"An error occurred: {ex.Message}");
		}
	}

	// Example: Retrieve a single value
	string scalarQuery = "SELECT COUNT(*) FROM THONGTINDANGTUYEN";
	object userCount = dbInstance.ExecuteScalar(scalarQuery);
	Console.WriteLine("Number of users: " + userCount);

	// Example: Retrieve a result set
	string selectQuery = "SELECT * FROM THONGTINDANGTUYEN";
	DataTable users = dbInstance.ExecuteQuery(selectQuery);
	SQLHelper.DisplayDataTable(users);
}
catch (Exception ex)
{
	Console.WriteLine("An error occurred: " + ex.Message);
}