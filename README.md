# tees-2026-2-unidade-1

### Situação atual

Antes das alterações, tínhamos um monolito onde o serviço tinha como dependência direta o Entity Framework, gerando um acoplamento.

### Quantos artefatos, quantos bancos?

Dois artefatos (BibliotecaAPI e BibliotecaWeb) que utilizam o mesmo Core e apenas um banco de dados, ainda se enquadrando em um monolito.

### Para onde apontam as dependências?

As dependências apontam sempre para dentro.

Os projetos externos (BibliotecaAPI, BibliotecaWeb e Infrastructure) conhecem e apontam para as camadas internas (Service e Core). A camada intermediária (Service) aponta apenas para o núcleo (Core). O núcleo (Core) é completamente isolado e não aponta para nenhuma outra camada.

O projeto utiliza a arquitetura Hexagonal (uma arquitetura que não escapa conceitualmente da Clean e Onion).

Todas elas compartilham da mesma regra central: inverter as dependências para proteger o domínio.

### Qual escolhemos?

Optamos pela Arquitetura Hexagonal pela clareza em lidar com o conceito de Portas e Adaptadores. O sistema exige múltiplos pontos de interação (API, Web).

## Como tudo se comporta agora?

Atualmente, podemos separar da seguinte forma:

- **Camada externa** (Sempre apontam para camadas mais internas e são basicamente as formas de o sistema ser acessado e acessar outros recursos)

  - BibliotecaAPI
  - BibliotecaWeb
  - Infrastructure

- **Camada intermediária** (Sempre aponta para o Core, onde fica a interface que define o uso do repositório e a declaração das classes das entidades)

  - Service

- **Domínio**
  - Core

Dessa forma, temos todos os contratos definidos no Core e sendo acessados pelos serviços e repositórios, que por sua vez são acessados pelos projetos Web e API.
