using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.PCLogs.Queries.GetPCLogDetails;

public class GetPCLogDetailsQueryHandler : IRequestHandler<GetPCLogDetailsQuery,
    PCLogDetailsDto>
{

    #region Attributes & Accessors

    private readonly IMapper _mapper;
    private readonly IPCLogRepository _pCLogRepository;

    #endregion

    #region Constructors
    public GetPCLogDetailsQueryHandler(IMapper mapper, IPCLogRepository pCLogRepository)
    {
        _mapper = mapper;
        _pCLogRepository = pCLogRepository;
    }

    #endregion

    #region Methods

    public async Task<PCLogDetailsDto> Handle(GetPCLogDetailsQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var log = await _pCLogRepository.GetAsyncById(request.Id);

        //Verify that record exists
        if (log == null)
            throw new NotFoundException(nameof(PCLog), request.Id);

        //Convert data object to DTO object
        var data = _mapper.Map<PCLogDetailsDto>(log);

        //Return DTO object
        return data;
    }

    #endregion
}
