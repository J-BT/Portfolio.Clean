using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Project.Queries.GetProjectDetails;

public record GetProjectDetailsQuery(string ProjectName) : IRequest<ProjectDetailsDto>;
