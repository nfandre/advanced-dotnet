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


## Aplicando Orientação a Objetos em Projetos Reais com C# 11 e .NET 7


https://user-images.githubusercontent.com/965305/207913832-17d4e71e-4c0b-4239-b0b3-0095dd83938b.mp4

# Introdução

Olá e seja bem vindo ao curso Aplicando Orientação a Objetos em Projetos Reais com C# 11 e .NET 7. Eu sou André Baltieri ou balta, 10x Microsoft MVP e vou te guiar por este curso.

## O problema

Falamos muito sobre orientação a objetos e muitas vezes tornamos as coisas ainda mais obscuras e dificultamos o entendimento dos principais paradigmas. 

É necessário entender que orientação a objetos nem sempre precisa ser algo extremamente complexo e gigante, na verdade ela tem que ser simples e eficiente, como tudo na computação.

Mas como aplicar conceitos e técnicas que abrangem projetos de grande e pequeno porte em qualquer tipo de aplicação?

## O que vamos aprender

Neste curso, vamos aprender a resolver problemas de um cenário real apenas utilizando orientação a objetos e alguns conceitos que vão mudar sua visão sobre desenvolvimento de software.

Passaremos por todos os tópicos de organização da aplicação em soluções e projetos, seguido pela sub-organização a aplicação em pastas, para deixar tudo no lugar certo.

Vamos entender mais sobre a criação de SDKs que realmente são simples de usar e domínios pequenos e bem modelados, com entidades e objetos de valor.

Vamos passar por conceitos como herança, abstração, encapsulamento e até obsessão primitiva, tornando nosso código ainda mais reutilizável.

Claro que tudo isso aplicando o que há de mais novo no C# 11 e .NET 7, com recursos como Source Generators, Implicit Operators e Extension Methods.

Para fechar, vamos entender em quais cenários devemos utilizar Exceptions e como utilizá-las de uma forma testável e legível.

Toda esta implementação sem testes de unidade não nos favorece em nada, então temos um módulo dedicado a testes, onde vamos debater sobre o que e como testar todo nosso domínio.

Como resultado final, teremos uma biblioteca completa e testada, pronta para ser consumida por outros projetos na solução ou mesmo ser publicada em um Nuget público ou privado.

E não esquece de conferir nosso curso de Git, GitHub, Azure e DevOps para aprender a publicar essa biblioteca de forma automatizada com GitHub Actions e GitHub Packages.

## Para quem é este curso

Este curso é destinado a todas as pessoas que já tem conhecimento em .NET, ou que vem seguindo nossa carreira aqui e querem dar um passo a frente. 

Então se você já criou suas APIs ou Apps com .NET e quer aprender uma forma nova, eficiente e testável de escrever código, este curso é para você.

## Suporte e versões

Este curso tem foco em .NET 7 e C# 11, contando com recursos exclusivos desta versão (ou superior). 

Porém, conceitos como Implicit Operators, Extension Methods, Abstração, Herança, Encapsulamento e Primitive Obsession podem ser aplicados em diferentes versões do .NET e até mesmo outras linguagens de programação.

### Commands CLI
dotnet new sln 

dotnet new classlib -o UtmBuilder.Core

dotnet sln add UtmBuilder.Core 

dotnet new mstest -o  UtmBuilder.Core.Tests

dotnet sln add UtmBuilder.Core.Tests