using Microsoft.AspNetCore.Components;
using Portfolio.Clean.BlazorUI.Contracts;
using Portfolio.Clean.BlazorUI.Models.ContactEmails;

namespace Portfolio.Clean.BlazorUI.Pages.ContactEmails;

public partial class Index
{

    #region Attributes & Accessors
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Inject]
    public IContactEmailService ContactEmailService { get; set; }

    public List<ContactEmailVM> ContactEmails { get; private set; }
    public string Message { get; set; } = string.Empty;

    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override async Task OnInitializedAsync()
    {
        ContactEmails = await ContactEmailService.GetContactEmails();
    }
    public void CreateContactEmail()
    {
        NavigationManager.NavigateTo("/contactemails/create/");
    }

    protected void EditContactEmail(int id)
    {
        NavigationManager.NavigateTo($"/contactemails/edit/{id}");
    }

    protected void DetailsContactEmail(int id)
    {
        NavigationManager.NavigateTo($"/contactemails/details/{id}");
    }

    protected async Task DeleteContactEmail(int id)
    {
        var response = await ContactEmailService.DeleteContactEmail(id);
        if (response.Success)
        {
            StateHasChanged();
        }
        else
        {
            Message = response.Message;
        }
    }
    #endregion
}
