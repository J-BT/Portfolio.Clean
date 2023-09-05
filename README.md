<div id="header" align="center">
<img src="https://github.com/devicons/devicon/blob/master/icons/dotnetcore/dotnetcore-original.svg" title=".NET" alt=".NET" width="80" height="80"/>&nbsp;
</div>

# Portfolio.Clean
### _Work in Progress_

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
**Core**
| Project | Description |
| --- | --- |
| `Portfolio.Clean.Domain` | -> Enterprise logic, like the entities and their specifications. |
| `Portfolio.Clean.Application` | -> Business logic such as features, etc. |
**Infrastructure**
| Project | Description |
| --- | --- |
| `Portfolio.Clean.Persistence` | -> Database migrations, database context, db repositories
| `Portfolio.Clean.Infrastructure` | -> Emails, logging and other third-party services |
**API**
| Project | Description |
| --- | --- |
| `Portfolio.Clean.Api` | -> The solution starts from the API. The others services are injected here |
**Tests**
| Project | Description |
| --- | --- |
| `Portfolio.Clean.Application.UnitTests` | Comming soon |
| `Portfolio.Clean.Application.IntegrationTests` | Comming soon |
**User Interface**
| Project | Description |
| --- | --- |
| `Portfolio.Clean.BlazorUI` | Comming soon |



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
