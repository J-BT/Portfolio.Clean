using FluentValidation;
using Portfolio.Clean.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Commands.UpdateContactEmail;

public class UpdateContactEmailCommandValidator : AbstractValidator<UpdateContactEmailCommand>
{

    #region Attributes & Accessors

    private readonly IContactEmailRepository _contactEmailRepository;

    #endregion

    #region Constructors
    public UpdateContactEmailCommandValidator(IContactEmailRepository contactEmailRepository)
    {
        _contactEmailRepository = contactEmailRepository;

        RuleFor(p => p.Id)
            .NotNull()
            .MustAsync(ContactEmailMustExist);

        RuleFor(p => p.ContactEmailObject)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(100).WithMessage("{PropertyName} must be fewer than 100 characters");

        RuleFor(p => p.ContactEmailContent)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();

        RuleFor(p => p.ContactEmailSender)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();
    }

    #endregion

    #region Methods
    private async Task<bool> ContactEmailMustExist(int id, CancellationToken token)
    {
        var contactEmail = await _contactEmailRepository.GetAsyncById(id);
        return contactEmail != null;
    }
    #endregion
}
