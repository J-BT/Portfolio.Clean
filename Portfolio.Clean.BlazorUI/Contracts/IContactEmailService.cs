using Portfolio.Clean.BlazorUI.Models.ContactEmails;
using Portfolio.Clean.BlazorUI.Services.Base;

namespace Portfolio.Clean.BlazorUI.Contracts;

public interface IContactEmailService
{
    Task<List<ContactEmailVM>> GetContactEmails();
    Task<ContactEmailVM> GetContactEmailDetails(int id);

    Task<Response<Guid>> CreateContactEmail(ContactEmailVM contactEmail);
    Task<Response<Guid>> UpdateContactEmail(int id, ContactEmailVM contactEmail);
    Task<Response<Guid>> DeleteContactEmail(int id);
}
