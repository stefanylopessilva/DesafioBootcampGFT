# Desafio Bootcamp GFT - C# 📝

Desafios do Bootcamp GFT START_UNI 2021 #1 em parceria com Digital Innovation One.

## 🚗 Desafio Cálculo Viagem

Rubens quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem de carro, sendo que seu carro faz 12 KM/L. Como ele não sabe fazer um programa que o auxilie nessa missão, ele te pede ajuda. Para efetuar o cálculo, deve-se fornecer o tempo gasto em horas na viagem e a velocidade média durante a mesma em km/h. Assim, você conseguirá passar para Rubens qual a distância percorrida e, em seguida, calcular quantos litros serão necessários para a viagem que ele quer fazer. Mostre o valor com 3 casas decimais após o ponto.

#### ✔️ Entrada

O arquivo de entrada contém dois inteiros. O primeiro é o tempo gasto na viagem em horas e o segundo é a velocidade média durante a mesma em km/h.

#### ✔️ Saída

Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos após o ponto decimal.

Exemplo de Entrada | Exemplo de Saída
:----------------: | :--------------:
10                 | 70.833
85                 |
22                 | 122.833
67                 |

## ⚽ Desafio Álbum da Copa

A Copa do Mundo de Futebol é um dos maiores eventos esportivos do Planeta Terra, e o álbum de figurinhas oficial é sempre um grande sucesso entre os amantes dessa competição. O álbum contém espaços numerados de 1 a N para colar as figurinhas; cada figurinha, também numerada de 1 a N, é uma pequena foto de um jogador de uma das seleções que jogará a Copa do Mundo. O objetivo é colar todas as figurinhas nos respectivos espaços no álbum, de modo a completar o álbum, ou seja, não deixar nenhum espaço sem a correspondente figurinha.

As figurinhas são vendidas em envelopes fechados, de forma que o comprador não sabe quais figurinhas está comprando, e pode ocorrer de comprar uma figurinha que ele já tenha colado no álbum.

Para ajudar os usuários, a empresa responsável pela venda do álbum e das figurinhas quer criar um aplicativo que permita gerenciar facilmente as figurinhas que faltam para completar o álbum e está solicitando a sua ajuda.

Dados o número total de espaços e figurinhas do álbum, e uma lista das figurinhas já compradas (que pode conter figurinhas repetidas), o seu desafio é determinar quantas figurinhas faltam para completar o álbum.

#### ✔️ Entrada

A primeira linha contém um inteiro N (1 ≤ N ≤ 100) indicando o número total de figurinhas e espaços no álbum. A segunda linha contém um inteiro M (1 ≤ M ≤ 300) indicando o número de figurinhas já compradas. Cada uma das M linhas seguintes contém um número inteiro X (1 ≤ X ≤ N) indicando uma figurinha já comprada.

#### ✔️ Saída

Seu programa deve produzir uma única linha contendo um inteiro representando o número de figurinhas que falta para completar o álbum.

 
Exemplo de Entrada | Exemplo de Saída
:----------------: | :--------------:
10                 | 7
3                  |
5                  |
8                  |
3                  |
3                  | 0
4                  |
2                  |
1                  |
3                  |
3                  |

## 🐵 Desafio Animal

Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

#### ✔️ Entrada

A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

#### ✔️ Saída

Imprima o nome do animal correspondente à entrada fornecida.

![image](https://user-images.githubusercontent.com/29932387/107520691-74902b00-6b90-11eb-8297-c69c69f4f5cd.png)
 
Exemplo de Entrada | Exemplo de Saída
:----------------: | :--------------:
vertebrado         | homem
mamifero           |
onivoro            |
vertebrado         | aguia
ave                |
carnivoro          |
invertebrado       | minhoca
anelideo           |
onivoro            |
