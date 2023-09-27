using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Pages;

public partial class Index
{

    #region Attributes & Accessors
    //private string TitleJob { get; set; } = string.Empty;
    public string LaptopTypingWords { get; set; } = string.Empty;

    [Inject]
    private ILanguageContainerService LanguageContainer { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override async Task OnInitializedAsync()
    {
        //TitleJob = "Solutions Logicielles";
        //TitleJob = LanguageContainer.Keys["TitleJob"];
        //LaptopTypingWords = "[\"Applications web\", \"Logiciels\", \"Sites vitrines\"]";

        await base.OnInitializedAsync();
    }

    public void SetLanguage(string cultureCode)
    {
        LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(cultureCode));
    }

    #endregion
}
