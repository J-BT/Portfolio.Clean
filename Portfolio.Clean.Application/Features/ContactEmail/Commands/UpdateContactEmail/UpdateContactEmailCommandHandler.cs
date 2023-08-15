using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Commands.UpdateContactEmail;

public class DeleteContactEmailCommandHandler : IRequestHandler<DeleteContactEmailCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IContactEmailRepository _contactEmailRepository;

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public DeleteContactEmailCommandHandler(IMapper mapper, IContactEmailRepository contactEmailRepository)
    {
        _mapper = mapper;
        _contactEmailRepository = contactEmailRepository;
    }
    #endregion

    #region Methods
    public async Task<Unit> Handle(DeleteContactEmailCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data


        //Convert to domain entity object
        var contactEmailToUpdate = _mapper.Map<Domain.ContactEmail>(request);

        //Update database
        await _contactEmailRepository.UpdateAsync(contactEmailToUpdate);

        //Return Unit Value (== void)
        return Unit.Value;
    }
    #endregion

}
