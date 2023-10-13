using AKSoftware.Localization.MultiLanguages;

namespace Portfolio.Clean.BlazorUI.Contracts.Helpers;

public interface ILanguage
{
    ILanguageContainerService GetResourceFile();
    Task<string> GetLanguageFromBrowserAsync();
    Task SetLanguageToBrowserAsync(string cultureCode);
    Dictionary<string, string> GetCultureCodes();

}
