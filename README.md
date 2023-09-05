<div id="header" align="center">
<img src="https://github.com/devicons/devicon/blob/master/icons/dotnetcore/dotnetcore-original.svg" title=".NET" alt=".NET" width="80" height="80"/>&nbsp;
</div>

# Portfolio.Clean
### _(Work in Progress)_

> **NOTE**
> Currently learning the cleaning architecture design philosophy, I decided to renew my portfolio in order to put my new knowledge into pratice.
>
> As Confucius said _"Life is really simple, but we insist on making it complicated."_...And he was probably right.
> Indeed, creating a simple web application such as a portfolio using clean architecture mays seem more time consuming than useful, and I totally agree.
>
> However this design comes with many advantages, and praticing on small projects at first can be really helpful is you want to tackle bigger projects in the future !
>
> So feel free to use my code as you wish !!

<!-- 
```diff
+ # Libraries
``` -->
## __Projects__
| Project | Description |
| --- | --- |
**Core**
| `Portfolio.Clean.Domain` | Enterprise logic, like the entities and their specifications. |
| `Portfolio.Clean.Application` | Business logic such as features, etc. |
**Infrastructure**
| `Portfolio.Clean.Persistence` | Database migrations, database context, db repositories |
| `Portfolio.Clean.Infrastructure` | Emails, logging and other third-party services |
**API**
| `Portfolio.Clean.Api` | The solution starts from the API. The others services are injected here |
**Test**
| `Portfolio.Clean.Application.UnitTests` | Unit tests for the features |
| `Portfolio.Clean.Application.IntegrationTests` | Coming soon |
**User Interface**
| `Portfolio.Clean.BlazorUI` | User Interface to interact with the API|

## __Dependencies & Libraries__
| Project |  Dependencies | Libraries |
| --- | --- | --- |
| `Portfolio.Clean.Domain` |  |  |
| `Portfolio.Clean.Application` |  |  |
| `Portfolio.Clean.Persistence` |  |  |
| `Portfolio.Clean.Infrastructure` |  |  |
| `Portfolio.Clean.Api` |  |  |
| `Portfolio.Clean.Application.UnitTests` |  |  |
| `Portfolio.Clean.Application.IntegrationTests` |  |  |
| `Portfolio.Clean.BlazorUI` |  |  |

## __User secret__
```
{
  "ConnectionStrings": {
    "PortfolioDatabaseConnectionString": "Server=YourDbServerName;Database=YourDbName;Trusted_Connection=True;Integrated security=false; Encrypt=False; User ID=YourDbID; Password=YourDbPassword; MultipleActiveResultSets=true"
  },
  "EmailSettings": {
    "ApiKey": "SendGridAPIKey",
    "FromAddress": "AdressUsedToSendEmails",
    "FromName": "NameOfYourSolution",
    "To": "RecipientAdress"
  }
}
```
> NOTE
> In visual studio, the secrets.json file must be retrieved from the API project.
>
