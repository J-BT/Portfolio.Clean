using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Portfolio.Clean.BlazorUI.Contracts.Helpers;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Helpers;

public class Language : ILanguage
{

    #region Attributes & Accessors

    private readonly ILanguageContainerService _languageContainer;
    private readonly IJSRuntime _js;
    private readonly NavigationManager _navigationmanager;
    private string _actualLanguage = string.Empty;

    #endregion

    #region Constructors
    public Language(ILanguageContainerService languageContainer, IJSRuntime js, NavigationManager navigationmanager)
    {
        _languageContainer = languageContainer;
        _js = js;
        _navigationmanager = navigationmanager;
    }
    #endregion

    #region Methods


    /// <summary>
    /// Retrieved all the resources saved in the .yml files located in Resources folder
    /// </summary>
    /// <returns></returns>
    public ILanguageContainerService GetResourceFile()
    {
        return _languageContainer;
    }


    /// <summary>
    /// Get the language stored in browser's local storage (ex : fr-Fr) and set the application Culture from it.
    /// </summary>
    public async Task<string> GetLanguageFromBrowserAsync()
    {
        _actualLanguage = await _js.InvokeAsync<string>("localStorage.getItem", "language");

        if (!String.IsNullOrEmpty(_actualLanguage))
        {
            _languageContainer.SetLanguage(CultureInfo.GetCultureInfo(_actualLanguage));

        }

        return _actualLanguage;
    }

    /// <summary>
    /// Change the language stored in browser's local storage
    /// </summary>
    /// <param name="cultureCode"></param>
    /// <returns></returns>
    public async Task SetLanguageToBrowserAsync(string cultureCode)
    {
        _languageContainer.SetLanguage(CultureInfo.GetCultureInfo(cultureCode));
        await _js.InvokeVoidAsync("localStorage.setItem", "language", cultureCode);
        string currentUri = _navigationmanager.Uri.Contains("#") ? _navigationmanager.BaseUri : _navigationmanager.Uri;
        _navigationmanager.NavigateTo(currentUri, true);
    }

    /// <summary>
    /// Returns cultures codes according to languages which are stored into the browser
    /// </summary>
    /// <returns>A dictionary of string. The key is the culture code (ex : fr-Fr), the value is the language</returns>
    public Dictionary<string, string> GetCultureCodes()
    {

        Dictionary<string, string> languages = new Dictionary<string, string>
        {
            { "fr-FR", "Français"},
            { "en-US", "English"},
            { "ja-JP", "日本語"}
        };

        if (!String.IsNullOrEmpty(_actualLanguage))
        {
            Dictionary<string, string> orderedLanguages = new();

            orderedLanguages.Add(_actualLanguage, languages[_actualLanguage]);
            foreach (var language in languages)
            {
                if (language.Key != _actualLanguage)
                {
                    orderedLanguages.Add(language.Key, language.Value);
                }
            }

            languages = orderedLanguages;
        }
        
        return languages;
    }


    #endregion

}
