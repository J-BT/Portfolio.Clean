using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Domain;

public class Project
{
    #region Attributes & Properties

    public string IdProject { get; set; } = string.Empty;
    //public string ProjectTitle { get; set; } = string.Empty; //XML
    //public string ProjectName { get; set; } = string.Empty; //XML
    //public string ProjectDescription { get; set; } = string.Empty; //XML
    public Technology ProjectTechnologies { get; set; } = new();
    public int TechnologyId { get; set; }
    public byte[]? ProjectScreenshots { get; set; }
    public string? ProjectUrl { get; set; }
    public string? ProjectVideo { get; set; }
    public string? ProjectGithub { get; set; }
    public DateTime ProjectCreationDate { get; set; }
    public DateTime ProjectLastUpdate { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
