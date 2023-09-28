using Portfolio.Clean.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Domain;

public class Project : BaseEntity
{
    #region Attributes & Accessors
    public string ProjectName { get; set; } = string.Empty;
    public string? ProjectTitleFr { get; set; } = string.Empty;
    public string? ProjectTitleEn { get; set; } = string.Empty;
    public string? ProjectTitleJp { get; set; } = string.Empty;
    public string ProjectTechnologies { get; set; } = string.Empty;
    public string? ProjectDescriptionFr { get; set; } = string.Empty;
    public string? ProjectDescriptionEn { get; set; } = string.Empty;
    public string? ProjectDescriptionJp { get; set; } = string.Empty;
    public string? ProjectUrl { get; set; }
    public string? ProjectVideo { get; set; }
    public string? ProjectGithub { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
