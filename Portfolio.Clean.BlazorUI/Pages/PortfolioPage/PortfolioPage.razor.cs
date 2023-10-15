using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Portfolio.Clean.BlazorUI.Contracts.Helpers;

namespace Portfolio.Clean.BlazorUI.Pages.PortfolioPage;

public partial class PortfolioPage
{

    #region Attributes & Accessors

    private bool isLoaded = false;
    [Inject]
    private ILanguage Language { get; set; }
    private ILanguageContainerService LanguageContainer { get; set; }
    #endregion

    #region Constructors

    #endregion

    #region Methods
    protected override async Task OnInitializedAsync()
    {
        //Language settings
        LanguageContainer = Language.GetResourceFile();
        await Language.GetLanguageFromBrowserAsync();

        await Task.Delay(800);
        isLoaded = true;
        await base.OnInitializedAsync();
    }
    #endregion
}
