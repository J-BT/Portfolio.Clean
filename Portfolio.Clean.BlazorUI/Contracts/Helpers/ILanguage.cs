using AKSoftware.Localization.MultiLanguages;

namespace Portfolio.Clean.BlazorUI.Contracts.Helpers;

public interface ILanguage
{
    Task<string> GetLanguageSavedInBrowserAsync();
    ILanguageContainerService GetResourceFile();
    Task SetLanguageSavedInBrowser();
}
