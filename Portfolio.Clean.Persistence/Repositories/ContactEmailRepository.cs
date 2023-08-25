using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Domain;
using Portfolio.Clean.Persistence.DatabaseContext;

namespace Portfolio.Clean.Persistence.Repositories;

public class ContactEmailRepository : GenericRepository<ContactEmail>, IContactEmailRepository
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public ContactEmailRepository(PortfolioDatabaseContext context)
        : base(context)
    {
    }
    #endregion

    #region Methods

    #endregion

}
