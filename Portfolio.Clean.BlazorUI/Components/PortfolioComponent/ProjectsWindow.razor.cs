using Microsoft.AspNetCore.Components;

namespace Portfolio.Clean.BlazorUI.Components.PortfolioComponent;

public partial class ProjectsWindow
{

    #region Attributes & Accessors
    [Parameter]
    public string Title { get; set; } = string.Empty;
    [Parameter]
    public string DescriptionTxt { get; set; } = string.Empty;
    [Parameter]
    public string ProjectWord { get; set; } = string.Empty;
    [Parameter]
    public int NthProject { get; set; }
    [Parameter]
    public int TotalProjects { get; set; }
    [Parameter]
    public string Previous { get; set; } = string.Empty;
    [Parameter]
    public string Next { get; set; } = string.Empty;
    [Parameter]
    public Func<Task> ToNextProject { get; set; }
    [Parameter]
    public Func<Task> ToPreviousProject { get; set; }
    [Parameter]
    public bool DisplayNextButton { get; set; }
    [Parameter]
    public bool DisplayPreviousButton { get; set; }
    [Parameter]
    public List<string> TechnologiesIcons { get; set; } = new();
    [Parameter]
    public List<string> TechnologiesIconsAlt { get; set; } = new();

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
