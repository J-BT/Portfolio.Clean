using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Portfolio.Clean.BlazorUI.Contracts.Helpers;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Pages.Home;

public partial class Home
{

	#region Attributes & Accessors

	bool isLoaded = false;
	public string ActualLanguage { get; set; } = string.Empty;

	private Dictionary<string, string> Languages { get; set; } = new();
    [Inject]
    public ILanguage Language { get; set; }
    [Inject]
	public IJSRuntime JS { get; set; }

	[Inject]
	private ILanguageContainerService LanguageContainer { get; set; }
	[Inject]
	private NavigationManager Navigationmanager { get; set; }

    private string displayLanguages = string.Empty;


    #endregion

    #region Constructors

    #endregion

    #region Methods

	protected override async Task OnInitializedAsync()
	{
		displayLanguages = "none";

        ActualLanguage = await JS.InvokeAsync<string>("localStorage.getItem", "language");
        Languages = Language.GetCultureCodes();
        if (!String.IsNullOrEmpty(ActualLanguage))
		{
			LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(ActualLanguage));

        }
		await Task.Delay(800);
		isLoaded = true;
		await base.OnInitializedAsync();
	}

	public async Task SetLanguage(string cultureCode)
	{

		LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(cultureCode));
		await JS.InvokeVoidAsync("localStorage.setItem", "language", cultureCode);
		Navigationmanager.NavigateTo("/", true);
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


