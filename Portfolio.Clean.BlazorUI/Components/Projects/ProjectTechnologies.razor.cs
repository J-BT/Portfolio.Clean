using Microsoft.AspNetCore.Components;

namespace Portfolio.Clean.BlazorUI.Components.Projects;

public partial class ProjectTechnologies
{

    #region Attributes & Accessors
    [Parameter]
    public string Technologies { get; set; } = string.Empty;
    public List<string> TechnologiesIcons { get; set; } = new();
    public List<string> TechnologiesIconsAlt { get; set; } = new();
    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override async Task OnInitializedAsync()
    {
        SetTechnologiesImg();

        await base.OnInitializedAsync();
    }
    private void SetTechnologiesImg()
    {
        if (Technologies.Contains(","))
        {
            string t = Technologies.Replace(" ", "");
            TechnologiesIconsAlt = t.Split(",").ToList();

            foreach (var technology in TechnologiesIconsAlt)
            {
                
                if (ImageExists())
                {
                    TechnologiesIcons.Add(@$"/images/technologies/{technology}.svg");

                }
            }
        }
    }

    private bool ImageExists()
    {
        /****************************************************************/
        /************************** TO DO *******************************/

        /*check if image exist here*/
        return true;
    }

    #endregion
}
