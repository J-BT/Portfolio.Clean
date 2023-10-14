using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Portfolio.Clean.BlazorUI.Contracts.Helpers;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Pages.Solutions;

public partial class Solutions
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

        isLoaded = true;
        await base.OnInitializedAsync();
    }
    #endregion
}
