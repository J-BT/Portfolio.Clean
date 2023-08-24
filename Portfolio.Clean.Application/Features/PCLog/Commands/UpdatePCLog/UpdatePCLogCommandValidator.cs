using FluentValidation;
using Portfolio.Clean.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.PCLog.Commands.UpdatePCLog;

public class UpdatePCLogCommandValidator : AbstractValidator<UpdatePCLogCommand>
{

    #region Attributes & Accessors

    private readonly IPCLogRepository _pCLogRepository;

    #endregion

    #region Constructors
    public UpdatePCLogCommandValidator(IPCLogRepository pCLogRepository)
    {
        _pCLogRepository = pCLogRepository;

        RuleFor(q => q.Id)
            .NotNull()
            .MustAsync(PcLogMustExist);

        RuleFor(p => p.PCLogContent)
            .NotNull()
            .NotEmpty().WithMessage("{PropertyName} is required");
    }

    #endregion

    #region Methods
    private async Task<bool> PcLogMustExist(int id, CancellationToken token)
    {
        var pcLog = await _pCLogRepository.GetAsyncById(id);
        return pcLog != null;
    }
    #endregion
}
