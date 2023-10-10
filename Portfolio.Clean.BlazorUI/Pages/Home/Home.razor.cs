using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Pages.Home;

public partial class Home
{

	#region Attributes & Accessors

	bool isLoaded = false;

	public string ActualLanguage { get; set; } = string.Empty;
	private Dictionary<string, string> Languages { get; set; } = new()
	{
		{ "fr-FR", "Français"},
		{ "en-US", "English"},
		{ "ja-JP", "日本語"}
	};

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

    private Dictionary<string, string> OrderByLocalStorage(Dictionary<string, string> languages)
	{

		Dictionary<string, string> orderedLanguages = new();

		orderedLanguages.Add(ActualLanguage, languages[ActualLanguage]);
		foreach (var language in languages)
		{
			if (language.Key != ActualLanguage)
			{
				orderedLanguages.Add(language.Key, language.Value);
			}
		}

		return orderedLanguages;

	}

	protected override async Task OnInitializedAsync()
	{
		displayLanguages = "none";

        ActualLanguage = await JS.InvokeAsync<string>("localStorage.getItem", "language");

		if (!String.IsNullOrEmpty(ActualLanguage))
		{
			LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(ActualLanguage));
			Languages = OrderByLocalStorage(Languages);

		}
		await Task.Delay(500);
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
