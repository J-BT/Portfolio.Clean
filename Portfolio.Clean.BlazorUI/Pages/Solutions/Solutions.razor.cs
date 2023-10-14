using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Portfolio.Clean.BlazorUI.Contracts.Helpers;
using Portfolio.Clean.BlazorUI.Models.ResourceFiles.Solutions;

namespace Portfolio.Clean.BlazorUI.Pages.Solutions;

public partial class Solutions
{

    #region Attributes & Accessors

    private bool isLoaded = false;
    [Inject]
    private ILanguage Language { get; set; }
    private ILanguageContainerService LanguageContainer { get; set; }
    private List<Solution> ResourceSolutions { get; set; } = new();

    #endregion


    #region Constructors

    #endregion

    #region Methods
    protected override async Task OnInitializedAsync()
    {
        //Language settings
        LanguageContainer = Language.GetResourceFile();
        await Language.GetLanguageFromBrowserAsync();

        GetSolutions(); // => ResourceSolutions

        isLoaded = true;
        await base.OnInitializedAsync();
    }

    /// <summary>
    /// Retrieves all solutions stored in resource files (ex : fr-FR) and store them in ResourceSolutions
    /// </summary>
    /// <returns></returns>
    private void GetSolutions()
    {
        foreach (int index in Enumerable.Range(1, 6))
        {
            Solution solution = new();
            solution.Title = LanguageContainer.Keys[$"Solutions:Cards:{index}:Title"];
            solution.Rank = LanguageContainer.Keys[$"Solutions:Cards:{index}:Rank"];
            solution.SubTitle1 = LanguageContainer.Keys[$"Solutions:Cards:{index}:SubTitle1"];
            solution.SubTitle2 = LanguageContainer.Keys[$"Solutions:Cards:{index}:SubTitle2"];
            solution.SubTitle3 = LanguageContainer.Keys[$"Solutions:Cards:{index}:SubTitle3"];
            solution.SubTitle4 = LanguageContainer.Keys[$"Solutions:Cards:{index}:SubTitle4"];

            ResourceSolutions.Add( solution );
        }

    }
    #endregion
}
