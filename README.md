### CalcTest

## Sistema para cálculo de juros compostos

# Alguns recursos utilizados:

- Visual Studio 2017 - Versão 15.8.8
- .NET Framework Core 2.1
- Docker
- C#
- Orientação a Objeto
- SOLID
- TDD
- DDD
- Injeção de Dependência
- Razor
- AngularJs
- Web Api
- Swagger


### Foi implementado uma API com dois endpoints:

1) Calcula Juros
A primeira reponde pelo path relativo "/calculajuros"

Ela faz um cálculo em memória, de juros compostos, conforme abaixo: Valor Final = Valor Inicial * (1 + juros) ^ Tempo

Valor inicial é um decimal recebido como parâmetro Juros é 1% ou 0,01 (fixo no código) Tempo é um inteiro, que representa meses, também recebido como parâmetro ^ representa a operação de potência Resultado final deve ser truncado (sem arredondamento) em duas casas decimais

Exemplo: /calculajuros?valorinicial=100&meses=5 Resultado esperado: 105,10

2) Show me the code
Este responde pelo path relativo /showmethecode Deverá retornar a url de onde encontra-se o fonte no github

Esperamos que a entrega tenha

Código fonte em asp.net core no github (Mostrar conhecimento básico de git)
Teste unitários (Mostrar conhecimento de testes unitários, se possível TDD)
Extras
O ideal é este código rodar em algum servidor seu, podemos combinar tempo que irá funcionar. Se não tiver avise o entrevistador.
Teste de integração da API em linguagem de sua preferência (Damos importância para pirâmide de testes)
Utilização de Docker
Utilizar swagger


### Web Site para testar integração:

- http://robertosistemasg-001-site1.itempurl.com/


### Web API:

- http://robertosistemas-001-site1.itempurl.com/calculajuros?valorinicial=100&meses=5

- http://robertosistemas-001-site1.itempurl.com/showmethecode
