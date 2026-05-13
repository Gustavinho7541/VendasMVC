# Vendas MVC

Sistema de vendas desenvolvido com ASP.NET MVC, Entity Framework Core e PostgreSQL.

## 🚀 Tecnologias
- ASP.NET Core MVC
- Entity Framework Core
- PostgreSQL
- Npgsql

## 📦 Funcionalidades
- Cadastro de clientes
- Cadastro de produtos
- Registro de vendas
- Relacionamento N:N (VendaProduto)

## ▶️ Como rodar
1. Configurar appsettings.json
2. Rodar:
   dotnet ef database update
   dotnet run
   
## 🧱 Banco de Dados

Para criar o banco:

```bash
dotnet ef database update


👉 Isso mostra que você sabe trabalhar com EF Core de verdade.

---

## 🔥 Quando rodar isso?

👉 Agora mesmo, **antes de dar push final**, porque:

- Deixa o projeto completo
- Mostra maturidade técnica
- Evita “projeto incompleto” no GitHub

---

## 🧠 Resumo direto

Sim, você precisa dele:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
