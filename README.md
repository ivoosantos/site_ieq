# site_ieq
Desenvolvimento do Site com CRM para igrejas.

# Comandos:
## Git Flow
- git flow init -> aperte enter até o fim
- criar branch: git flow feature start <nome da branch>
- atualizar a branch nova no GitHub (Web): git flow feature publish
- finalizar brach: git flow feature finish
  obs.: Se vc estiver dentro a branch que precisa finalizar não precisa colocar o nome dela no final, mas se estiver fora dela, precisa colocar o nome dela no final do comando.
- depois de finalizar, ela vai entrar na branch develop, aí é só dar um: git push

## Migrations
Abre o prompt de comando na pasta do projeto "Infrastructure"
- dotnet ef migrations add <nome da migration> -s ../SiteCRM.API/SiteCRM.API.csproj -o ./Persistence/Migrations
- dotnet ef database update -s ../SiteCRM.API/SiteCRM.API.csproj
