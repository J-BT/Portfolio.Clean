using AKSoftware.Localization.MultiLanguages;

namespace Portfolio.Clean.BlazorUI.Contracts.Helpers;

public interface ILanguage
{
    Task<string> GetLanguageAsync();
    ILanguageContainerService GetLanguageContainer();
    void SetLanguage(string actualLanguage);
}
