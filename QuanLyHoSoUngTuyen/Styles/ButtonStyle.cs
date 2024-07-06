namespace GUI.Styles;

public class ButtonStyle
{
	public static void Apply(Control control)
	{
		if (control is not Button button)
		{ return; }
		if (button.Tag != null)
		{
			var tag = (string)button.Tag;
			FunctionalButton(button, tag);
		}
	}

	private static void FunctionalButton(Button button, string tag)
	{
		switch (tag)
		{
			case "red":
				button.BackColor = Color.Salmon;
				break;
			case "green":
				button.BackColor = Color.LightGreen;
				break;
			case "blue":
				button.BackColor = Color.DarkCyan;
				button.ForeColor = Color.White;
				break;
		}
	}
}
