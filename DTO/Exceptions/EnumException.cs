using System.Runtime.Serialization;

namespace DTO.Exceptions
{
	public class EnumException : Exception
	{
		public EnumException()
		{
		}

		public EnumException(string? message) : base(message)
		{
		}

		public EnumException(string? message, Exception? innerException) : base(message, innerException)
		{
		}
	}
}
