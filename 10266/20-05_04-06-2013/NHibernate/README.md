# Projeto de exemplo do NHibernate

# Pacotes NuGet
- install-package NUnit
- install-package NHibernate

# Passos

## Estrutura Base

- Criar solu��o
- Criar projetos Model, Core e Tests
- Instalar pacotes via NuGet
- Criar classe Produto na Model
- Mapear no Core - ProdutoMap
- Criar teste para cria��o do schema (SchemaTestCase)
- Criar services e repositories

## Web

- Criar projeto web (ASP.NET MVC 4)
- Inicializar NHibernate no Application_Start (ver global.asax.cs e NHIbernateBootstrap)
- Criar controller HomeController com as actions necess�rias
- Criar views necess�rias
- Utilizar http://twitter.github.io/bootstrap/
