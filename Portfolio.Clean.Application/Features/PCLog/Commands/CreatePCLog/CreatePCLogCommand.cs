using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.PCLog.Commands.CreatePCLog;

public class CreatePCLogCommand : IRequest<int>
{

    #region Attributes & Accessors
    public string PCLogContent { get; set; } = string.Empty;
    public DateTime? CreationDate { get; set; }
    public DateTime? LastUpdate { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
