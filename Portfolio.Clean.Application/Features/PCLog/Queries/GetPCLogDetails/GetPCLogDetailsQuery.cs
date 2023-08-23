using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.PCLogs.Queries.GetPCLogDetails;

public record GetPCLogDetailsQuery(int Id) : IRequest<PCLogDetailsDto>;
