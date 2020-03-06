# SOLID
Princípios de SOLID

## O que é
Resumidamente trata-se de uma evolução do que conhecemos por Orientação à Objeto, Michael Feathers definiu 5 pilares de SOLID como 

 | Letra  |  Significado                     | Tradução                             |
 | ------ | -------------------------------- | ------------------------------------ |
 |   S    |  Single Responsiblity Principle  | Princípio da responsabilidade única  |
 |   O    |  Open-Closed Principle           | Princípio Aberto-Fechado             |
 |   L    |  Liskov Substitution Principle   | Princípio da substituição de Liskov  |
 |   I    |  Interface Segregation Principle | Princípio da Segregação da Interface |
 |   D    |  Dependency Inversion Principle  | Princípio da inversão da dependência |

### Single Responsiblity Principle
O princípio da responsabilidade única nós diz que uma classe deve ter apenas 1 motivo para existir, pense em como é complexo gerenciar ou testar essa classe conforme o projeto avança!
Veja um cenário errado em: 
```
src\S\Bad.cs
```
Veja o mesmo cenário aplicando este princípio em:
```
src\S\Good.cs
```

### Open-Closed Principle
O princípio aberto-fechado nós diz que uma entidades devem estar abertos para extensão, mas fechados para modificação, conforme
adicionamos funcionalidades elas serão a extensão de já existentes, esse princípio é um pouco complexo fica mais fácil ver um exemplo real
__"Separe o comportamento extensível por trás de uma interface e inverta as dependências" - Uncle Bob__

Veja um cenário errado em: 
```
src\O\Bad.cs
```
Veja o mesmo cenário aplicando este princípio em:
```
src\O\Good.cs
```

### Liskov Substitution Principle
Intimamente ligado com herança Barbara Liskov definiu resumidamente este processo como:
__"Se q(X) é uma propriedade demonstrável dos objetos X de tipo T. Então q(y) deve ser verdadeiro para objetos y de tipo S onde S é um subtipo de T." - [Wikipedia](https://pt.wikipedia.org/wiki/Princ%C3%ADpio_da_substitui%C3%A7%C3%A3o_de_Liskov)__

Veja um cenário errado em: 
```
src\L\Bad.cs
```
Veja o mesmo cenário aplicando este princípio em:
```
src\L\Good.cs
```

### Interface Segregation Principle
Este princípio nós diz que devemos evitar interfaces genéricas, pois quem a implementa não deve ter um metodo implementado ao qual não é 
utilizado.
```
src\I\Bad.cs
```
Veja o mesmo cenário aplicando este princípio em:
```
src\I\Good.cs
```

### Dependency Inversion Principle
Princípio da inversão de dependencias, sua classe deve depender de uma interface, não de uma implementação
```
src\D\Bad.cs
```
Veja o mesmo cenário aplicando este princípio em:
```
src\D\Good.cs
```


