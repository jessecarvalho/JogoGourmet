# JogoGourmet

Este é um jogo de adivinhação simples construído em C# utilizando o console. O objetivo do jogo é adivinhar o prato que o jogador está pensando, fazendo perguntas sobre características dos alimentos até chegar a uma resposta correta.

## Instruções de Uso

Para executar o jogo, basta acessar Setup/JogoGourmet.exe. O jogo também pode ser executado a partir do Visual Studio e afins, abrindo o arquivo JogoGourmet.sln e executando o projeto JogoGourmet.

## Projetos

### Projeto Core

O projeto Core contém a lógica principal do jogo. Ele possui:

-   **Estrutura de Dados:** Implementação da estrutura de árvore de nós para representar os pratos e características.
-   **Lógica de Adivinhação:** Métodos para adivinhar o prato pensado e adicionar novos pratos.
-   **Interfaces e Modelos:** Definições de interfaces e modelos utilizados no jogo.

### Projeto Cli

O projeto Cli é a interface do usuário via linha de comando (CLI - Command Line Interface). Ele é responsável por:

-   **Interatividade:** Interface de interação com o jogador através do console.
-   **Inicialização do Jogo:** Responsável por iniciar o jogo e interagir com a lógica do projeto Core.

## Funcionalidades

-   **Adivinhação de Pratos:** O jogo inicia com uma lista de pratos iniciais (massa, bolo de chocolate, etc.) e faz perguntas ao jogador para identificar o prato pensado.

-   **Adição de Novos Pratos:** Caso o prato pensado não esteja na lista, o jogo permite ao usuário adicionar um novo prato e suas características para incrementar o banco de dados de pratos.


## Detalhes Técnicos

-   **Estrutura de Dados:** O jogo é construído utilizando uma estrutura de árvore de nós, onde cada nó representa um prato ou uma característica.

-   **Recursão:** O processo de adivinhação é implementado utilizando recursão para percorrer os nós da árvore, permitindo explorar diferentes caminhos até encontrar o prato correto.

-   **Console Interface:** A interação com o jogador é feita por meio do console, onde são exibidas as perguntas e coletadas as respostas.