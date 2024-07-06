using DTO;
using System.Runtime.Serialization;

namespace GUI.GUIException;

public class ControllerNotFoundException : Exception
{
	public ControllerNotFoundException() : base("No Controller found.")
	{
	}

	public ControllerNotFoundException(string? message) : base(message)
	{
	}

	public ControllerNotFoundException(string? message, Exception? innerException) : base(message, innerException)
	{
	}
}
