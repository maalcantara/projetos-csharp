# Sistema de Cadastro de Smartphones 📱

Projeto em C# que implementa um Sistema cadastro de smartphones a partir de uma classe abstrata e instanciamento de métodos, seguindo os principios da programação orientada a objetos.

## Sobre 📲

![](images/diagrama.png)

✅ A classe abstrata `Smartphone` implanta os atributos e métodos gerais, possuindo o método abstrato `InstalarAplicativo()`, que permite o polimorfismo (ser sobrescrito) em cada uma das classes de marca de celulares.

✅ As classes IPhone, Samsung e Xiaomi são filhas da classe Smartphone, e instanciam o método InstalarAplicativo() com seus atributos específicos.

✅ Por fim, na main do projeto (Program.cs), as classes específicas são instanciadas e realizados os testes com os métodos concretos e abstratos.

## Saída do programa: ☎️

![terminal do código executado](images/terminal.png)

📲 Aprimoramento do projeto proposto pela https://www.dio.me/en
