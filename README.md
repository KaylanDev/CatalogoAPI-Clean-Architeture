# :books: CatalogoAPI 
Neste repositorio esta um modelo de clean architecture API WEB, abaixo estara a explicação de cada projeto e suas funções.
* [Domain](#Domain)
* [Application](#Application)
* [Infrastruture](#Infrastruture)
* [CrossCutting](#CrossCutting)
* [API](#API)


# Domain
> Modelo das entidades e logica de negocios do projeto, armazena o Model principal e aplica interfaces responsaveis pela logica de acesso a dados.

# Application
> Regras de aplicação,serviços, mapeamentos e DTOs. aqui serao aplicados os Services das model, como exemplo GetCategorias com mapeamento.

# Infrastruture
> Logica de acesso a dados, responsavel pelo ORM utilizado para conexao com o banco de dados.

# CrossCutting
> IoC, registrodos serviços e recursos e DI, aqui sera onde ira aplicar, por exemplo onde adiciona o service do DbContext, tempo de vida do serviço e afins.

# API
> controladores, endpoints e filtros.

  
