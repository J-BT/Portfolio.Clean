using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Portfolio.Clean.BlazorUI.Contracts.Helpers;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Pages.Home;

public partial class Home
{

	#region Attributes & Accessors

	private bool isLoaded = false;
    private string displayLanguages = string.Empty;
    private Dictionary<string, string> Languages { get; set; } = new();
    [Inject]
    public ILanguage Language { get; set; }

    private ILanguageContainerService LanguageContainer { get; set; }


    #endregion

    #region Constructors

    #endregion

    #region Methods

	protected override async Task OnInitializedAsync()
	{
		displayLanguages = "none";

        //Language setting
        LanguageContainer = Language.GetResourceFile();
        await Language.GetLanguageFromBrowserAsync();
        Languages = Language.GetCultureCodes();

        await Task.Delay(800);
		isLoaded = true;
		await base.OnInitializedAsync();
	}

	public async Task SetLanguage(string cultureCode)
	{
        await Language.SetLanguageToBrowserAsync(cultureCode);
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

    #endregion
}


