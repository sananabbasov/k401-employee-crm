using System;
using EmployeeCrm.Application.DTOs.EventDTOs;
using FluentValidation;

namespace EmployeeCrm.Application.Validations.EventValidation
{
	public class RegisterEventValidation : AbstractValidator<EventCreateDTO>
	{
		public RegisterEventValidation()
		{
			RuleFor(x => x.Title).NotEmpty().MinimumLength(3).WithMessage("Yorduz meni.").MaximumLength(6).WithMessage("Ucden asagi yaz.");
		}
	}
}

