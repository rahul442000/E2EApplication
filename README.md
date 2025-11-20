# E2EApplication

E2EApplication is a minimal ASP.NET Core Web API sample demonstrating a simple Book model and an in-memory collection of sample data. It's intended for end-to-end experiments, quick API prototypes, and learning.

Maintainer: Rahul442000 (GitHub: @Rahul442000)  
Contact: rahulsoni4420000@gmail.com

## Table of Contents
- [Project structure](#project-structure)
- [Prerequisites](#prerequisites)
- [Run (Visual Studio)](#run-visual-studio)
- [Run (CLI)](#run-cli)
- [API overview](#api-overview)
- [Examples](#examples)
- [Testing & CI](#testing--ci)
- [Contributing](#contributing)
- [Pull Request checklist](#pull-request-checklist)
- [Code of Conduct](#code-of-conduct)
- [License](#license)
- [Maintainers / Contact](#maintainers--contact)

## Project structure
- Models/Book.cs — Book model (Id, Title, Author, yearPublished)  
- Controllers/BooksController.cs — contains an in-memory sample list of books  
- Properties/, obj/, bin/ — standard .NET project folders

## Prerequisites
- .NET 9 SDK  
- Visual Studio 2022 (recommended) or any editor that supports .NET 9 and C# 13  
- Optional: curl, Postman, or another HTTP client

## Run (Visual Studio)
1. Open the solution in Visual Studio 2022.  
2. Set the startup project to `E2EApplication`.  
3. Start debugging with __F5__ (or run without debugging via __Debug > Start Without Debugging__ / __Ctrl+F5__).  
4. The application displays listening addresses in the Output window (see __launchSettings.json__ for overrides).

## Run (CLI)
From repository root:
- dotnet run --project E2EApplication

Check the console output for the exact listening addresses.

## API overview
- Route base: /api/[controller]  
- Current sample controller: `Controllers/BooksController.cs` — contains an in-memory `List<Book>` for demo data. Add GET/POST/PUT/DELETE actions to expose endpoints.

Example Book JSON:
{
  "id": 1,
  "title": "1984",
  "author": "George Orwell",
  "yearPublished": "1949"
}

## Examples
Assuming a GET endpoint at /api/books:
- curl http://localhost:5000/api/books  
- curl https://localhost:5001/api/books --insecure

## Testing & CI
- Unit tests: xUnit, NUnit, or MSTest.  
- Integration/E2E tests: Microsoft.AspNetCore.Mvc.Testing with WebApplicationFactory or TestServer.  
- Recommended CI: GitHub Actions or Azure Pipelines to run build + tests on PRs.

## Contributing
Thank you for contributing. Please follow these guidelines:

1. Discuss first  
   - Open an issue for non-trivial features or breaking changes before implementing.  

2. Branching  
   - Create a feature branch from `main`.  
   - Use names like `feature/<short-desc>`, `fix/<short-desc>`, `docs/<short-desc>`.

3. Commits  
   - Use concise, descriptive messages. Conventional Commits are recommended (feat:, fix:, docs:, chore:, etc.).  
   - Example: `feat(api): add GET /api/books`

4. Pull requests  
   - Open PRs against `main`.  
   - Include what changed, why, and how to validate. Add sample curl commands where applicable.  
   - Ensure tests pass locally.

5. Code style & review  
   - Follow repository C# conventions. Keep methods focused and test business logic.

6. Security & sensitive data  
   - Do not commit secrets. For security vulnerabilities, contact the maintainer privately.

## Pull Request checklist
- [ ] Code builds and compiles  
- [ ] Tests added/updated and pass  
- [ ] Code formatted per project conventions  
- [ ] Documentation updated where relevant  
- [ ] No sensitive data in commits

## Code of Conduct
Be respectful and constructive. Consider adding a __CODE_OF_CONDUCT.md__ to formalize expectations. Report unacceptable behavior to the maintainers.

## License
This project is licensed under the MIT License. The full license is provided in the repository `LICENSE` file.

## Maintainers / Contact
- Rahul442000 — primary maintainer  
- Email: rahulsoni4420000@gmail.com