using System;
namespace EmployeeCrm.Application.Exceptions.EventException
{
	public class EventNotFoundException : Exception
	{
		public EventNotFoundException() : base("Event tapilmadi.")
		{
		}

		public EventNotFoundException(string? message) : base(message)
		{
		}

        public EventNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }


        // throw new EventNotFoundException();
        // throw new EventNotFoundException("Salam");
        // throw new EventNotFoundException("dskfjasf", e);

    }
}

