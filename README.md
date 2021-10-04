# RentACar


### General info

*The project consists of 5 layers: Entities, DataAccess, Business, Core, ConsoleUI and WebAPI.
Each operation is controlled by its own manager and the manager uses the Dal classes to implement crud operations. All data access layers implement generic IEntityRepository interface as a common outline.
Autofac IoC Container is used for Dependency Injection and Aspect Oriented Programming(Aspects: ValidationAspect, CacheAspect, CacheRemoveAspect, PerformanceAspect, SecuredOperationAspect, TransactionAsepct). Validation is a Cross Cutting Concern and as regard of AOP, Validation Aspect is created with Autofac using Interceptors. FluentValidation is the Validation Tool used for the verification process.*

### Packageces

Asp.Net Core 3.1 <br/>
.Net Framework 4.5 <br/>
Microsoft.EntityFrameworkCore.SqlServer 3.1.0 <br/>
Microsoft.EntityFrameworkCore 3.1.0 <br/>
FluentValidation 9.5.1 <br/>
Autofac 6.1.0 <br/>
Autofac.Extras.DynamicProxy 6.0.0 <br/>
Autofac.Extensions.DependencyInjection 7.1.0 <br/>
Microsoft.Extensions.DependencyInjection 5.0.1 <br/>
Microsoft.AspNetCore.Hosting.Abstractions 2.2.0 <br/>
Microsoft.AspNetCore.Http 2.2.2 <br/>
Microsoft.AspNetCore.Http.Features 5.0.3 <br/>
Microsoft.IdentityModel.Tokens 6.8.0 <br/>
System.IdentityModel.tokens.Jwt 6.8.0 <br/>
Microsoft.AspNetCore.Authentication.JwtBearer 3.1.12 <br/>
Microsoft.AspNetCore.Mvc.NewtonsoftJson 3.1.10 <br/>
Microsoft.AspNetCore.Http.Abstractions 2.2.0 <br/>
