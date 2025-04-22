# CookBookApp
A windows forms app to save, edit and visualize cuisine recipes.

(PORTUGUESE)

O projeto final visa criar uma aplicação de gestão de receitas e contém as seguintes funcionalidades:
	* criação de receitas
	* edição de receitas existentes
	* eliminação de receitas
	* visualização por:
		- nível de dificuldade
		- categoria gastronômica da receita
		- tempo de preparo, sendo possível listar em ordem crescente e decrescente
		- e listagem "todas" que inclui todos os atributos acima mencionados
	
Durante o processo de criar um receita, deve se adicionar os ingredientes um a um, após preencher os espaços corretamente
clique em 'Adicionar ingrediente' no canto inferior esquerdo. E após todos os ingredientes terem sido inseridos clicar em 'Guardar'
no canto superior esquerdo.

A receita será salva em um arquivo .json no diretório 'Receitas' no root do repositório. Após fechar a aplicação a receita
continuará disponível para edição e visualização, deve clicar em 'Editar' no canto superior esquerdo.
	Para eliminar uma receita deve se clicar em 'Eliminar' no canto superior esquerdo, selecionar a receita e confirmar a ex-
clusão.

Para o processo de listagem encontra-se ao lado direito da interface do programa um estrutura de seleção linkada, deve-se
escolher no primeiro comboBox o tipo de dado desejado, no segundo comboBox a opção de visualização para o tipo de dado selecionado,
após clicar em listar, o programa irá gerar um listView com as opções selecionadas.
