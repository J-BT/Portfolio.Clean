using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Portfolio.Clean.BlazorUI.Contracts.Helpers;

namespace Portfolio.Clean.BlazorUI.Components.Common;

public partial class LanguageSelector
{

    #region Attributes & Accessors

    private string displayLanguages = string.Empty;
    private Dictionary<string, string> Languages { get; set; } = new();

    [Inject]
    public ILanguage Language { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override async Task OnInitializedAsync()
    {
        displayLanguages = "none";
        Languages = Language.GetCultureCodes();

        await base.OnInitializedAsync();
    }
    private void ShowLanguages()
    {
        if (displayLanguages == "none")
        {
            displayLanguages = "flex";
        }
        else
        {
            displayLanguages = "none";
        }
    }

    public async Task SetLanguage(string cultureCode)
    {
        await Language.SetLanguageToBrowserAsync(cultureCode);
    }
    #endregion
}
