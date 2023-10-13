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
    [Inject]
    public ILanguage Language { get; set; }

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


