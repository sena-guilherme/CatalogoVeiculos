# Catálogo de Veículos

Projeto do CP1 da disciplina de Análise e Desenvolvimento de Sistemas (FIAP).

Sistema de cadastro de motos via console em C#, aplicando herança, polimorfismo e tratamento de exceções.

## O que faz

- Cadastro de motos com marca, modelo, ano, preço, cor e cilindradas
- Validação de entradas (campos em branco e erro de tipo numérico)
- Listagem de tudo no final + total de cadastrados
- Laço de repetição com opção de continuar ou parar

## Conceitos aplicados

- **Herança:** `Moto` herda de `Veiculo` (`class Moto : Veiculo`)
- **Polimorfismo:** método `Apresentar()` sobrescrito com `override` na classe filha
- **Encapsulamento:** propriedades com get/set
- **Tratamento de exceções:** `try/catch` com `FormatException` nos campos numéricos
- **Collections:** `List<Veiculo>` tipada pela classe base (aceita objetos da filha)

## Estrutura
CatalogoVeiculos/
├── Program.cs    # Cadastro interativo + listagem final
├── Veiculo.cs    # Classe base (marca, modelo, ano, preço, cor)
├── Moto.cs       # Classe derivada (adiciona cilindradas)
└── .csproj

## Como rodar
```bash
git clone https://github.com/sena-guilherme/CatalogoVeiculos.git
cd CatalogoVeiculos
dotnet run

Autor Guilherme Sena — ADS / FIAP
