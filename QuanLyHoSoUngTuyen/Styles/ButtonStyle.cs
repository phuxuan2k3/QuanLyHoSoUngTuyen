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
		button.Padding = new Padding(5, 2, 5, 2);
		button.FlatStyle = FlatStyle.Flat;
		button.FlatAppearance.BorderColor = Color.Black;
		switch (tag)
		{
			case "red":
				button.BackColor = Color.OrangeRed;
				break;
			case "green":
				button.BackColor = Color.Lime;
				break;
			case "blue":
				button.BackColor = Color.RoyalBlue;
				button.ForeColor = Color.White;
				break;
		}
	}
}
