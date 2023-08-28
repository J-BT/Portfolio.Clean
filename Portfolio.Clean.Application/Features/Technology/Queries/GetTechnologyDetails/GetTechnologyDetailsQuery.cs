using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Technology.Queries.GetTechnologyDetails;

public class GetTechnologyDetailsQuery : IRequest<TechnologyDetailsDto>
{

    #region Attributes & Accessors
    public string TechnoName { get; set; } = string.Empty;

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
