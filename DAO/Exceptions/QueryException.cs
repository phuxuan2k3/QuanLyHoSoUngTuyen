using System.Runtime.Serialization;

namespace DAO.Exceptions
{
	public class QueryException : Exception
	{
		public QueryException()
		{
		}

		public QueryException(string? message) : base(message)
		{
		}

		public QueryException(string? message, Exception? innerException) : base(message, innerException)
		{
		}
	}
}
