# Estudo-APT-NET
Estudo de criação de projeto API em c# .NET Core + Docker

# pré-requisitos
  - Docker instalado ( https://docs.docker.com/desktop/install/windows-install/ )
  - .NET 6 instalado (https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.408-windows-x64-installer)
  - VSCode ( https://code.visualstudio.com/ )


# instalação
  - abrir terminal do diretorio onde o Projeto esta.
  - se o dotnet ef não tiver instalado no projeto rodar o comando : `dotnet tool install --global dotnet-ef`
  - iniciar o container do banco de dados MySql : `docker-compose up`
  - Rodar as migrations para criar as tabelas do banco de dados `dotnet ef database update`
  - Compilar o projeto : `dotnet build .`
  - iniciar o projeto : `dotnet run`