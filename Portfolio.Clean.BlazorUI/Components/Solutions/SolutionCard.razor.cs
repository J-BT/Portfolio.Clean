using Microsoft.AspNetCore.Components;

namespace Portfolio.Clean.BlazorUI.Components.Solutions;

public partial class SolutionCard
{

    #region Attributes & Accessors
    [Parameter]
    public string Rank { get; set; } = string.Empty;
    [Parameter]
    public string Title { get; set; } = string.Empty;
    [Parameter]
    public string SubTitle0 { get; set; } = string.Empty;
    [Parameter]
    public string SubTitle1 { get; set; } = string.Empty;
    [Parameter]
    public string SubTitle2 { get; set; } = string.Empty;
    [Parameter]
    public string SubTitle3 { get; set; } = string.Empty;
    [Parameter] 
    public string SubTitle4 { get; set; } = string.Empty;
    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
