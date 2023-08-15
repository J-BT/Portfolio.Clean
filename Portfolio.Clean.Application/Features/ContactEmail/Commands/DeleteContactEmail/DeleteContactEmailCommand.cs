using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Commands.DeleteContactEmail;

public class DeleteContactEmailCommand : IRequest<Unit> // Unit == void
{

    #region Attributes & Accessors
    public int Id { get; set; }
    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
