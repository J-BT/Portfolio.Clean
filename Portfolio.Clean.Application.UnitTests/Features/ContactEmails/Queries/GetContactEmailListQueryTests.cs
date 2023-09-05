using AutoMapper;
using Moq;
using Portfolio.Clean.Application.Contracts.Logging;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Features.ContactEmail.Queries.GetAllContactEmails;
using Portfolio.Clean.Application.MappingProfiles;
using Portfolio.Clean.Application.UnitTests.Mocks;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Portfolio.Clean.Application.UnitTests.Features.ContactEmails.Queries;

public class GetContactEmailListQueryTests
{

    #region Attributes & Accessors

    private readonly Mock<IContactEmailRepository> _mockRepo;
    private IMapper _mapper;
    private Mock<IAppLogger<GetContactEmailsQueryHandler>> _mockAppLogger;

    #endregion

    #region Constructors
    public GetContactEmailListQueryTests()
    {
        _mockRepo = MockContactEmailRepository.GetMockContactEmailRepository();

        var mapperConfig = new MapperConfiguration(c =>
        {
            c.AddProfile<ContactEmailProfile>();
        });

        _mapper = mapperConfig.CreateMapper();
        _mockAppLogger = new Mock<IAppLogger<GetContactEmailsQueryHandler>>();
    }
    #endregion

    #region Methods
    
    [Fact]
    public async Task GetContactEmailListTest()
    {
        var handler = new GetContactEmailsQueryHandler(_mapper, _mockRepo.Object, _mockAppLogger.Object);

        var result = await handler.Handle( new GetContactEmailsQuery(), CancellationToken.None);

        result.ShouldBeOfType<List<ContactEmailDto>>();
        result.Count.ShouldBe(3);
    }

    #endregion
}
