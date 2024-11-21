# Desafio de requisições por assinatura.

Você será responsável por criar um sistema no qual irá capturar os dados de um arquivo fake seguindo a estrutura a seguir:

"ACAO";"CODIGO USUARIO";"NOME PESSOA";"TIPO PERFIL"

Ex.:
```
01;AASSBC-2341BCS-213;PEDRO PIRES;1
01;AASSBC-23412XS-000;JAELSON LIMA;2
02;AASSBC-2341BCS-213;;
02;AASSBC-2341BCS-213;;
02;AASSBC-2341BCS-213;;
02;AASSBC-23412XS-000;;
```

Repare que existem registros que contém mais campos do que outros, isso é dado devido a diferença da "ação" do template, veja mais a seguir.

Existem 3 tipos de perfis:
1 - Básico (até 100 requisições por dia)
2 - Completo (até 1.000 requisições por dia)
3 - Premium (até 20.000 requisições por dia)

Existem 2 tipos de ações:
01 - Cadastrar perfil de usuário (contém nome da pessoa e o tipo de perfil)
02 - Realizar requisições (contém apenas o código da ação e o da pessoa)

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

Para saber se seu código está de acordo, realize a execução dos testes de unidade.
- caso esteja com visual studio code, execute o comando: dotnet test
- caso esteja com visual studio, vá em teste -> executar todos os testes

# Solução disponível na branch: feature-solucao

Após realizar o desafio, suba sua branch de feature** no repositório e acompanhe o resultado na aba: (Actions do Repositório)[https://github.com/PePires58/FundamentosPrincipiosDesafio/actions]

# Passo a passo para participar do desafio
<ul>
    <li>Execute o clone do projeto</li>
    <li>Execute o comando dentro da pasta do projeto: git checkout -b feature-[seu identificador, você que escolhe]</li>
    <li>git add .</li>
    <li>git commit -m "sua mensagem"</li>
    <li>git push ou então git push --set-upstream origin feature-[seu identificador] (isso é executado apenas na primera vez)</li>
</ul>

Demais instruções na vídeo aula!

Boa sorte e bom desafio.

Equipe: A Escola de Software
Instrutor: Pedro Henrique Pires