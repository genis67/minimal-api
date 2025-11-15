# minimal-api
bootcamp GFT Start #7 .NET

**Tecnologias**
- **Linguagem:** C#
- **Plataforma:** .NET 10 (`net10.0`) - SDK Web
- **Framework Web:** ASP.NET Core (Minimal APIs)
- **ORM:** Entity Framework Core 9 (Pacotes instalados: `Microsoft.EntityFrameworkCore`, `Microsoft.EntityFrameworkCore.Design`, `Microsoft.EntityFrameworkCore.Tools`)
- **Proveedor de banco de dados:** MySQL via `Pomelo.EntityFrameworkCore.MySql` (versão 9.x)
- **Ferramentas/CLI:** `dotnet` (CLI), `dotnet watch` (Hot Reload / watcher)
- **Arquitetura do projeto:** Pastas `Dominio` (DTOs, Entidades, Serviços) e `Infraestrutura/Db` (DbContext)
- **Configurações do projeto:** `Nullable` e `ImplicitUsings` habilitados no `.csproj`

**Como rodar (rápido)**

- Abra um PowerShell na pasta do projeto:

```powershell
cd C:\Users\genis\Downloads\projetos\minimal-api
```

- Rodar normalmente:

```powershell
dotnet run
```

- Rodar com reinício automático ao salvar (dotnet watch):

```powershell
dotnet watch run
```

**Observações**

- O projeto alvo é `net10.0` conforme `minimal-api.csproj`.
- Para usar o provedor MySQL com EF Core configure a `ConnectionString` no local apropriado e execute migrações via `dotnet ef` se necessário.
- Se `dotnet watch` não for reconhecido em uma sessão, verifique se `%USERPROFILE%\\.dotnet\\tools` está no `PATH` ou instale a ferramenta globalmente:

```powershell
dotnet tool install --global dotnet-watch
```

--

Se quiser, eu adiciono uma seção com comandos de migração do EF Core ou configuro entradas `<Watch>` no `.csproj` para forçar observação de arquivos adicionais.
