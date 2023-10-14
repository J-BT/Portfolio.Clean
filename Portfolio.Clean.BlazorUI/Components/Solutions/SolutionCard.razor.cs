using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Portfolio.Clean.BlazorUI.Helpers;

namespace Portfolio.Clean.BlazorUI.Components.Solutions;

public partial class SolutionCard
{

    #region Attributes & Accessors
    private bool isLoaded = false;
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
    protected override async Task OnInitializedAsync()
    {
        isLoaded = true;
        await base.OnInitializedAsync();
    }

    #endregion
}
