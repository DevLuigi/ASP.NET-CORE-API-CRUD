# API com ASP.NET Core e Entity Framework

Este projeto é uma **API simples** desenvolvida com o **ASP.NET Core** e **Entity Framework** com o objetivo de aprender a criar APIs usando essas tecnologias. A API permite realizar operações básicas de **CRUD** (Create, Read, Update, Delete) em um recurso, como **Pokemon**.

## Objetivo

O principal objetivo deste projeto é aprender a:

- Criar uma API com **ASP.NET Core**.
- Utilizar o **Entity Framework Core** para interagir com o banco de dados.
- Implementar métodos **CRUD** (Create, Read, Update, Delete) em uma API RESTful.
- Utilizar **Swagger** para documentar e testar a API interativamente.

## Funcionalidades

A API expõe os seguintes endpoints para operações CRUD sobre o recurso **Pokemon**:

- **GET /api/pokemon**: Retorna a lista de todos os pokemons.
- **GET /api/pokemon/{id}**: Retorna um pokemon específico pelo ID.
- **POST /api/pokemon**: Cria um novo pokemon.
- **PUT /api/pokemon/{id}**: Atualiza um pokemon existente.
- **DELETE /api/pokemon/{id}**: Deleta um pokemon pelo ID.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework para construção de APIs.
- **Entity Framework Core**: ORM utilizado para interagir com o banco de dados.
- **MySQL**: Banco de dados utilizado para armazenar os dados.
- **Swagger**: Interface gráfica para testar e documentar a API.

## Pré-requisitos

- **.NET 6.0** ou superior instalado.
- **MySQL** instalado e configurado.
- **Visual Studio** ou qualquer editor de sua preferência (como **VS Code**) com suporte para **C#**.
