# Controle da Velocidade de um Robô 🤖

Este programa simula o controle de velocidade de um robô através de comandos do usuário para determinar sua velocidade máxima e mínima, e também a quantidade de aceleração e desaceleração.

## Entrada

✅ O programa inicia solicitando ao usuário que insira a máxima e mínima deste robô. São dois inteiros: vmin e vmax (1 ≤ Vmin < Vmax ≤ 100).

✅ Em seguida pede uma sequência de comandos, onde 'A' adiciona 1 unidade, e 'D' subtrai.

## Saída do programa:

✅ Ao percorrer a sequencia de comandos fornecidos no loop `foreach`, o programa realiza o seguinte cálculo:

- Para cada comando 'A', a velocidade atual do robô é decrementada em 1 unidade, considerando a vmax.
- Para cada 'D', a velucidade atual é decrementada em 1 unidade, respeitando a vmin.
- Obs: neste código, não tem como ultrapassar a velocidade e mínima com os comandos.

No fim deste processo, a saída do programa mostra exibe a velocidade final do robô.

![terminal do código executado](saida.png)

### Exemplo: 🤖

O usuário digitou a entrada `2 8ADAAD`.

- Velocidade Mínima(vmin): 2
- Velocidade Máxima(vmax): 8
- Sequência de comandos: 'A', 'D', 'A', 'A', 'D'

A lógica do programa ocorre da seguinte forma:

1. Inicialização do robô:

- Velocidade atual do robô: Inicia em 2 (valor mínimo).

2. Execução dos comandos:

- 'A': Acelera o robô para 3 (dentro da velocidade permitida).
- 'D': Desacelera o robô para 2
- 'A': Acelera o robô para 3.
- 'A': Acelera o robô para 4.
- 'D': Desacelera o robô para 3.

3. Saída do programa:

- A saída final é a velocidade atual do robô, que nesse caso é 3.
