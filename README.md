# Meu App ASP.NET

Este é um projeto de aplicação web desenvolvido utilizando o ASP.NET 8.0. A aplicação conecta-se a um banco de dados MySQL e utiliza o Entity Framework Core para gerenciar as operações de banco de dados.

## Estrutura do Projeto

O projeto possui a seguinte estrutura de diretórios:

```
meu-app-aspnet
├── Controllers
│   └── HomeController.cs       # Controlador para gerenciar requisições da página inicial
├── Data
│   └── AppDbContext.cs         # Contexto do banco de dados
├── Models
│   └── ExampleModel.cs         # Modelo de exemplo representando uma entidade
├── Program.cs                  # Ponto de entrada da aplicação
├── appsettings.json            # Configurações da aplicação, incluindo a ConnectionString
├── meu-app-aspnet.csproj       # Projeto do .NET com referências e dependências
└── README.md                   # Documentação do projeto
```

## Configuração do Ambiente

### Pré-requisitos

- .NET 8.0 SDK
- MySQL Server
- MySQL Workbench

### Instalação de Pacotes

Para instalar os pacotes necessários, execute os seguintes comandos no terminal:

```
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.3
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
```

### Configuração do Banco de Dados

1. No arquivo `appsettings.json`, configure a `ConnectionString` para o seu banco de dados MySQL:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=SeuBancoDeDados;user=SeuUsuario;password=SuaSenha;"
  }
}
```

2. Execute o comando para criar o banco de dados:

```
dotnet ef database update
```

## Execução da Aplicação

Para executar a aplicação, utilize o seguinte comando:

```
dotnet run
```

A aplicação estará disponível em `http://localhost:50XX` (ou outra porta configurada).

## Contribuições

Sinta-se à vontade para contribuir com melhorias ou correções.