using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Project.Commands.DeleteProject;

public class DeleteProjectCommand : IRequest<Unit>
{

	#region Attributes & Accessors

	public string ProjectName { get; set; } = string.Empty;

	#endregion

	#region Constructors

	#endregion

	#region Methods

	#endregion
}
