🐱 The Cat API Project

Aplicação desktop desenvolvida em C# .NET (WinForms) que consome a API pública The Cat API para exibir imagens aleatórias de gatos e armazenar os dados em banco de dados.

🚀 Funcionalidades
🔹 Consumo de API REST
🔹 Exibição de imagens aleatórias de gatos
🔹 Interface gráfica com WinForms
🔹 Arquitetura em camadas (MVC)
🔹 Persistência de dados com Microsoft SQL Server
🔹 Exibição da URL em formato de barra de busca

🧱 Arquitetura

O projeto foi estruturado seguindo o padrão MVC (Model-View-Controller):

📁 Models       → Representação dos dados (Cat)
📁 Services     → Consumo da API externa
📁 Controllers  → Regras e intermediação
📁 Data         → Acesso ao banco de dados (Repository)
📁 Views        → Interface (WinForms)
🔄 Fluxo da aplicação
View → Controller → Service → API
                     ↓
                  Database
                  
🗄️ Banco de Dados

O projeto utiliza o Microsoft SQL Server para persistência dos dados.

📋 Estrutura da tabela
CREATE TABLE Cats (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ApiId NVARCHAR(50),
    Url NVARCHAR(MAX),
    DataBusca DATETIME
);

🛠 Tecnologias utilizadas

C# .NET (WinForms)
HttpClient
Newtonsoft.Json
SQL Server
ADO.NET

📦 Como executar o projeto

Clone o repositório:
git clone https://github.com/nickpedro/TheCatApiProject
Abra no Visual Studio:
TheCatApiProject.sln
Configure o banco de dados no Microsoft SQL Server
Atualize a connection string no arquivo App.config:
<connectionStrings>
  <add name="SqlConnection"
       connectionString="Server=SEU_SERVIDOR;Database=CatDb;Trusted_Connection=True;" />
</connectionStrings>
Execute o projeto:
F5

🎨 Interface

A aplicação possui uma interface simples e funcional:

Botão para buscar gatos 🐱
Exibição da imagem
Barra de URL estilizada
Integração com banco de dados
📌 Melhorias futuras
⭐ Sistema de favoritos
📋 Tela de histórico (dados do banco)
🎨 Interface mais moderna (WPF)
🌐 Versão web com ASP.NET
🔎 Filtro por raça

👨‍💻 Autor
Desenvolvido por Pedro Henrique
🔗 GitHub: https://github.com/nickpedro

📄 Licença

Este projeto é de uso livre para fins de estudo e aprendizado.
