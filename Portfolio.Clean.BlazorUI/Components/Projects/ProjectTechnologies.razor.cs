using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Portfolio.Clean.BlazorUI.Components.Projects;

public partial class ProjectTechnologies
{

    #region Attributes & Accessors
    [Parameter]
    public List<string> TechnologiesIcons { get; set; } = new();
    [Parameter]
    public List<string> TechnologiesIconsAlt { get; set; } = new();


    #endregion
}
