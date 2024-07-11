using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;

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
		return amount.ToString("#,###", cul.NumberFormat) + " VND";
	}

	public static string RemoveVietnameseAccent(this string s)
	{
		Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
		string temp = s.Normalize(NormalizationForm.FormD);
		return regex.Replace(temp, string.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
	}
}
