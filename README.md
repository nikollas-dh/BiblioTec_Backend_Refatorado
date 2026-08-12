# 📚 Biblio Tec — API de Gestão de Biblioteca

API REST desenvolvida em **C# com ASP.NET Core** para gerenciamento de uma biblioteca. O projeto está sendo desenvolvido como uma **refatoração completa do Biblio Tec**, originalmente desenvolvido utilizando Node.js e Express.

A proposta da refatoração é reconstruir a aplicação utilizando o ecossistema **.NET**, buscando uma estrutura mais organizada, escalável e adequada para a evolução do sistema.

## 🚀 Sobre o projeto

O **Biblio Tec** é um sistema de gestão de biblioteca que permite centralizar operações relacionadas ao gerenciamento de usuários, livros e empréstimos.

Esta versão corresponde ao **backend da aplicação**, desenvolvido em C# utilizando ASP.NET Core e Entity Framework Core.

O projeto também representa uma oportunidade de aplicar conceitos de desenvolvimento de APIs REST, autenticação, persistência de dados, arquitetura de software e boas práticas do ecossistema .NET.

## 🛠️ Tecnologias utilizadas

* **C#**
* **ASP.NET Core**
* **Entity Framework Core**
* **SQL Server**
* **JWT (JSON Web Token)**
* **BCrypt**
* **LINQ**
* **REST API**
* **Git / GitHub**

## 🏗️ Arquitetura

O projeto utiliza uma estrutura baseada na separação de responsabilidades, organizando os principais componentes da aplicação em diferentes camadas.

```text
BiblioTecApi/
│
├── Controllers/
│   ├── AuthController.cs
│   └── ...
│
├── Models/
│   ├── Usuario.cs
│   ├── Livro.cs
│   └── ...
│
├── DTOs/
│   └── ...
│
├── Services/
│   ├── AuthService.cs
│   └── ...
│
├── Data/
│   └── AppDbContext.cs
│
├── Enums/
│   └── ...
│
├── Migrations/
│   └── ...
│
└── Program.cs
```

## 🔐 Autenticação

A API utiliza **JWT** para autenticação dos usuários.

Após realizar o login, a API fornece um token que pode ser utilizado para acessar endpoints que exigem autenticação.

O fluxo básico é:

```text
Usuário
   ↓
Login
   ↓
API
   ↓
Validação das credenciais
   ↓
JWT
   ↓
Acesso aos endpoints protegidos
```

As senhas dos usuários são armazenadas utilizando **hash**, evitando a persistência da senha em texto puro.

## 📖 Principais funcionalidades

Entre as funcionalidades planejadas/desenvolvidas para a API estão:

* 🔐 Autenticação de usuários
* 👤 Gerenciamento de usuários
* 📚 Gerenciamento de livros
* 🔎 Consulta de livros
* 📕 Gerenciamento de empréstimos
* 🔑 Controle de acesso através de autenticação
* 🗄️ Persistência de dados utilizando SQL Server
* 🔄 Migrations utilizando Entity Framework Core

> As funcionalidades podem ser expandidas conforme o desenvolvimento da aplicação.

## 🗄️ Banco de dados

O projeto utiliza **SQL Server** como banco de dados e **Entity Framework Core** como ORM.

As alterações na estrutura do banco são controladas através de **Migrations**.

Para criar uma nova migration:

```bash
dotnet ef migrations add NomeDaMigration
```

Para aplicar as migrations:

```bash
dotnet ef database update
```

## ⚙️ Como executar o projeto

### Pré-requisitos

Antes de executar a API, certifique-se de possuir:

* [.NET SDK](https://dotnet.microsoft.com/download)
* SQL Server
* Git

### 1. Clone o repositório

```bash
git clone https://github.com/nikollas-dh/BiblioTecApi.git
```

### 2. Acesse o diretório

```bash
cd BiblioTecApi
```

### 3. Configure a conexão com o banco

Configure a connection string do SQL Server no arquivo de configuração da aplicação.

Exemplo:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=BiblioTec;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

### 4. Execute as migrations

```bash
dotnet ef database update
```

### 5. Execute a API

```bash
dotnet run
```

A API estará disponível no endereço informado pelo ASP.NET Core durante a execução.

## 🧪 Testes da API

Os endpoints podem ser testados utilizando ferramentas como:

* Postman
* Insomnia
* Swagger

Durante o desenvolvimento, o Swagger pode ser utilizado para visualizar e testar os endpoints disponíveis.

## 🔄 Refatoração

O Biblio Tec originalmente foi desenvolvido utilizando:

```text
Node.js
   +
Express
   +
JavaScript
   +
HTML / CSS / JavaScript
   +
MariaDB
```

A nova versão está sendo reconstruída utilizando:

```text
C#
   +
ASP.NET Core
   +
Entity Framework Core
   +
SQL Server
```

A ideia não é apenas realizar uma simples troca de linguagem, mas **reconstruir o projeto aplicando os conhecimentos adquiridos durante o desenvolvimento da primeira versão**.

## 🎯 Objetivos do projeto

* Aprimorar conhecimentos em **C#**
* Desenvolver experiência com **ASP.NET Core**
* Praticar desenvolvimento de **APIs REST**
* Trabalhar com **Entity Framework Core**
* Aprender e aplicar **JWT**
* Melhorar a organização e arquitetura do projeto
* Praticar modelagem e gerenciamento de banco de dados
* Comparar diferentes abordagens de desenvolvimento backend

## 📌 Status

🚧 **Em desenvolvimento**

O projeto está passando por uma refatoração completa e novas funcionalidades e melhorias serão adicionadas ao longo do desenvolvimento.

## 👨‍💻 Desenvolvedor

Desenvolvido por **Nikollas Dheyvis**.

[GitHub](https://github.com/nikollas-dh)
