using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Queries.GetAllContactEmails;

public class GetContactEmailsQueryHandler : IRequestHandler<GetContactEmailsQuery,
    List<ContactEmailDto>>
{
    #region Attributes & Accessors

    private readonly IMapper _mapper;
    private readonly IContactEmailRepository _contactEmailRepository;

    #endregion

    #region Constructors
    public GetContactEmailsQueryHandler(IMapper mapper, IContactEmailRepository contactEmailRepository)
    {
        _mapper = mapper;
        _contactEmailRepository = contactEmailRepository;
    }
    #endregion

    #region Methods
    public async Task<List<ContactEmailDto>> Handle(GetContactEmailsQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var contactEmails = await _contactEmailRepository.GetAsync();

        //Convert data objects to DTO objects
        var data = _mapper.Map<List<ContactEmailDto>>(contactEmails);

        //Return list of Dto objects
        return data;
    }
    #endregion
}
