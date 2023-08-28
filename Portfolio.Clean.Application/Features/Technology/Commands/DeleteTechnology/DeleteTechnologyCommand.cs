using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Technology.Commands.DeleteTechnology;

public class DeleteTechnologyCommand : IRequest<Unit>
{

    #region Attributes & Accessors
    public int Id { get; set; }
    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
