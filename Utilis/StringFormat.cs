using System.Globalization;

namespace Utilis;

public static class StringFormat
{
	public static string ToDateString(this DateTime? dateTime)
	{
		return dateTime?.ToString("dd/MM/yyyy") ?? string.Empty;
	}
	
	public static string ToDateString(this DateTime dateTime)
	{
		return dateTime.ToString("dd/MM/yyyy");
	}

	public static string ToVNDString(this float? amount)
	{
		CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
		return amount?.ToString("#,###", cul.NumberFormat) ?? string.Empty;
	}

	public static string ToVNDString(this float amount)
	{
		CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
		return amount.ToString("#,###", cul.NumberFormat);
	}
}
