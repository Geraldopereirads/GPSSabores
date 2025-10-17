# 🍽️ GPSSabores API

API RESTful desenvolvida em **C# e .NET**, com o objetivo de gerenciar produtos, pedidos e usuários de uma loja de alimentos.

> **Status do Projeto:** Em desenvolvimento.  
> Atualmente estou implementando autenticação com **JWT** e integração com banco de dados utilizando **Entity Framework Core**.  
> Este projeto faz parte do meu aprendizado prático em **C# e .NET**, aplicando conceitos de arquitetura **DDD (Domain-Driven Design)** para manter o código escalável, organizado e de fácil manutenção.  
> Novas funcionalidades serão adicionadas conforme o desenvolvimento avança.

---

## Objetivo do Projeto

O **GPSSabores** tem como objetivo colocar em prática conceitos de desenvolvimento backend com **.NET**, como:

- Criação de APIs **RESTful**;
- Arquitetura baseada em **DDD (Domain-Driven Design)**;
- Separação em camadas: **Controllers**, **Services**, **Repositories**, **Domain** e **Infrastructure**;
- Conexão com banco de dados relacional via **Entity Framework Core**;
- Gerenciamento de migrations e versionamento do banco de dados utilizando **FluentMigrator**, permitindo:
  - Redução da quantidade de pastas e arquivos de migrations a serem versionados no GitHub;
  - Evitar a necessidade de gravar manualmente scripts de terminal para criar/atualizar o banco;
  - Organização do versionamento do banco de dados em uma pasta dedicada `Version`, facilitando o controle de versões;
- Autenticação e autorização com **JWT**;
- Documentação automática com **Swagger**.

---

## 💡 Funcionalidades Futuras

- Integração com o **ChatGPT**, permitindo respostas inteligentes e automatizadas;
- Login via **Google**;
- Testes unitários e de integração com **xUnit**;
- Deploy automatizado em ambiente cloud.

---

## 🚀 Como executar o projeto

### 1️⃣ Pré-requisitos
- [.NET 8 SDK](https://dotnet.microsoft.com/pt-br/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) (ou outro banco compatível)
- [Visual Studio](https://visualstudio.microsoft.com/pt-br/) ou [VS Code](https://code.visualstudio.com/)

### 2️⃣ Executando o projeto
```bash
# Clone o repositório
git clone https://github.com/Geraldopereirads/GPSSabores.git

# Acesse a pasta do projeto
cd GPSSabores

# Execute a aplicação
dotnet watch --project src/Backend/GPSSabores.API/GPSSabores.API.csproj run --launch-profile "https"
