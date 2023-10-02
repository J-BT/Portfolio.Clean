using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Portfolio.Clean.BlazorUI.Components.Projects;

public partial class ProjectsNavigation
{

    #region Attributes & Accessors

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



    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
