 <h1 align="center">
    CRUD de Tanques: Uma Solução de Gerenciamento Logístico
</h1>
<br>
  <img src="https://github.com/Henrique-Lira/henrique-unisolution/blob/master/_screenshots/Screenshot_5.png">
<br>
<h1 align="center">
<img src="https://github.com/Henrique-Lira/henrique-unisolution/blob/master/_screenshots/unisolution.gif">
</h1>

## 👨‍💻 Teste Técnico Desenvolvimento FullStack
### DESCRIÇÃO
O objetivo principal é criar uma aplicação contendo o CRUD completo da tabela Tanque: 

### Campos: 
- **Depósito:** Descrição (Essa é a descrição e a chave).
- **Capacidade:** Capacidade do tanque.
- **Tipo de Produto:** Tipo de produto armazenado.

### Tecnologias e Padrões Utilizados
- **Frontend:** Angular 12
- **Backend:** .NET 4.6.1 / Entity Framework Core / RESTful API
- **Padrões:** DDD (Domain-Driven Design) e Injeção de Dependência

## 🚀 Projeto

- Este projeto é uma solução completa de CRUD para a entidade "Tanque". O sistema oferece operações de criação, leitura, atualização e exclusão para registros de tanques, otimizando a logística de armazenamento.

## 💻 Tecnologias

Esse projeto foi desenvolvido com as seguintes tecnologias:

- **Frontend:** Angular 12
- **Backend:** .NET 4.6.1 / Entity Framework Core / RESTful API
- **Padrões:** DDD (Domain-Driven Design) e Injeção de Dependência

## 🌐 Como Rodar a Aplicação

### Pré-requisitos

Antes de começar, verifique se você atende aos seguintes requisitos:

- **Node.js:** É necessário ter o Node.js instalado na versão 14.15.0. Você pode baixá-lo em [nodejs.org](https://nodejs.org/).
- **.NET Framework:** É necessário ter o .NET Framework na versão 4.6.1. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download/dotnet-framework).
- **Entity Framework Core:** Utilizamos o Entity Framework Core. Certifique-se de estar usando uma versão compatível com o .NET Framework instalado.
- **Angular:** O frontend da aplicação foi desenvolvido com Angular na versão 12. Verifique se você tem o Angular CLI instalado globalmente. Caso não tenha, você pode instalá-lo usando o comando `npm install -g @angular/cli`.

### Configuração do Banco de Dados

1. Faça o download do projeto para sua máquina.
2. Abra a solução localizada na pasta "aspnet-core" usando o Visual Studio.
3. No arquivo `appsettings.json` dentro do projeto "Henrique.Unisolution.Web.Host", ajuste a string de conexão do banco de dados conforme necessário.
4. No Package Manager Console, selecione o projeto padrão como "src\Henrique.Unisolution.EntityFrameworkCore".
5. Execute o comando `Update-Database` para criar o banco de dados com base nas configurações.
6. Após a criação bem-sucedida do banco de dados, inicie o projeto para lançar a aplicação.

### Iniciando o Projeto Angular

1. Abra um terminal e navegue até a pasta do seu projeto Angular.
2. Instale as dependências do projeto Angular com o comando `npm install`.
3. Inicie o servidor de desenvolvimento com `npm start`.
4. O frontend Angular estará disponível localmente em: http://localhost:4200

### Credenciais de Login

- **Usuário:** admin
- **Senha:** 123qwe

Esta aplicação é uma poderosa ferramenta de gerenciamento de tanques, permitindo controle total sobre os registros de armazenamento. Sinta-se à vontade para explorar e contribuir para este projeto!
