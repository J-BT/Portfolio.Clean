using AutoMapper;
using Portfolio.Clean.BlazorUI.Contracts;
using Portfolio.Clean.BlazorUI.Models.ContactEmails;
using Portfolio.Clean.BlazorUI.Services.Base;

namespace Portfolio.Clean.BlazorUI.Services;

public class ContactEmailService : BaseHttpService, IContactEmailService
{

    #region Attributes & Accessors

    private readonly IMapper _mapper;

    #endregion

    #region Constructors
    public ContactEmailService(IClient client, IMapper mapper) 
        : base(client)
    {
        _mapper = mapper;
    }
    #endregion

    #region Methods

    public Task<Response<Guid>> CreateContactEmail(ContactEmailVM contactEmail)
    {
        throw new NotImplementedException();
    }

    public Task<Response<Guid>> DeleteContactEmail(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<ContactEmailVM> GetContactEmailDetails(int id)
    {
        var contactEmail = await _client.ContactEmailsGETAsync(id);
        return _mapper.Map<ContactEmailVM>(contactEmail);
    }

    public async Task<List<ContactEmailVM>> GetContactEmails()
    {
        var contactEmails = await _client.ContactEmailsAllAsync();
        return _mapper.Map<List<ContactEmailVM>>(contactEmails);
    }

    public Task<Response<Guid>> UpdateContactEmail(int id, ContactEmailVM contactEmail)
    {
        throw new NotImplementedException();
    }

    #endregion

}
