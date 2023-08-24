using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
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
        var validator = new UpdatePCLogCommandValidator(_pCLogRepository);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Any())
            throw new BadRequestException("Invalid PCLog", validationResult);

        //Convert to domain entity object
        var pCLogToUpdate = _mapper.Map<Domain.PCLog>(request);

        //Update database
        await _pCLogRepository.UpdateAsync(pCLogToUpdate);

        //Return Unit Value (== void)
        return Unit.Value;
    }
    #endregion
}
