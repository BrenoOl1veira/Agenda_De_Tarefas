# Agenda-De-Tarefas
O projeto é basicamente uma agenda de tarefas onde ao criar uma tarefa você pode visualiza-la a partir da lista. Fora isso você pode editar e excluir arquivos. 

Tecnologias utilizadas:  <br/> 
.NET5 SQLSERVER C# VSCODE  <br/> 
<div style="display: inline_block">
  <img align="center" height="30" width="40" img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" />
  <img align="center" height="30" width="40" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/microsoftsqlserver/microsoftsqlserver-plain-wordmark.svg" />
  <img align="center" height="30" width="40" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" />
  <img align="center" height="30" width="40" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg" /> <br/>         
</div>

# Instruções para executar o projeto 
//PARA UTILIZAR A APLICAÇÃO VOCE PRECISA POSSUIR O VISUAL STUDIO CODE 2019,SQL SERVER E .NET5//

1: Após iniciar o VSCODE é necessario que voce coloque seu usuario do SQLSERVER na pasta, Alterando: User Id=SEU USUARIO;Password=SUA SENHA"

2: para fazer isso voce precisa acessar o "Gerenciador De Soluções" ir em "appsettings.json" e alterar o User Id=sa;Password=1234" para seu usuario do Banco de dados.

3: Feito isso iremos conectar o banco de dados com o projeto para fazer isso é bem simples basta você acessar o "Console do Gerenciador de Pacotes" e digitar o seguinte codigo:

Add-Migration NOMEDASUATABELA -Context BancoContext 

Feito isso vamos para o segundo codigo:

Update-Database -Context BancoContext 

Feito isso basta iniciar a aplicação e usar.
