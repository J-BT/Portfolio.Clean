using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Email;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using Portfolio.Clean.Application.Models.Email;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Commands.CreateContactEmail;

public class CreateContactEmailCommandHandler : IRequestHandler<CreateContactEmailCommand, int>
{
    #region Attributes & Accessors

    private readonly IMapper _mapper;
    private readonly IContactEmailRepository _contactEmailRepository;
    private readonly IEmailSender _emailSender;

    #endregion

    #region Constructors
    public CreateContactEmailCommandHandler(IMapper mapper, IContactEmailRepository contactEmailRepository,
        IEmailSender emailSender)
    {
        _mapper = mapper;
        _contactEmailRepository = contactEmailRepository;
        _emailSender = emailSender;
    }
    #endregion

    #region Methods
    public async Task<int> Handle(CreateContactEmailCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data
        var validator = new CreateContactEmailCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Any())
            throw new BadRequestException("Invalid ContactEmail", validationResult);

        //Convert to domain entity object
        var contactEmailToCreate = _mapper.Map<Domain.ContactEmail>(request);

        //Send Email
        try
        {
            var email = new EmailMessage
            {
                To = string.Empty, /* Get email from user secret */
                Body = $"The following user '{request.ContactEmailSender}' sent the following message :" +
                $"\n{request.ContactEmailContent}",
                Subject = request.ContactEmailObject
            };

            await _emailSender.SendEmail(email);
        }
        catch (Exception)
        {
            //// Log or handle error,
        }


        //Add to database
        await _contactEmailRepository.CreateAsync(contactEmailToCreate);

        //Return record id
        return contactEmailToCreate.Id;
    }
    #endregion

}
