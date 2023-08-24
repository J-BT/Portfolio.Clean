using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Commands.UpdateContactEmail;

public class UpdateContactEmailCommandHandler : IRequestHandler<UpdateContactEmailCommand, Unit>
{
    #region Attributes & Accessors

    private readonly IMapper _mapper;
    private readonly IContactEmailRepository _contactEmailRepository;

    #endregion

    #region Constructors
    public UpdateContactEmailCommandHandler(IMapper mapper, IContactEmailRepository contactEmailRepository)
    {
        _mapper = mapper;
        _contactEmailRepository = contactEmailRepository;
    }
    #endregion

    #region Methods
    public async Task<Unit> Handle(UpdateContactEmailCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data
        var validator = new UpdateContactEmailCommandValidator(_contactEmailRepository);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Any())
            throw new BadRequestException("Invalid ContactEmail", validationResult);

        //Convert to domain entity object
        var contactEmailToUpdate = _mapper.Map<Domain.ContactEmail>(request);

        //Update database
        await _contactEmailRepository.UpdateAsync(contactEmailToUpdate);

        //Return Unit Value (== void)
        return Unit.Value;
    }
    #endregion

}
