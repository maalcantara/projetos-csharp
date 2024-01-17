# Sistema de Hospedagem 🏨

Projeto em C# que implementa um Sistema de Hospedagem no qual realiza o cadatros dos hóspedes e retorna o valor da diária e o valor total da reserva efetuada.

🛏️ Este projeto é um desafio da trilha .NET da https://www.dio.me/en, o qual implementei outros métodos e tornei mais interativo. Entretanto, ainda precisa de muitas [melhorias 🛠️](#melhorias-🛠️).

## Sobre 🛎️

O Sistema de hospedagem realiza uma reserva em um hotel. Nesse, é implementado a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que faz um relacionamento entre ambos.

O programa calcula os valores dos métodos da classe Reserva, que precisaráprecisa trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um periodo maior que 10 dias.

## Regras e validações 🛋️

1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes.

- Exemplo: se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.

2. O método `ObterQuantidadeHospedes` da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método `CalcularValorDiaria` deverá retornar o valor da diária (dias reservados \* valor da diária).

3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.

![diagrama classes](images/diagrama_classe_hotel.png)

## Saída do programa: 🚨

![terminal do código executado](images/terminal.png)

## Melhorias 🛠️

- Só dá para para cadastrar hóspedes 1x → fazer um loop;
- Adicionar funcionalidades → como no projeto [Sistema Estacionamento](https://github.com/maalcantara/projetos-csharp/tree/main/SistemaEstacionamento);
  - adicionar hospede(s), remover e listar.
- Integrar um Banco de Dados;
- Tornar a parte de solicitação de informações mais coerente.
