# SOLID-CSharp
Projeto criado para aplicar os conceitos de SOLID!

- **Single Responsability Principle ou Principio da responsabilidade única:** Ele diz que uma classe deve ter apenas um motivo para mudar.

- **Open/Closed Principle ou Principio do Aberto/Fechado:** Classes ou objetos e métodos devem estar abertos para extensão (Herança) mas fechados para modificação.

- **Liskov Substitution Principle ou Principio da substituição de Liskov:** Nele as classes derivadas devem ser capazes de substituir totalmente classes bases.
  - OBS! Esse principio está ligado a Herança, uma classe filha deve ser capaz de substituir uma classe pai!

- **Interface Segregation Principle ou Principio da Segregação de Interface:** Classes não devem ser forçadas a depender de interfaces que não utilizam.
  - OBS! Esse principio diz praticamente que é melhor ter varias interfaces com contratos mais específicos do que ter uma interface com vários métodos onde alguma classe que herde essa interface não precise de todos esses métodos.

- **Dependency Inversion Principle ou Principio da Inversão de Dependência:** Módulos de alto nível não devem ser dependentes dos módulos de baixo nível. Ambos devem depender de abstrações!
  - As abstrações não devem depender de detalhes. Os detalhes devem depender de abstrações.
  - **DEVEMOS DEPENDER DE ABSTRAÇÕES E NÃO DE IMPLEMENTAÇÃO!**
  
    - **Modulo de Alto Nível:** São classes que contém as regras de negócio!
    - **Modulo de Baixo Nível:** são módulos que contém implementação de infraestrutura, como uma classe que faz transações no BD!
    - **Abstrações:** São Interfaces e classes abstratas (Classes que contem métodos abstratos que podem ser sobrescritas usando um override).
    - **Detalhes:** São classes concretas (São classes que dependem de classes abstratas, ou seja, são classes que utilizamos seus métodos com uso do override para sobrescrever os métodos abstratos).
  - `**OBS! Esse conceito está totalmente ligado ao SRP e ISP!**`
