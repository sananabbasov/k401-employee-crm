using System;
namespace EmployeeCrm.Application.Responses
{
	public class Result
	{
		public bool Success { get; }
		public string Message { get; }
		public List<string> Errors { get; }


		public Result(bool success)
		{
			Success = success;
		}

		public Result(bool success, string message) :this(success)
		{
			Message = message;
		}

        public Result(bool success, List<string> errors) : this(success)
        {
            Errors = errors;
        }

    }
}

