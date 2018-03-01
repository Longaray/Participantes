# Participantes
Project for CRUD Participantes

Intruções de Instalação:
 1) Primeiramente é preciso criar o banco e setar os valores na tabelas.
para isso o arquivo "createTableParticipantes.txt" possui os script necessários.
Execute cada um deles no seu gerenciador de SQL Server.

2) Na Pasta Participantes se encontra a solução "Participantes".
Nela se encontra os códigos fontes do programa assim como o projeto de unit testing.
Com a solução aberta no Visual Studio, clique com o botão direito na solução e selecione "Recompilar Solução".
Após o término da solução aperte F5 executar o programa.

Utilização:
  Cadastro/Update:
    Preencha os campos com as informações requiridas. Logo após clique em "Cadastro". 
    Isso irá gerar uma entrada na Grid do programa. Caso uma nova entrada possuia mesma entrada para COD_PART ("0150"+ CPF/CNPJ)
    o restante dos campos será atualizado.
    
  Exclusão:
    Selecione uma linha da grid ou um campo de uma linha que deseja excluir, em seguida clique em "Excluir". 
