# Desafio para candidatos à vaga de desenvolvedor Krooze (Equipe GDS)
A ideia deste desafio é nos permitir avaliar melhor as habilidades de candidatos à vagas de programador, de vários níveis.
Este desafio deve ser feito por você em sua casa. Gaste o tempo que você quiser, porém normalmente você não deve precisar de mais do que algumas horas.

## Instruções de entrega do desafio
1. Primeiro, faça um fork deste projeto para sua conta no GitHub (crie uma se você não possuir).
2. Em seguida, implemente o projeto tal qual descrito abaixo, em seu próprio fork.
3. Crie as instruções de instalação e execução do aplicativo em seu `readme.md`.
4. Por fim, envie o link do seu repositório para avaliarmos seu código.

## Descrição do projeto prático.
- Primeira Etapa:
  - Faça todos os testes passarem (Projeto Krooze.EntranceTest.Tests), ou a maioria deles, caso seu nível seja Júnior
  - Seu código deve ser escrito no projeto Krooze.EntranceTest.WriteHere, ou referenciado a partir dele
  - O projeto Krooze.EntranceTest.WriteHere pode ser alterado à vontade
  - A descrição do que fazer está no "TODO" de cada método
  - Podem-se criar novos projetos na Solution, caso o dev ache necessário
- Segunda Etapa:
  - Crie um endpoint pra cada método feito nos testes da primeira etapa, no projeto Krooze.EntranceTest.Web, no total 7 endpoints
  - Organize os Endpoints como achar melhor
  - Deixe todos os endpoints disponíveis documentados em seu readme.md
  - O projeto Krooze.EntranceTest.Web pode ser completamente alterado, da maneira que o dev achar melhor
  - Podem-se criar novos projetos na Solution, caso o dev ache necessário

## Sua aplicação DEVE:
* Utilizar o máximo possível das bibliotecas padrão
* Utilizar pacotes do nuget, caso o item anterior não seja possível

## Sua aplicação NÃO DEVE:
* Não deve importar pacotes de auxílio do swapi.co.
* O projeto Projeto Krooze.EntranceTest.Tests não deve ser alterado, caso tenha alguma dúvida, ou ache que algum teste está falhando injustamente, abra uma issue após apresentar suas soluções

## Avaliação
Seu projeto será avaliado de acordo com os seguintes critérios:

1. Sua aplicação atende funcionalmente o que foi pedido;
2. Você seguiu as instruções enviadas;
3. Você segue as boas práticas de programação;
4. O código escrito é fácil de entender e manter;

## Requerimentos Técnicos
 - [.NET Core 2.2](https://dotnet.microsoft.com/download/visual-studio-sdks?utm_source=getdotnetsdk&utm_medium=referral)
 - [.NET Core 2.0](https://dotnet.microsoft.com/download/visual-studio-sdks?utm_source=getdotnetsdk&utm_medium=referral)
 - [Visual Studio 2017 ou 2019](https://visualstudio.microsoft.com/pt-br/downloads/)

 #########################################################################################################################

# Caminhos para os endpoints de LogicTests:   

- Teste XML: Acessar http://localhost:porta/api/WebTests/GetXML

- Teste GetOtherTaxes: Acessar:
	* http://localhost:porta/api/LogicTests/GetOtherTaxes/10000/1000/12000
	* http://localhost:porta/api/LogicTests/GetOtherTaxes/10000/1000/11000
	* http://localhost:porta/api/LogicTests/GetOtherTaxes/15000/1000/20000

- Teste IsThereDiscount: Acessar:
	* http://localhost:porta/api/LogicTests/IsThereDiscount/1000/700
	* http://localhost:porta/api/LogicTests/IsThereDiscount/1000/1000
	* http://localhost:porta/api/LogicTests/IsThereDiscount/1000/1200

- Teste GetInstallments: Acessar:
	* http://localhost:porta/api/LogicTests/GetInstallments/400
	* http://localhost:porta/api/LogicTests/GetInstallments/40000
	* http://localhost:porta/api/LogicTests/GetInstallments/100
	* http://localhost:porta/api/LogicTests/GetInstallments/1000
	* http://localhost:porta/api/LogicTests/GetInstallments/1001

#  Caminhos para os endpoint de InjectionTests  

- Teste GetCruises: Acessar:
	* http://localhost:porta/api/InjectionTests/GetCruises/1
	* http://localhost:porta/api/InjectionTests/GetCruises/2
	* http://localhost:porta/api/InjectionTests/GetCruises/3
	* http://localhost:porta/api/InjectionTests/GetCruises/4

#  Caminhos para os endpoint de WebTest

- Teste GetAllMovies: Acessar http://localhost:porta/api/WebTests/GetAllMovies

- Teste GetDirector: Acessar http://localhost:porta/api/WebTests/GetDirector

