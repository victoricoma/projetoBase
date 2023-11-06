# projetoBase
Projeto para inicializarmos o contexto de serviços em C# com .net core.
# Digrama de Roteiro do Projeto
![Mapa Programação Web 2](https://github.com/victoricoma/projetoBase/assets/31005408/49267d6a-c23f-4633-b044-3408303d61f8)

# Modelagem para atendimento de Web API 100 .net core:

- Definir no projeto as funcionalidades para poder consultar, criar, editar e excluir (CRUD) de produtos e categorias.
- Definir o modelo de domínio usando propriedades de Product e Category
- Utilizaremos o paradigma de Arquitetura Limpa ou abordagem (Clean Architecture)
- Iremos impementar MVC, Repository ORM e CQRS
- Definir atributos para domínios Product: [Id (Int, Identity), Name (String), Desription (String), Price (Decimal), Stock(Int), Image(String)], Category: [CategoryId (Int, Identity), Name (String)]
- Definir o relacionamento utilizado entre os domínios: teremos um relacionamento um - para - muitos entre Categoria e Produto.

# Ferramentas do Escopo Geral

- Usar um banco de dados relacional: SQL Server
- Usar uma ferramenta ORM: Entity Framework Core
- Usar a abordagem Code-First do Entity Framework Core para criar o banco e as tabelas.
- Provedor para aplicar o Migrations: Microsoft.EntityFrameworkCore.Tools
- Desacoplar a camada de acesso a dados do ORM: Padrão Repository

# Arquitetura de Repositorys
- As assinaturas de métodos.
- Recursos de acesso a camada de Infra dados.
- Interfaces de comunicação com modelo MER via ORM Entity Framework.
- Camada de testes automatizados usando xUnit.

# Arquitetura de Infra estrutura
- Configuração da infra estrutura de Entity Framework.
- Configuração das Classes em camada de dados.
- Infraestrutura de interfaces.
- Entidades de Infra estrutura no Sql, Design, Core.

# Modelagem de Inversão de Controle com Injeção de Dependência
- Determinação da classe de IServiceCollection.
- Vinculo com a mecânica de persistência do motor de Repository.
- Modelo de construtor da IoC.

[Imagem de Implementação Lógica]
![image](https://github.com/victoricoma/projetoBase/assets/31005408/c7e50b99-c921-4268-9bc0-481b5ef58c73)

