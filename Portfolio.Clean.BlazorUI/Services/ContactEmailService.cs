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

    public async Task<Response<Guid>> CreateContactEmail(ContactEmailVM contactEmail)
    {
        try
        {
            var createEmailContactCommand = _mapper.Map<CreateContactEmailCommand>(contactEmail);
            await _client.ContactEmailsPOSTAsync(createEmailContactCommand);
            return new Response<Guid>()
            {
                Success = true
            };
        }

        catch (ApiException ex)
        {
            return ConvertApiException<Guid>(ex);
        }
    }

    public async Task<Response<Guid>> DeleteContactEmail(int id)
    {
        try
        {
            await _client.ContactEmailsDELETEAsync(id);
            return new Response<Guid>()
            {
                Success = true
            };
        }
        catch (ApiException ex)
        {
            return ConvertApiException<Guid>(ex);
        }
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

    public async Task<Response<Guid>> UpdateContactEmail(int id, ContactEmailVM contactEmail)
    {
        try
        {
            var updateEmailContactCommand = _mapper.Map<UpdateContactEmailCommand>(contactEmail);
            await _client.ContactEmailsPUTAsync(id.ToString(), updateEmailContactCommand);
            return new Response<Guid>()
            {
                Success = true
            };
        }
        catch (ApiException ex)
        {
            return ConvertApiException<Guid>(ex);
        }
    }

    #endregion

}
