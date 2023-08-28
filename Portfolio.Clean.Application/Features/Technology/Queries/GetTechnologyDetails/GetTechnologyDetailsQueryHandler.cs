using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using Portfolio.Clean.Application.Features.PCLog.Queries.GetPCLogDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Technology.Queries.GetTechnologyDetails;

public class GetTechnologyDetailsQueryHandler : IRequestHandler<GetTechnologyDetailsQuery, TechnologyDetailsDto>
{
    #region Attributes & Accessors
    private readonly ITechnologyRepository _technologyRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Constructors
    public GetTechnologyDetailsQueryHandler(ITechnologyRepository technologyRepository,
        IMapper mapper)
    {
        _technologyRepository = technologyRepository;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<TechnologyDetailsDto> Handle(GetTechnologyDetailsQuery request, CancellationToken cancellationToken)
    {
        //Query the database*
        var technology = await _technologyRepository.GetTechnologyWithDetails(request.TechnoName);

        //Verify that record exists
        if (technology == null)
            throw new NotFoundException(nameof(Technology), request.TechnoName);

        //Convert data object to DTO object
        var data = _mapper.Map<TechnologyDetailsDto>(technology);

        //Return DTO object
        return data;
    }
    #endregion

}
