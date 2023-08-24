using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.PCLog.Commands.DeletePCLog;

public class DeletePCLogCommandHandler : IRequestHandler<DeletePCLogCommand, Unit>
{
    #region Attributes & Accessors

    private readonly IPCLogRepository _pCLogRepository;

    #endregion

    #region Constructors
    public DeletePCLogCommandHandler(IPCLogRepository pCLogRepository)
    {
        _pCLogRepository = pCLogRepository;
    }

    public async Task<Unit> Handle(DeletePCLogCommand request, CancellationToken cancellationToken)
    {
        //Retrieve domain entity object
        var pCLogToDelete = await _pCLogRepository.GetAsyncById(request.Id);

        //Verify that record exists
        if (pCLogToDelete == null)
            throw new NotFoundException(nameof(PCLog), request.Id);

        //Remove to database
        await _pCLogRepository.DeleteAsync(pCLogToDelete);

        //Return Unit Value (== void)
        return Unit.Value;
    }
    #endregion

    #region Methods

    #endregion
}
