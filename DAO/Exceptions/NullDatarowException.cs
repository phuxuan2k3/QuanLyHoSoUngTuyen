using System.Runtime.Serialization;

namespace DAO.Exceptions
{
	public class NullDatarowException : Exception
	{
		public NullDatarowException()
		{
		}

		public NullDatarowException(string? message) : base(message)
		{
		}

		public NullDatarowException(string? message, Exception? innerException) : base(message, innerException)
		{
		}
	}
}
