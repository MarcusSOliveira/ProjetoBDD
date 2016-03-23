#language: pt-br 
# O padrão é inglês, apague tudo que foi gerado e mude para a linha acima.

Funcionalidade: Manter Departamento
	Rotinas de cadastro, consulta, exclusão e edição de departamento

Cenário: Cadastrar Departamento
	Dado Acessar a pagina de cadastro de departamento
	E Informar o nome "Departamento Teste"
	Quando Solicitar o cadastro
	Entao Sistema exibe mensagem "Departamento cadastrado com sucesso"

Cenario: Validar dados ao cadastrar departamento
	Dado Acessar a pagina de cadastro de departamento
	E Nao preencher o nome do departamento
	Quando Solicitar o cadastro
	Entao Sistema exibe mensagem de erro "Nome do Departamento Obrigatorio"