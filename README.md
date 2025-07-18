# ApiConsultaCnpj

[![.NET](https://github.com/VictorDePaula06/ApiConsultaCnpj/actions/workflows/dotnet.yml/badge.svg)](https://github.com/VictorDePaula06/ApiConsultaCnpj/actions/workflows/dotnet.yml)

Este projeto é uma **API RESTful** desenvolvida com **ASP.NET Core** para realizar consultas públicas de **dados de empresas via CNPJ**. A API se conecta com uma base externa para obter informações cadastrais de empresas brasileiras registradas no CNPJ.

## 🚀 Tecnologias Utilizadas

* **C#**
* **ASP.NET Core**
* **HttpClient** (para consumo da API externa de CNPJ)
* **Swagger/OpenAPI** (para documentação e testes interativos)

## ✨ Funcionalidades Principais
* ** No meu emprego atual temos muitos problemas quando precisamos localizar os dados de um cliente, precisamos saber o Estado do cliente e muitas vezes o portal de pesquisa do governo esta fora, então decido praticar e elaborar esse projeto !
* **Consulta de CNPJ:** Realiza requisições HTTP para uma API externa usando o número do CNPJ informado.
* **Validação de entrada:** Garante que o CNPJ esteja no formato correto antes de realizar a consulta.
* **Resposta estruturada:** Retorna as principais informações da empresa consultada, como razão social, nome fantasia, endereço, situação cadastral, entre outros.
* **Documentação via Swagger:** Para facilitar o uso e teste dos endpoints.

## 🛠 Pré-requisitos

Antes de iniciar, verifique se possui os seguintes softwares instalados:

* [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download)
* Uma IDE como [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) ou [VS Code](https://code.visualstudio.com/)
* (Opcional) Ferramenta `Postman` para testar a API
* ## ⚙️ Configuração e Execução

1. **Clone o repositório:**

bash
git clone https://github.com/VictorDePaula06/ApiConsultaCnpj.git
cd ApiConsultaCnpj

2. **Clone o repositório:**
dotnet run

A API estará disponível em:
https://localhost:5001
http://localhost:5000
A porta pode variar dependendo do Visual Studio/VS Code. Verifique no terminal ou no arquivo launchSettings.json.

📄 Documentação da API (Swagger)
Após iniciar a aplicação, acesse o Swagger para testar a consulta de CNPJ diretamente pelo navegador:
https://localhost:5001

✉️ Contato
João Victor de Paula
LinkedIn: www.linkedin.com/in/joaovictor0611
Email: j.17jvictor@gmail.com
Telefone: 21 982626387 

