﻿using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Portfolio.Clean.BlazorUI.Contracts;
using Portfolio.Clean.BlazorUI.Models.Projects;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Pages.Projects;

public partial class Project
{
    #region Attributes & Accessors
    private string DescriptionTxt { get; set; } = string.Empty;
    private string Technologies { get; set; } = string.Empty;
	public string ActualLanguage { get; set; } = string.Empty;
	[Inject]
    private ILanguageContainerService LanguageContainer { get; set; }
    [Inject]
    public IJSRuntime JS { get; set; }
    [Inject]
    public IProjectService ProjectService { get; set; }
    public List<ProjectVM> Projects { get; set; }


    #endregion

    #region Constructors

    #endregion

    #region Methods
    protected override async Task OnInitializedAsync()
    {
        ActualLanguage = await JS.InvokeAsync<string>("localStorage.getItem", "language");

        if (!String.IsNullOrEmpty(ActualLanguage))
        {
            LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(ActualLanguage));

        }

        Projects = await ProjectService.GetProjects();

        //DescriptionTxt = "Description du projet";
        Technologies = "Liste des technologies (.NET, angular, etc)";

        try
        {
            DescriptionTxt = Projects!
                .Where(p => p.Id == 2)!
                .FirstOrDefault()!.ProjectDescriptionFr!;
        }

        catch
        {
            DescriptionTxt = "***Description du projet***";
        }

        //Technologies = "Liste des technologies (.NET, angular, etc)";


        await base.OnInitializedAsync();
    }
    #endregion
}
