# GPSSabores API

API RESTful desenvolvida em **C# e .NET**, com o objetivo de gerenciar produtos, pedidos e usuários de uma loja de alimentos.

> **Status do Projeto:** Em desenvolvimento  
> Atualmente estou iniciando a implementação dos **testes de unidade com xUnit** para o **registro de usuários**.  
> Este projeto faz parte do meu aprendizado prático em **C# e .NET**, aplicando conceitos de arquitetura **DDD (Domain-Driven Design)** para manter o código **escalável, organizado e de fácil manutenção**.  
> Novas funcionalidades serão adicionadas conforme o desenvolvimento avança.

---

## Objetivo do Projeto

O **GPSSabores** tem como objetivo colocar em prática conceitos avançados de desenvolvimento backend com **.NET**, como:

- Criação de APIs **RESTful**;
- Arquitetura baseada em **DDD (Domain-Driven Design)**;
- Separação em camadas:
  - **Controllers**
  - **Services**
  - **Repositories**
  - **Domain**
  - **Infrastructure**
- Conexão com banco de dados relacional via **Entity Framework Core**;
- Gerenciamento de migrations e versionamento do banco de dados utilizando **FluentMigrator**, permitindo:
  -  Redução da quantidade de pastas e arquivos de migrations versionados no GitHub;
  -  Evitar scripts manuais para criação/atualização do banco;
  -  Organização do versionamento em uma pasta dedicada `Versions`, facilitando o controle de versões;
- Autenticação e autorização com **JWT**;
- Documentação automática com **Swagger**.

---

## Progresso do Projeto

### Concluído

- [x] Estrutura base do projeto em camadas (**DDD**)
- [x] Configuração do **Entity Framework Core**
- [x] Implementação do **FluentMigrator** para versionamento do banco
- [x] Criação da **migration inicial** para tabela de usuários
- [x] Configuração do **Swagger**
- [x] Configuração e injeção de dependência (IoC)
- [x] Integração com o **SQL Server**
- [x] Refatoração do código e melhorias de arquitetura

### Em Andamento

- [ ] Implementação de **testes unitários** com **xUnit** (iniciando pelo registro de usuário)
- [ ] Adição de **tratamento global de exceções**
- [ ] Criação de **testes de integração**
- [ ] Ajustes de **logs e monitoramento**

### Próximas Etapas
- [ ] Integração do **JWT** para autenticação
- [ ] Integração com o **ChatGPT** para respostas inteligentes e automatizadas  
- [ ] Login via **Google**  
- [ ] Pipeline de **deploy automatizado** em ambiente cloud  

---

## Tecnologias Utilizadas

- **.NET 8**
- **C#**
- **Entity Framework Core**
- **FluentMigrator**
- **SQL Server**
- **JWT**
- **Swagger**
- **xUnit** *(para testes unitários)*

---

## ⚙️ Como Executar o Projeto

### 1️ Pré-requisitos
- [.NET 8 SDK](https://dotnet.microsoft.com/pt-br/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/pt-br/) ou [VS Code](https://code.visualstudio.com/)

### 2️ Executando o Projeto

```bash
# Clone o repositório
git clone https://github.com/Geraldopereirads/GPSSabores.git

# Acesse a pasta do projeto
cd GPSSabores

# Execute a aplicação
dotnet watch --project src/Backend/GPSSabores.API/GPSSabores.API.csproj run --launch-profile "https"
