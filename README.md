# AspCoreBackEndFrontApi


## Especificações:


- **Back End** - Aspnet core Web Api Rest
- **Front End** - AspNet Core Consumindo a Web Api contendo também Html, Boostrap e validações efetuadas na Controller em Modelstate com o Plugin desenvolvido em Jquery Validate.js
- **Banco de Dados** -  MySQL utilizando Dapper
- Na API temos a pasta  DataBase e nela contém um backup do Banco de dados.



## Requisitos



- Net Core 2.1
- Visual Studio Code / Visual Studio 2017
- MySQL



# O que você vai encontrar neste projeto



Visando as melhores práticas para desenvolvimento de uma API, este projeto conta com as seguintes tecnologias:
- **Dapper** - Biblioteca do StackOverflow que possui um mecanismo simples de execução de comandos em um banco de dados, mapeando, de forma otimizada, objetos do banco em classes no projeto;
- **Swagger** - Biblioteca que gera um site, com capacidade de testar a API online e exibe a documentação de cada método dos controllers;
- **MySqlConnector** - Library utilzada para conexão com uma base de dados MySql
- **Padrão de Projeto** - Repository para uma estrutura organizada escalavel



# Como executar o projeto

- Abra a pasta da API e selecione com o Visual Studio a solution
- Altere as configurações de acesso ao Banco de dados MySQL no arquivo appsetting.json
- Restaure a Base de Dados do MySQL
- Execute a aplicação da ApiMySQl Back End pelo Visual Studio e a parte do Front End Web Site pelo prompt CMD indo no diretório do Web Site pelo comando CD e inserido o codigo no CMD DotNet Run   
