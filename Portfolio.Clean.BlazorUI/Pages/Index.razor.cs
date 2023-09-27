using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Pages;

public partial class Index
{

    #region Attributes & Accessors
    //private string TitleJob { get; set; } = string.Empty;
    public string LaptopTypingWords { get; set; } = string.Empty;

    [Inject]
    public IJSRuntime JS { get; set; }

    [Inject]
    private ILanguageContainerService LanguageContainer { get; set; }

    public string ActualLanguage { get; set; } = "NONE";


    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override async Task OnInitializedAsync()
    {
		ActualLanguage = await JS.InvokeAsync<string>("localStorage.getItem", "language");

        if (!String.IsNullOrEmpty(ActualLanguage))
        {
            LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(ActualLanguage));
        }



        //TitleJob = "Solutions Logicielles";
        //TitleJob = LanguageContainer.Keys["TitleJob"];
        //LaptopTypingWords = "[\"Applications web\", \"Logiciels\", \"Sites vitrines\"]";

        await base.OnInitializedAsync();
    }

    public async Task SetLanguage(string cultureCode)
    {
        
        LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(cultureCode));
        await JS.InvokeVoidAsync("localStorage.setItem", "language", cultureCode);
    }

    #endregion
}
