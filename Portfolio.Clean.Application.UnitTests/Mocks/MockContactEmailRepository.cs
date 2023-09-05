using Moq;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.UnitTests.Mocks;

public class MockContactEmailRepository
{

    #region Attributes & Accessors

    #endregion

    #region Constructors

    #endregion

    #region Methods
    public static Mock<IContactEmailRepository> GetMockContactEmailRepository()
    {
        var contactEmails = new List<ContactEmail>
        {
            new ContactEmail
            {
                Id = 1,
                ContactEmailObject = "Test - Hello from Japan",
                ContactEmailContent = "John Tanaka",
                ContactEmailSender = "jintanaka@outlook.com"

            },
            new ContactEmail
            {
                Id = 2,
                ContactEmailObject = "Test - Hello from Poland",
                ContactEmailContent = "Josh Poliakov",
                ContactEmailSender = "joshpoliakov@outlook.com"

            },
            new ContactEmail
            {
                Id = 3,
                ContactEmailObject = "Test - Hello from France",
                ContactEmailContent = "Jean Croissant",
                ContactEmailSender = "jeancroissant@outlook.com"

            }
        };

        var mockRepo = new Mock<IContactEmailRepository>();

        mockRepo.Setup(r => r.GetAsync()).ReturnsAsync(contactEmails);

        mockRepo.Setup(r => r.CreateAsync(It.IsAny<ContactEmail>()))
            .Returns((ContactEmail contactEmail) =>
        {
            contactEmails.Add(contactEmail);
            return Task.CompletedTask;
        });

        return mockRepo;
    }
    #endregion
}
