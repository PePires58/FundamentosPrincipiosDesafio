# Desafio de requisições por assinatura.

Nesse sistema, você será responsável por criar um sistema no qual irá capturar os dados de um arquivo fake seguindo a estrutura a seguir:

"ACAO";"CODIGO USUARIO";"NOME PESSOA";"TIPO PERFIL"

Ex.:
01;AASSBC-2341BCS-213;PEDRO PIRES;1
01;AASSBC-23412XS-000;JAELSON LIMA;2
02;AASSBC-2341BCS-213;;
02;AASSBC-2341BCS-213;;
02;AASSBC-2341BCS-213;;
02;AASSBC-23412XS-000;;

Existem 3 tipos de perfis:
1 - Básico (até 100 requisições por dia)
2 - Completo (até 1.000 requisições por dia)
3 - Premium (até 20.000 requisições por dia)

Existem 2 tipos de ações:
01 - Cadastrar perfil de usuário
02 - Realizar requisições


Uma vez capturado o arquivo, será necessário retornar um tipo complexo de List<RespostaRequisicoes> no qual contém o nome da pessoa e quantas requisições a pessoa fez e quantas foram com sucesso e quantas com erro. Isso é, para cada usuário.

Ex.:
[
	{
		Nome: "PEDRO PIRES",
		Requisicoes: 3,
		Sucesso: 3,
		Erro: 0
	}
]

O que deve ser feito:
- Fazer com que o código compile
- Implementar a interface IProcessarRequisicoes


Para saber se seu código está de acordo, realize a execução dos testes de unidade com o seguinte comando na pasta do projeto:
dotnet test

# Solução disponível na branch: feature-solucao
