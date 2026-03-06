# iSmirk - Backend API

Backend responsável por atender dois aplicativos de uma clínica odontológica.

-  Aplicativo do **Paciente**
-  Aplicativo da **Clínica**

Ambos utilizam **o mesmo backend e o mesmo banco de dados**, garantindo centralização das regras de negócio e consistência das informações.

---

# Sobre o Projeto

O objetivo deste projeto é criar uma plataforma digital que permita que clínicas odontológicas se comuniquem de forma mais eficiente com seus pacientes.

A aplicação permitirá que os pacientes acompanhem seus tratamentos, recebam comunicados da clínica e tenham acesso às informações sobre seus procedimentos odontológicos.

A clínica terá um aplicativo próprio para gerenciar pacientes, tratamentos e comunicações.

Toda a comunicação entre os aplicativos será realizada através de **uma única API centralizada**.

---

# Escopo Atual do Projeto

Este repositório contém o backend compartilhado entre dois aplicativos.

No momento, **esta documentação descreve apenas as funcionalidades relacionadas ao aplicativo do paciente**.

O módulo da clínica será implementado e documentado posteriormente.

---

# Módulo Documentado

Aplicativo do **Paciente**

Funcionalidades previstas:

- Cadastro de paciente  
- Login  
- Visualização de clínicas  
- Visualização de postagens da clínica  
- Visualização de tratamentos  
- Visualização da arcada dentária  
- Sistema de indicação de pacientes  
- Informações institucionais da clínica  
- Perfil do paciente  

---

# Arquitetura do Projeto

O backend foi desenvolvido utilizando **Domain Driven Design (DDD)**, organizando o projeto em camadas para manter o código limpo e escalável.

Estrutura base do projeto:


**Domain**

Responsável pelas entidades e regras de negócio.

**Application**

Responsável pelos casos de uso da aplicação.

**Infrastructure**

Responsável pela comunicação com banco de dados e implementações externas.

**API**

Responsável pelos controllers, middlewares e configuração da aplicação.

---

# Tecnologias Utilizadas

- C#
- .NET 8
- SQL Server
- Entity Framework
- JWT Authentication
- Swagger
- FluentMigrator
- XUnit
- Bogus
- Azure DevOps
- Injeção de Dependência (IoC)
- Domain Driven Design (DDD)

---

# Autenticação

A autenticação da API será realizada utilizando **JWT (JSON Web Token)**.

Após realizar o login, o usuário receberá um **token de acesso**, que deverá ser enviado nas requisições autenticadas.

---

# Aplicativo do Paciente

O aplicativo do paciente será projetado para permitir **acesso às informações de tratamento**, mantendo o controle das alterações sempre com a clínica.

Ou seja, o paciente poderá **visualizar informações**, mas não poderá alterar dados clínicos.

---

# Login e Cadastro

Ao abrir o aplicativo o paciente verá a tela de **login**.

Ele poderá acessar utilizando:

- Email
- Senha

Caso ainda não possua cadastro, poderá realizar o registro informando:

- Nome completo  
- CPF  
- Email  
- Telefone  
- Data de nascimento  
- Senha  
- Confirmação de senha  

Após o login o paciente será direcionado para a **Home Page**.

---

# Escolha da Clínica

Após o login, o paciente poderá visualizar todas as clínicas cadastradas.

Essas clínicas são cadastradas exclusivamente pelo **aplicativo da clínica**.

No aplicativo do paciente será apenas leitura:

---

Pacientes **não podem cadastrar, editar ou excluir clínicas**.

---

# Home Page da Clínica

Após escolher uma clínica, o paciente será direcionado para a página principal da clínica.

Nesta página serão exibidos:

- mensagem de boas-vindas com o nome do paciente  
- imagem com o nome do paciente  
- calendário com datas de tratamentos  
- área de postagens da clínica  

---

# Postagens da Clínica

A área de postagens terá duas abas:

- postagens para todos os pacientes  
- postagens exclusivas para o paciente  

No aplicativo do paciente será apenas leitura:

---

Pacientes **não poderão**:

- criar postagens
- editar postagens
- deletar postagens

Cada postagem exibirá:

- foto da clínica  
- nome da clínica  
- botão de compartilhamento  
- título da postagem  
- data da postagem  
- descrição da postagem  
- nome do dentista responsável  

Conteúdos permitidos:

- texto  
- imagem  
- link externo (ex: YouTube)

---

# Página de Tratamentos

Nesta página o paciente poderá visualizar todos os seus tratamentos.

Filtros disponíveis:

- tratamentos em andamento  
- tratamentos realizados  
- por mês  
- por semana  
- por dia  
- por ano  

Essa página será apenas leitura:

---


Somente a clínica poderá criar ou alterar tratamentos.

---

# Calendário de Tratamentos

O paciente poderá visualizar um calendário contendo:

- tratamentos futuros  
- tratamentos realizados  

---

# Visualização da Arcada Dentária

Será exibida uma representação da arcada dentária.

Cores utilizadas:

 Branco  
Dente sem tratamento.

 Azul  
Dente em tratamento.

Cada dente poderá informar quantos tratamentos estão sendo realizados naquele dente.

Ao clicar no dente será exibida uma descrição inserida pelo dentista explicando o tratamento.

---

# Sistema de Indicação

O aplicativo contará com um sistema de indicação de pacientes.

O paciente poderá compartilhar um **link de indicação**.

A clínica poderá oferecer **bônus personalizados** para cada indicação.

As regras dessas indicações serão definidas pela clínica.

---

# Página da Clínica

Nesta página o paciente poderá visualizar informações institucionais da clínica:

- descrição da clínica  
- endereço  
- link para Google Maps  
- galeria de fotos  

---

# Alterar Clínica

O paciente poderá trocar de clínica a qualquer momento.

A listagem será obtida através de:

---


O paciente apenas poderá **visualizar as clínicas**.

---

# Perfil do Paciente

Área destinada às informações do paciente.

Opções disponíveis:

- Meu Perfil  
- Alterar clínica  
- Segurança e privacidade  
- Sair da conta  

---

# Meu Perfil

Informações exibidas:

- Nome completo  
- Email  
- Telefone  
- CPF  
- Data de nascimento  

---

# Segurança e Privacidade

O paciente poderá:

- alterar senha  
- excluir conta  

---

# Testes

Os testes unitários serão desenvolvidos utilizando:

- **XUnit**
- **Bogus** para geração de dados de teste

Objetivo:

- validar regras de negócio  
- garantir estabilidade da API  

---

# Deploy

O deploy será realizado utilizando **Azure DevOps** com pipeline automatizado para:

- build da aplicação  
- execução de testes  
- deploy da API  

---

# Roadmap de Desenvolvimento

## Estrutura do Projeto

- [x] Criação do projeto .NET 8  
- [x] Estrutura inicial em DDD  
- [x] Configuração do SQL Server  

---

## Pacientes

- [x] Registro de pacientes  
- [ ] Login de pacientes  
- [ ] Atualização de dados  
- [ ] Exclusão de conta  

---

## Clínicas

- [x] Registro de clínicas  
- [ ] Listagem de clínicas  
- [ ] Detalhes da clínica  

---

## Postagens

- [ ] Criação de postagens  
- [ ] Listagem de postagens  
- [ ] Postagens exclusivas para pacientes  

---

## Tratamentos

- [ ] Cadastro de tratamentos  
- [ ] Listagem de tratamentos  
- [ ] Filtros de tratamentos  

---

## Banco de Dados

- [ ] Configuração do FluentMigrator  
- [ ] Versionamento do banco  

---

## Testes

- [ ] Configuração do XUnit  
- [ ] Configuração do Bogus  
- [ ] Implementação de testes unitários  

---

## Deploy

- [ ] Configuração do Azure DevOps  
- [ ] Pipeline de build  
- [ ] Pipeline de deploy  

---

# Autor

Projeto desenvolvido por **Geraldo Pereira**

Desenvolvedor Fullstack com foco em Backend utilizando:

- .NET  
- C#  
- SQL Server  
- Cloud  
