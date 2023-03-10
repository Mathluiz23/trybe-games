# Boas-vindas ao repositório do projeto Trybe Games


<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project-trybe-games.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project-trybe-games`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.

</details>


<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/TrybeGames` ou de seus testes `src/TrybeGames.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

</details>



# Requisitos

Este Projeto consiste em um sistema para gerenciar e armazenar dados de jogos jogados por Trybers.

Este sistema está dividido em pastas específicas, para que fique mais fácil de entender e separar as entidades.
 - `Contracts/` Estão armazenadas as `interfaces` que uma classe pode implementar.
 - `Controller/` Estão armazenados os controllers responsáveis por realizar alguma ação que interage com a pessoa usuária e o banco de dados. No nosso caso há apenas um _controller_.
 - `Database/` Está armazenada a classe que representa o banco de dados do sistema. Essa classe contém uma lista de cada um dos modelos presentes no sistema e alguns métodos que podem ser utilizados para fazer consultas a essas listas e a relações entre elas.
 - `Models/` Contém os Modelos do sistema, no caso três: `Game`, `Player`, `GameStudio`.

O arquivo `Program.cs` utiliza a classe `TrybeGamesController` para executar as ações com a pessoa usuária, então é possível ver o sistema em funcionamento ao executar o projeto em `src/TrybeGames` com o comando `dotnet test`. Porém algumas funcionalidades ainda não foram implementadas, e é para isso que você foi contratado.

## Relação entre os Models `Game`, `Player` e `GameStudio` no diagrama abaixo:

![diagrama apenas com os models](img/diagram-only-models.png)

Perceba que cada `Game` possui duas relações com `Player`:
 1. Um jogo `Game` pode ter várias pessoas jogadoras `Player` utilizando para isso o membro `Game.Players`, que é uma lista do tipo inteiro e armazena os Ids das pessoas jogadoras.
 2. Uma pessoa jogadora `Player` pode ter vários jogos `Game` comprados utilizando para isso o membro `Player.GamesOwned`, que é uma lista do tipo inteiro e armazena os Ids dos jogos comprados.

`GameStudio`, por sua vez, se relaciona apenas com `Game`. Cada `Game` é desenvolvido por um `GameStudio` e é utilizado o campo `Game.DeveloperStudio`, que é do tipo inteiro e armazena o Id do studio desenvolvedor do jogo.

`Player` também pode ter uma lista de estúdios favoritos. Para isso é utilizado o seu membro `Player.FavoriteGameStudios`, que é uma lista do tipo inteiro que armazena os Ids dos estúdios favoritos.

Esses Models, por sua vez, são utilizados na classe `TrybeGamesDatabse` para compor o nosso banco de dados. E `TrybeGamesDatabase` é utilizado em `TrybeGamesController` para realizar as consultas e operações requisitadas pela pessoa usuária. Veja no diagrama completo abaixo todas as relações entre cada entidade do sistema.

![diagrama completo](img/complete-diagram.png)


 Agora em `mockConsole` temos um objeto mockado de `IConsole`, e com ele podemos substituir o comportamento de funções e métodos de `IConsole`. Para substituir o comportamento de uma função utilizamos o método `.Setup()` desse novo objeto. 
 
  
# Este projeto pode ser executado com `dotnet run` na pasta `src/TrybeGames/`,  várias funcionalidades de interação com a pessoa usuária foram  implementadas.
 
## 1 - Adicionar uma nova pessoa jogadora ao banco de dados
_Implemente o método `AddPlayer()` no arquivo `src/TrybeGames/TrybeGamesController.cs`_

<details>
  <summary>Este método deve utiliza as entradas da pessoa usuária pelo <code>Console</code> para criar uma nova pessoa jogadora e adicionar ao banco de dados</summary><br />

  A nova pessoa jogadora inserida pelo `Console`  cria uma nova instância de `Player` e insere no banco de dados `database`, que é um atributo da classe `TrybeGamesController`.

<details>
  <summary>Desenvolva o teste para o método <code>AddPlayer</code></summary><br />

  Testes para o método `AddPlayer` em `src/TrybeGames.Test/TestTrybeGamesController.cs` no método `TestAddPlayer`. 
</details>

## 2 - Adicionar novo Estúdio de Jogos ao banco de dados
_Método `AddGameStudio()` no arquivo `src/TrybeGames/TrybeGamesController.cs`_

<details>
  <summary>Este método  utiliza as entradas da pessoa usuária pelo <code>Console</code> para criar um novo Estúdio de Jogos e adicionar ao banco de dados</summary><br />

  Desenvolvido uma lógica para receber da pessoa usuária o nome do novo Estúdio de Jogos pelo `Console` e assim criar uma nova instância de `GameStudio` e inserir este no banco de dados `database`, que é um atributo da classe `TrybeGamesController`.

  > O atributo Id é incrementado a cada novo estúdio que entrar no banco de dados.
</details>

<details>
  <summary>Desenvolvido o teste para o método <code>AddGameStudio</code></summary><br />

  Testes para o método `AddGameStudio` em `src/TrybeGames.Test/TestTrybeGamesController.cs` no método `TestAddGameStudio`. 
  
</details>

## 3 - Adicionar novo Jogo ao Banco de dados
_Método `AddGame()` no arquivo `src/TrybeGames/TrybeGamesController.cs`_

<details>
  <summary>Este método utiliza as entradas da pessoa usuária pelo <code>Console</code> para criar um novo Jogo e adicionar ao banco de dados</summary><br />

  Desenvolvido uma lógica para receber da pessoa usuária os seguintes dados de um jogo:
   1. Nome (`Name`).
   2. Data de lançamento (`ReleaseDate`).
   3. Tipo de jogo (`GameType`).
  
  Este método  faz as conversões necessárias para criar uma nova instância de `Game` corretamente inserindo-as no banco de dados `database`, que é um atributo da classe `TrybeGamesController`.

</details>

<details>
  <summary>Desenvolvido o teste para o método <code>AddGame</code></summary><br />

  Testes para o método `AddGame` em `src/TrybeGames.Test/TestTrybeGamesController.cs` no método `TestAddGame`. 
  
</details>

## 4 - Buscar jogos desenvolvidos por um estúdio de jogos
_Método `GetGamesDevelopedBy()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método  recebe por parâmetro um estúdio de jogos e retornar todos os jogos que aquele estúdio desenvolveu</summary><br />

  Por se tratar de um método da classe `TrybeGamesDatabase`, este não lida com entradas e interações com a pessoa usuária. Porém ele será utilizado pelo método `QueryGamesFromStudio` para buscar os jogos desenvolvidos pelo estúdio selecionado neste método.

  No método `GetGamesDevelopedBy`, foi utilizado as listas de `Game`, `Player` e `GameStudio` presentes em `TrybeGamesDatabase` e suas relações para buscar e retornar uma lista de jogos `List<Game>`.

</details>

<details>
  <summary>Desenvolvido o teste para o método <code>GetGamesDevelopedBy</code></summary><br />

  Testes para o método `GetGamesDevelopedBy` em `src/TrybeGames.Test/TestTrybeGamesDatabase.cs` no método `TestGetGamesDevelopedBy`. 
  
</details>

## 5 - Buscar jogos jogados por uma pessoa jogadora
_Método `GetGamesPlayedBy()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método  recebe por parâmetro uma pessoa jogadora e retornar todos os jogos jogados por aquela pessoa jogadora</summary><br />

  Por se tratar de um método da classe `TrybeGamesDatabase`, este não lida com entradas e interações com a pessoa usuária. Porém ele será utilizado pelo método `QueryGamesPlayedByPlayer` para buscar os jogos jogados pela pessoa jogadora selecionada neste método. 

  No método `GetGamesPlayedBy`, foi utilizado as listas de `Game`, `Player` e `GameStudio` presentes em `TrybeGamesDatabase` e suas relações para buscar e retornar uma lista de jogos `List<Game>`.
  
</details>

<details>
  <summary>Desenvolvido o teste para o método <code>GetGamesPlayedBy</code></summary><br />

  Testes para o método `GetGamesPlayedBy` em `src/TrybeGames.Test/TestTrybeGamesDatabase.cs` no método `TestGetGamesPlayedBy`. 
  
</details>

## 6 - Buscar jogos comprados por uma pessoa jogadora
_Método `GetGamesOwnedBy()` no arquivo `src/TrybeGames/Database/TrybeGamesDatabase.cs`_

<details>
  <summary>Este método  recebe por parâmetro uma pessoa jogadora e retornar todos os jogos que aquela pessoa jogadora possui</summary><br />

  Por se tratar de um método da classe `TrybeGamesDatabase`, este não lida com entradas e interações com a pessoa usuária. Porém ele será utilizado pelo método `QueryGamesBoughtByPlayer` para buscar os jogos comprados pela pessoa jogadora selecionada neste método.

  No método `GetGamesOwnedBy`, foi utilizado as listas de `Game`, `Player` e `GameStudio` presentes em `TrybeGamesDatabase` e suas relações para buscar e retornar uma lista de jogos `List<Game>`.

 
</details>

<details>
  <summary>Desenvolvido o teste para o método <code>GetGamesOwnedBy</code></summary><br />

  Testes para o método `GetGamesOwnedBy` em `src/TrybeGames.Test/TestTrybeGamesDatabase.cs` no método `TestGetGamesOwnedBy`. 
  
</details>

