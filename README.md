# Repositório Padrão ASP.NET

Este repositório fornece uma estrutura padrão para projetos ASP.NET, incluindo uma `BaseEntity`, `BaseController` e `Repository` para facilitar a criação de aplicações ASP.NET robustas e escaláveis. O projeto utiliza o Entity Framework Core com o provedor de banco de dados MySQL (Pomelo), além de Swagger para documentação de APIs. Inclui configuração centralizada para conexão com o banco de dados, logging e tratamento de erros usando Middlewares. Ideal para desenvolvedores que buscam um ponto de partida consistente para projetos ASP.NET com uma configuração já otimizada para produção.

## Estrutura do Projeto

- **BaseEntity**: Entidade base que fornece propriedades comuns para todas as entidades.
- **BaseController**: Controlador base que fornece funcionalidades comuns para todos os controladores.
- **Repository**: Implementação base de um repositório para operações CRUD.

## Pacotes Instalados

- **Pomelo.EntityFrameworkCore.MySql**: Provedor de banco de dados para MySQL, utilizado para integrar o Entity Framework Core com o MySQL.
- **Swashbuckle.AspNetCore**: Ferramenta para gerar documentação de APIs usando Swagger, facilitando o entendimento e o uso das APIs expostas pelo seu projeto.
- **Microsoft.EntityFrameworkCore.Design**: Fornece ferramentas para design e desenvolvimento com Entity Framework Core, incluindo comandos de migração.
- **Microsoft.EntityFrameworkCore**: Biblioteca principal para trabalhar com o Entity Framework Core, que fornece funcionalidades para acesso a dados e mapeamento objeto-relacional (ORM).

## Configuração

- **appsettings.json**: Contém a configuração de conexão com o banco de dados e outras configurações do aplicativo.
- **Logging**: Configurado para capturar e registrar informações sobre a execução do aplicativo.
- **Tratamento de Erros**: Implementado através de Middlewares para garantir que erros sejam tratados e logados adequadamente.
- **Program.cs**: Centraliza a configuração e inicialização do aplicativo.

## Instruções

1. Clone o repositório e instale os pacotes necessários com:

    ```bash
    dotnet restore
    ```

2. Configure a string de conexão no arquivo `appsettings.json`.

3. Execute as migrações do banco de dados com:

    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

4. Inicie o aplicativo com:

    ```bash
    dotnet run
    ```

---

Sinta-se à vontade para ajustar conforme necessário!



