using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Email;
using Portfolio.Clean.Application.Contracts.Logging;
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
    private readonly IAppLogger<CreateContactEmailCommandHandler> _logger;

    #endregion

    #region Constructors
    public CreateContactEmailCommandHandler(IMapper mapper, IContactEmailRepository contactEmailRepository,
        IEmailSender emailSender, IAppLogger<CreateContactEmailCommandHandler> logger)
    {
        _mapper = mapper;
        _contactEmailRepository = contactEmailRepository;
        _emailSender = emailSender;
        _logger = logger;
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
                Body = $"The following user '{request.ContactEmailSender}' sent the following message :" +
                $"\n{request.ContactEmailContent}",
                Subject = request.ContactEmailObject
            };

            await _emailSender.SendEmail(email);
            _logger.LogInformation("The email was send succesfully");
        }
        catch (Exception)
        {
            //// Log or handle error,
            _logger.LogWarning("The email was not send");
        }


        //Add to database
        await _contactEmailRepository.CreateAsync(contactEmailToCreate);
        _logger.LogInformation("The email was added to the database");


        //Return record id
        return contactEmailToCreate.Id;
    }
    #endregion

}
