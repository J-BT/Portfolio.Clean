using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Portfolio.Clean.BlazorUI.Contracts;
using Portfolio.Clean.BlazorUI.Models.Projects;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Pages.Projects;

public partial class Project
{
    #region Attributes & Accessors

    bool isLoaded;
    public int NthProject { get; set; }
    public int TotalProjects { get; set; }
    private string DescriptionTxt { get; set; } = string.Empty;
    private string Technologies { get; set; } = string.Empty;
    private string Title { get; set; } = string.Empty;
    public string ActualLanguage { get; set; } = string.Empty;
    private bool DisplayNextButton { get; set; }
    private bool DisplayPreviousButton { get; set; }
    public List<string> TechnologiesIcons { get; set; } = new();
    public List<string> TechnologiesIconsAlt { get; set; } = new();
    [Inject]
    private ILanguageContainerService LanguageContainer { get; set; }
    [Inject]
    public IJSRuntime JS { get; set; }
    private IJSObjectReference? module { get; set; }

    [Inject]
    public IProjectService ProjectService { get; set; }
    public List<ProjectVM> Projects { get; set; }


    #endregion

    #region Constructors

    #endregion

    #region Methods
    protected override async Task OnInitializedAsync()
    {
        NthProject = 1;
        ActualLanguage = await JS.InvokeAsync<string>("localStorage.getItem", "language");

        if (!String.IsNullOrEmpty(ActualLanguage))
        {
            LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(ActualLanguage));

        }

        Projects = await ProjectService.GetProjects();

        
        WriteProjectInfos();
        SetNavigationElements();
        CheckDisplayableButtons();
        isLoaded = true;

        //await base.OnInitializedAsync();
    }

    private void SetTechnologiesImg()
    {
        string t = Technologies.Replace(" ", "");

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

    private bool ImageExists()
    {

        /*check if image exist here*/
        return true;
    }
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

    private async Task DeleteProjectImages()
    {
        module = await JS!.InvokeAsync<IJSObjectReference>("import", "./Components/Projects/ProjectTechnologies.razor.js");
        await module.InvokeVoidAsync("clearTechnologiesContainer");
    }

    private async Task ToPreviousProject()
    {
        await DeleteProjectImages();
        NthProject -= 1;
        CheckDisplayableButtons();
        WriteProjectInfos();
    }

    private async Task ToNextProject()
    {
        await DeleteProjectImages();
        NthProject += 1;
        CheckDisplayableButtons();
        WriteProjectInfos();
    }


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

    private void WriteProjectInfos()
    {
        try
        {
            var projects = Projects!
                .OrderBy(p => p.Id)!
                .Skip(NthProject - 1)
                .FirstOrDefault()!;

            switch (ActualLanguage)
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

    #endregion
}
