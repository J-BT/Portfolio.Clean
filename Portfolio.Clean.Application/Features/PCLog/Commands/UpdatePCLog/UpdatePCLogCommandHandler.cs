using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.PCLog.Commands.UpdatePCLog;

public class UpdatePCLogCommandHandler : IRequestHandler<UpdatePCLogCommand, Unit>
{
    #region Attributes & Accessors

    private readonly IMapper _mapper;
    private readonly IPCLogRepository _pCLogRepository;

    #endregion

    #region Constructors
    public UpdatePCLogCommandHandler(IMapper mapper, IPCLogRepository pCLogRepository)
    {
        _mapper = mapper;
        _pCLogRepository = pCLogRepository;
    }

    #endregion

    #region Methods
    public async Task<Unit> Handle(UpdatePCLogCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data


        //Convert to domain entity object
        var pCLogToUpdate = _mapper.Map<Domain.PCLog>(request);

        //Update database
        await _pCLogRepository.UpdateAsync(pCLogToUpdate);

        //Return Unit Value (== void)
        return Unit.Value;
    }
    #endregion
}
