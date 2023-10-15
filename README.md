# projetoBase
Projeto para inicializarmos o contexto de serviços em C# com .net core.
# Digrama de Roteiro do Projeto
![Mapa Programação Web 2](https://github.com/victoricoma/projetoBase/assets/31005408/49267d6a-c23f-4633-b044-3408303d61f8)

# Modelagem para atendimento de Web API 100 .net core:

Definir no projeto as funcionalidades para poder consultar, criar, editar e excluir (CRUD) de produtos e categorias.
Definir o modelo de domínio usando propriedades de Product e Category
Utilizaremos o paradigma de Arquitetura Limpa ou abordagem (Clean Architecture)
Iremos impementar MVC, Repository ORM e CQRS
Definir atributos para domínios Product: [Id (Int, Identity), Name (String), Desription (String), Price (Decimal), Stock(Int), Image(String)], Category: [CategoryId (Int, Identity), Name (String)]
Definir o relacionamento utilizado entre os domínios: teremos um relacionamento um - para - muitos entre Categoria e Produto.
