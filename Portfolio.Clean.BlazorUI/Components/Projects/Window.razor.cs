using Microsoft.AspNetCore.Components;

namespace Portfolio.Clean.BlazorUI.Components.Projects;

public partial class Window
{

    #region Attributes & Accessors
    [Parameter]
    public string DescriptionTxt_ { get; set; } = string.Empty;
    [Parameter]
    public string Technologies_ { get; set; } = string.Empty;
    [Parameter]
    public string Title_ { get; set; } = string.Empty;
    [Parameter]
    public string ProjectWord_ { get; set; } = string.Empty;
    [Parameter]
    public int NthProject_ { get; set; }
    [Parameter]
    public int TotalProjects_ { get; set; }
    [Parameter]
    public string Previous_ { get; set; } = string.Empty;
    [Parameter]
    public string Next_ { get; set; } = string.Empty;
    [Parameter]
    public Func<Task> ToNextProject_ { get; set; }
    [Parameter]
    public Func<Task> ToPreviousProject_ { get; set; }
    [Parameter]
    public bool DisplayNextButton_ { get; set; }
    [Parameter]
    public bool DisplayPreviousButton_ { get; set; }
    [Parameter]
    public List<string> TechnologiesIcons_ { get; set; } = new();
    [Parameter]
    public List<string> TechnologiesIconsAlt_ { get; set; } = new();
    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
