# CrudLivros

Ferramentas:

 * .Net Core 3.1
 * Angular 11
 * PostgreSQL 12
 * Swagger
 * Entity Framework Core
 
Requisitos:

 * SDK .Net Core 3.1
 * Angular 11
 * PostgreSQL 12
 * Visual Studio 2019
 
Executar:

 * Ajustar sua configuração de banco em appsettings.json > DbConnection
 * Abrir projeto no Visual Studio
 * No diretório project rodar update-database
 * No diretório project Build
 * No diretório Front-end rodar ng serve --open

Descrição:
 O projeto foi iniciado com a crição da api, criando sua estrutura com Models, Controller, Service. Foi criado uma model com objeto Book onde declaro seus atributos, em seguida crio o BookContext, onde é feito os passos para conexão com banco de dados. Nesse arquivo declaro a entidade que será usada no projeto que está ligada a model.
 No projeto usei estrutura de services onde tenho a class Interface que declara as funções criadas na bookservices para ser usadas pela controller. Sendo assim, dentro da bookservice é onde está declarado todas frunções que compõe o crud, onde obtenho e manipulo os dados armazanados.
