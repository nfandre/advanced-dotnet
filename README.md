# advanced-dotnet

## Modelando Domínios

Introdução
- Linguagem Obíquoa
- Domínios Ricos vs Domínios Anêmicos
    - Domínios anêmicos -> apenas propriedades/ sem regra de negócio/ data driven design/ etc
    - Domínios Ricos -> Regras de negócio / objetos de valor / métodos etc
- Sub Domínios
    Segmentação dos Domínios / microserviço
- Separação em Contextos Delimitados
- Organizando a Solução
- Definindo as Entidades
- Corrupção no Código
- SOLID e Clean Code
- Primitive Obsession |
- Value Objects
- Compartilhando Informações entre Contextos Delimitadost
- Testando as Entidades e VOs
- Commands
- Fail Fast Validations
- Testando os Commands
- Repository Pattern |
- Handlers (Manipuladores)
- Testando os Handlers|
- Queries
- Testando suas Queries

### Commands CLI
dotnet new sln

dotnet new classlib  

dotnet new mstest

dotnet sln add PaymentContext.Domain/PaymentContext.Domain.csproj

dotnet sln add PaymentContext.Shared/PaymentContext.Shared.csproj

dotnet sln add PaymentContext.Tests/PaymentContext.Tests.csproj 

dotnet restore

dotnet build

dotnet add reference ../PaymentContext.Shared/PaymentContext.Shared.csproj

dotnet add reference ../PaymentContext.Domain/PaymentContext.Domain.csproj

dotnet add package flunt

## Retaforando testes de unidades

*   testes de unidade
*   Aprender CQRS
*   Aprender ou relembrar conceitos de OOP
*   Analisar código legado e identificar problemas
*   Aprender a refatorar e reescrever aplicações legadas
*   Modelar o domínio da aplicação
*   Criar e testar validações das entidades do domínio
*   Criar queries e implementar testes de unidade para queries
*   Criar commands e implementar testes de unidade para commands
*   Criar handlers e implementar testes de unidade para handlers
*   Criar utilitários para seu projeto
*   Implementar o Repository Pattern
*   Criar/mockar repositórios de testes
