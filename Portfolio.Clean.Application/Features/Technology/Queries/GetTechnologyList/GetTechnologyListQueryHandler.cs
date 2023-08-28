using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Technology.Queries.GetTechnologyList;

public class GetTechnologyListQueryHandler : IRequestHandler<GetTechnologyListQuery, List<TechnologyListDto>>
{
    #region Attributes & Accessors
    private readonly ITechnologyRepository _technologyRepository;
    private readonly IMapper _mapper;
    #endregion

    #region Constructors
    public GetTechnologyListQueryHandler(ITechnologyRepository technologyRepository,
        IMapper mapper)
    {
        _technologyRepository = technologyRepository;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<List<TechnologyListDto>> Handle(GetTechnologyListQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var technologies = await _technologyRepository
            .GetAsync();

        //Convert data to DTO objects
        var data = _mapper.Map<List<TechnologyListDto>>(technologies);

        //Return list of Dto objects
        return data;

    }

    #endregion

}
