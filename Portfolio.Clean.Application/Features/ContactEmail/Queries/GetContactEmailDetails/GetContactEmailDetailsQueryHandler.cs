using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Queries.GetContactEmailDetails;

public class GetContactEmailDetailsQueryHandler : IRequestHandler<GetContactEmailDetailsQuery,
    ContactEmailDetailsDto>
{
    private readonly IMapper _mapper;
    private readonly IContactEmailRepository _contactEmailRepository;

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public GetContactEmailDetailsQueryHandler(IMapper mapper, IContactEmailRepository contactEmailRepository)
    {
        _mapper = mapper;
        _contactEmailRepository = contactEmailRepository;
    }

    public async Task<ContactEmailDetailsDto> Handle(GetContactEmailDetailsQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var contactEmail = await _contactEmailRepository.GetAsyncById(request.Id);

        //Verify that record exists
        if (contactEmail == null)
            throw new NotFoundException(nameof(ContactEmail), request.Id);

        //Convert data object to DTO object
        var data = _mapper.Map<ContactEmailDetailsDto>(contactEmail);

        //Return DTO object
        return data;
    }
    #endregion

    #region Methods

    #endregion
}
