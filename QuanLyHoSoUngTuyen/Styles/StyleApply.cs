namespace GUI.Styles;

public class Style
{
	// Even nested ones
	// Post-order traversal
	public static void ApplyStylingEventOnChildControlAdded(Control control, Action<Control> styling)
	{
		void StyleNewlyAddedEvent(object? s, ControlEventArgs e)
		{
			if (e.Control != null)
			{
				Stack<Control> stack = new();
				stack.Push(e.Control);
				while (stack.Count > 0)
				{
					Control curControl = stack.Pop();
					curControl.ControlAdded += StyleNewlyAddedEvent;
					styling.Invoke(curControl);
					foreach (Control childControl in curControl.Controls)
					{
						stack.Push(childControl);
					}
				}
				//styling.Invoke(e.Control);
				//e.Control.ControlAdded += StyleNewlyAddedEvent;
			}
		}
		control.ControlAdded += StyleNewlyAddedEvent;
	}
}
