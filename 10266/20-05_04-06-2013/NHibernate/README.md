# Projeto de exemplo do NHibernate

# Pacotes NuGet
install-package NUnit
install-package NHibernate

# Passos

## Estrutura Base

- Criar solução
- Criar projetos Model, Core e Tests
- Instalar pacotes via NuGet
- Criar classe Produto na Model
- Mapear no Core - ProdutoMap
- Criar teste para criação do schema (SchemaTestCase)
- Criar services e repositories

## Web

- Criar projeto web (ASP.NET MVC 4)
- Inicializar NHibernate no Application_Start (ver global.asax.cs e NHIbernateBootstrap)
- Criar controller HomeController com as actions necessárias
- Criar views necessárias
- Utilizar http://twitter.github.io/bootstrap/