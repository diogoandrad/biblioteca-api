# CrudLivros - Backend

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
 
 No projeto usei estrutura de services onde tenho a class Interface que declara as funções criadas na bookservices para ser usadas pela controller. Sendo assim, dentro da bookservice é onde está declarado todas frunções que compõe o crud, onde obtenho e manipulo os dados armazenados.

 Na controller criei uma class onde cada função tem sua requisição e sua rota. Em cada função também faço uma chamada das ações de back end que foram feitas na service e faço utilização na controller.
 
 Fazendo a instalação das dependências, instalei o pacote para uso do swagger e os pacotes para o uso do Entity Framework Core, para a conexão ao postgres e outros pacotes adicionais para rodar migrations(Tools, Design).
 
 Na Startup.cs declarei nas configure o uso dos pacotes instalados, informando onde está localizado as informações do banco e indicando os services usados e permitindo que o angular tenha acesso ao http da api(Cors).
 
 Em seguida, no angular criei a model para indentificar o tipo de cada atributo recebido da entidade. E criei a conexão com api na service, declarando a url usada para obter as requisições e fazendo cada função de acordo com as chamadas.

 Então, ainda no frontend, criei o component, declarei as rotas, instalei os pacotes usados para bootstrap e assim fui desenvolvendo o layout.
