using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.PCLogs.Queries.GetPCLogDetails;

public class PCLogDetailsDto
{
    #region Attributes & Accessors
    public int Id { get; set; }
    public string PCLogContent { get; set; } = string.Empty;
    public DateTime? CreationDate { get; set; }
    public DateTime? LastUpdate { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
