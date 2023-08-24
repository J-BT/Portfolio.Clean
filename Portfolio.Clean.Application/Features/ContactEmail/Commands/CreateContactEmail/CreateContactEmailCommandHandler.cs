using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
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

    #endregion

    #region Constructors
    public CreateContactEmailCommandHandler(IMapper mapper, IContactEmailRepository contactEmailRepository)
    {
        _mapper = mapper;
        _contactEmailRepository = contactEmailRepository;
    }
    #endregion

    #region Methods
    public async Task<int> Handle(CreateContactEmailCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //Convert to domain entity object
        var contactEmailToCreate = _mapper.Map<Domain.ContactEmail>(request);

        //Add to database
        await _contactEmailRepository.CreateAsync(contactEmailToCreate);

        //Return record id
        return contactEmailToCreate.Id;
    }
    #endregion

}
