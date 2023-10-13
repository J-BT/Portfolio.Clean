using AKSoftware.Localization.MultiLanguages;

namespace Portfolio.Clean.BlazorUI.Contracts.Helpers;

public interface ILanguage
{
    ILanguageContainerService GetResourceFile();
    Task<string> GetLanguageFromBrowserAsync();
    Task SetLanguageToBrowserAsync(string cultureCode, string thenToUrl = "/");
    Dictionary<string, string> GetCultureCodes();

}
