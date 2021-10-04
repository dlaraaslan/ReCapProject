### RentACar


### General info

*The project consists of 5 layers: Entities, DataAccess, Business, Core, ConsoleUI and WebAPI.
Each operation is controlled by its own manager and the manager uses the Dal classes to implement crud operations. All data access layers implement generic IEntityRepository interface as a common outline.
Autofac IoC Container is used for Dependency Injection and Aspect Oriented Programming(Aspects: ValidationAspect, CacheAspect, CacheRemoveAspect, PerformanceAspect, SecuredOperationAspect, TransactionAsepct). Validation is a Cross Cutting Concern and as regard of AOP, Validation Aspect is created with Autofac using Interceptors. FluentValidation is the Validation Tool used for the verification process.*
