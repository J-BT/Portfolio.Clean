using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.PCLog.Queries.GetAllPCLogs;

public class GetPCLogsQueryHandler : IRequestHandler<GetPCLogsQuery,
    List<PCLogDto>>
{
    #region Attributes & Accessors

    private readonly IMapper _mapper;
    private readonly IPCLogRepository _pCLogRepository;

    #endregion

    #region Constructors
    public GetPCLogsQueryHandler(IMapper mapper, IPCLogRepository pCLogRepository)
    {
        _mapper = mapper;
        _pCLogRepository = pCLogRepository;
    }
    #endregion

    #region Methods
    public async Task<List<PCLogDto>> Handle(GetPCLogsQuery request, CancellationToken cancellationToken)
    {
        //Query the database
        var pCLogs = await _pCLogRepository.GetAsync();

        //Convert data objects to DTO objects
        var data = _mapper.Map<List<PCLogDto>>(pCLogs);

        //Return list of Dto objects
        return data;
    }
    #endregion
}
