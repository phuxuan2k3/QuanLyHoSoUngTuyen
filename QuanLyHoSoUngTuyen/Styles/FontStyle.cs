namespace GUI.Styles;

public class MyFontStyle
{
	public static void Apply(Control control, float ratio = 1)
	{
		var fontFamily = new FontFamily("Segoe UI");
		var fontStyle = control.Font.Style;
		var fontSize = control.Font.Size * ratio;
		control.Font = new Font(fontFamily, fontSize, fontStyle);
	}
}
