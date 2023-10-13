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
    private string _actualLanguage;

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
    /// Get the language stored in browser's local storage. ex : fr-Fr
    /// </summary>
    /// <returns>A string relating to the language (en-Us, fr-Fr, etc).
    /// Returns an empty string if the browser local storage variable (language) is empty  </returns>
    public async Task<string> GetLanguageSavedInBrowserAsync()
    {
        string actualLanguage = string.Empty;
        actualLanguage = await _js.InvokeAsync<string>("localStorage.getItem", "language");

        return actualLanguage;
    }
    /// <summary>
    /// Set the language saved in the browser's local storage if not empty. Default == 'fr-Fr'.
    /// </summary>
    /// <param name="actualLanguage"></param>
    public async Task SetLanguageSavedInBrowser()
    {
        _actualLanguage = await GetLanguageSavedInBrowserAsync();

        if (!String.IsNullOrEmpty(_actualLanguage))
        {
            _languageContainer.SetLanguage(CultureInfo.GetCultureInfo(_actualLanguage));

        }
    }
    /// <summary>
    /// Retrieved all the resources saved in the .yml files located in Resources folder
    /// </summary>
    /// <returns></returns>
    public ILanguageContainerService GetResourceFile()
    {
        return _languageContainer;
    }

    #endregion

}
