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
    //public string ProjectTitle { get; set; } = string.Empty; //XML
    //public string ProjectDescription { get; set; } = string.Empty; //XML
    public Technology? ProjectTechnologies { get; set; } = new();
    public string ProjectTechnologiesList { get; set; } = string.Empty;
    public byte[]? ProjectScreenshots { get; set; }
    public string? ProjectUrl { get; set; }
    public string? ProjectVideo { get; set; }
    public string? ProjectGithub { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
