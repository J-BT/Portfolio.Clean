using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Logging;
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
    private readonly IAppLogger<GetContactEmailsQueryHandler> _logger;

    #endregion

    #region Constructors
    public GetContactEmailsQueryHandler(IMapper mapper,
        IContactEmailRepository contactEmailRepository,
        IAppLogger<GetContactEmailsQueryHandler> logger)
    {
        _mapper = mapper;
        _contactEmailRepository = contactEmailRepository;
        _logger = logger;
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
        _logger.LogInformation("Contact Emails were retrieved succesfully");
        return data;
    }
    #endregion
}
