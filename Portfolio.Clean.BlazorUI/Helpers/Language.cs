using AKSoftware.Localization.MultiLanguages;
using Microsoft.JSInterop;
using Portfolio.Clean.BlazorUI.Contracts.Helpers;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Helpers;

public class Language : ILanguage
{

    #region Attributes & Accessors

    private readonly ILanguageContainerService _languageContainer;
    private readonly IJSRuntime _js;

    #endregion

    #region Constructors
    public Language(ILanguageContainerService languageContainer, IJSRuntime js)
    {
        _languageContainer = languageContainer;
        _js = js;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Get the language stored in browser's local storage. ex : fr-Fr
    /// </summary>
    /// <returns>A string relating to the language (en-Us, fr-Fr, etc).
    /// Returns an empty string if the browser local storage variable (language) is empty  </returns>
    public async Task<string> GetLanguageAsync()
    {
        string actualLanguage = string.Empty;
        actualLanguage = await _js.InvokeAsync<string>("localStorage.getItem", "language");

        return actualLanguage;
    }
    /// <summary>
    /// Set the language saved in the browser's local storage if not empty. Default set to 'fr-Fr'
    /// </summary>
    /// <param name="actualLanguage"></param>
    public void SetLanguage(string actualLanguage)
    {
        if (!String.IsNullOrEmpty(actualLanguage))
        {
            _languageContainer.SetLanguage(CultureInfo.GetCultureInfo(actualLanguage));

        }
    }
    /// <summary>
    /// Retrieved all the values (text) saved in the .yml files located in Resources/
    /// </summary>
    /// <returns></returns>
    public ILanguageContainerService GetLanguageContainer()
    {
        return _languageContainer;
    }


    #endregion

}
