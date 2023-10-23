using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Portfolio.Clean.BlazorUI.Contracts;
using Portfolio.Clean.BlazorUI.Contracts.Helpers;
using Portfolio.Clean.BlazorUI.Models.Projects;
using System.Runtime.CompilerServices;

namespace Portfolio.Clean.BlazorUI.Pages.PortfolioPage;

public partial class PortfolioPage
{

    #region Attributes & Accessors

    private bool isLoaded = false;
    [Inject]
    private ILanguage Language { get; set; }
    private ILanguageContainerService LanguageContainer { get; set; }

    [Inject]
    public IJSRuntime JS { get; set; }
    private IJSObjectReference? module { get; set; }

    [Inject]
    public IProjectService ProjectService { get; set; }
    public List<ProjectVM> Projects { get; set; }
    public int NthProject { get; set; }
    public int TotalProjects { get; set; }
    private string DescriptionTxt { get; set; } = string.Empty;
    private string Technologies { get; set; } = string.Empty;
    private string Title { get; set; } = string.Empty;
    private bool DisplayNextButton { get; set; }
    private bool DisplayPreviousButton { get; set; }
    public List<string> TechnologiesIcons { get; set; } = new();
    public List<string> TechnologiesIconsAlt { get; set; } = new();

    #endregion

    #region Constructors

    #endregion

    #region Methods
    protected override async Task OnInitializedAsync()
    {
        //Language settings
        LanguageContainer = Language.GetResourceFile();
        await Language.GetLanguageFromBrowserAsync();

        //Projects Window
        NthProject = 1;
        Projects = await ProjectService.GetProjects();
        await GetProjectInfos();
        SetNavigationElements();
        CheckDisplayableButtons();

        await Task.Delay(800);
        isLoaded = true;
        await base.OnInitializedAsync();
    }


    /// <summary>
    /// Navigates to the previous project requesting the database
    /// </summary>
    /// <returns></returns>
    private async Task ToPreviousProject()
    {
        await DeleteProjectImages();
        NthProject -= 1;
        CheckDisplayableButtons();
        await GetProjectInfos();
    }

    /// <summary>
    /// Navigates to the next project requesting the database
    /// </summary>
    /// <returns></returns>
    private async Task ToNextProject()
    {
        await DeleteProjectImages();
        NthProject += 1;
        CheckDisplayableButtons();
        await GetProjectInfos();
    }



    /// <summary>
    /// Call the database in order to retrieve the selected project informations.
    /// </summary>
    /// <returns></returns>
    private async Task GetProjectInfos()
    {
        try
        {
            var projects = Projects!
                .OrderBy(p => p.Id)!
                .Skip(NthProject - 1)
                .FirstOrDefault()!;

            string actualLanguage = await Language.GetLanguageFromBrowserAsync();

            switch (actualLanguage)
            {
                case "fr-FR":
                    Title = projects!.ProjectTitleFr!;
                    DescriptionTxt = projects!.ProjectDescriptionFr!;
                    break;
                case "en-US":
                    Title = projects!.ProjectTitleEn!;
                    DescriptionTxt = projects!.ProjectDescriptionEn!;
                    break;
                case "ja-JP":
                    Title = projects!.ProjectTitleJp!;
                    DescriptionTxt = projects!.ProjectDescriptionJp!;
                    break;
                default:
                    Title = projects!.ProjectTitleFr!;
                    DescriptionTxt = projects!.ProjectDescriptionFr!;
                    break;

            }


            Technologies = projects!.ProjectTechnologies!;
            SetTechnologiesImg();

        }

        catch
        {
            DescriptionTxt = "***Description du projet***";
            Technologies = "***Liste des technologies (.NET, angular, etc)***";
        }
    }



    /// <summary>
    /// Replace the project's technology name by its image
    /// </summary>
    private void SetTechnologiesImg()
    {
        string t = Technologies.Replace(" ", "").ToLower();

        if (Technologies.Contains(",")) //If several technologies
        {

            TechnologiesIconsAlt = t.Split(",").ToList();

            foreach (var technology in TechnologiesIconsAlt)
            {

                if (ImageExists())
                {
                    TechnologiesIcons.Add(@$"/images/technologies/{technology}.svg");

                }
            }
        }

        else
        {
            TechnologiesIconsAlt.Add(t);
            TechnologiesIcons.Add(@$"/images/technologies/{Technologies}.svg");
        }

    }

    /* ToDo : check if image exist here*/
    private bool ImageExists()
    {
        return true;
    }

    /// <summary>
    /// Delete the previous image from the technologies-container using JS Interop
    /// </summary>
    /// <returns></returns>
    private async Task DeleteProjectImages()
    {
        module = await JS!.InvokeAsync<IJSObjectReference>("import", "./Components/PortfolioComponent/ProjectsWindow.razor.js");
        await module.InvokeVoidAsync("clearTechnologiesContainer");
    }



    /// <summary>
    /// Displays project navigation arrows according to the rank of the project.
    /// E.g. if the rank is 1, then the left arrow is not displayed
    /// </summary>
    private void CheckDisplayableButtons()
    {
        if (NthProject > 1)
        {
            DisplayPreviousButton = true;
        }
        else
        {
            DisplayPreviousButton = false;

        }

        if (NthProject < TotalProjects)
        {
            DisplayNextButton = true;
        }
        else
        {
            DisplayNextButton = false;

        }
    }


    /// <summary>
    /// Retrieves the number of projects stored into the database
    /// </summary>
    private void SetNavigationElements()
    {
        try
        {
            TotalProjects = Projects!.Count();

        }

        catch
        {
            TotalProjects = 0;
        }
    }



    #endregion
}
