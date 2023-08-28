using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Technology.Commands.UpdateTechnology;

public class UpdateTechnologyCommand : IRequest<Unit>
{

    #region Attributes & Accessors
    public int Id { get; set; }
    public string TechnoName { get; set; } = string.Empty;
    public byte[]? TechnoImg { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? LastUpdate { get; set; }
    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
