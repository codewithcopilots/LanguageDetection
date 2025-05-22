# LanguageDetectionApp

LanguageDetectionApp is an ASP.NET Core Razor Pages web application that detects the language of user-input text using Azure AI Text Analytics.

## Features

- **Language Detection:** Enter any text and instantly detect its language using Azure Cognitive Services.
- **Modern UI:** Clean, responsive interface styled with Bootstrap.
- **Azure Integration:** Uses Azure AI Text Analytics for accurate language detection.

## Project Structure

```
LanguageDetection.sln
LanguageDetectionApp/
  appsettings.json
  appsettings.Development.json
  LanguageDetectionApp.csproj
  Program.cs
  Pages/
    Index.cshtml
    Index.cshtml.cs
    Error.cshtml
    Error.cshtml.cs
    Shared/
      _Layout.cshtml
      _ValidationScriptsPartial.cshtml
    _ViewImports.cshtml
    _ViewStart.cshtml
  wwwroot/
    css/
      site.css
    js/
      site.js
    lib/
      bootstrap/
      jquery/
      jquery-validation/
      jquery-validation-unobtrusive/
  Properties/
```

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Azure Subscription](https://azure.microsoft.com/free/)
- Azure AI Text Analytics resource (for endpoint and API key)

## Required NuGet Packages

- `Azure.AI.TextAnalytics`
- `Microsoft.Extensions.Configuration`
- `Microsoft.Extensions.Logging`
- `Microsoft.AspNetCore.Mvc.RazorPages`

These are referenced in the project file ([LanguageDetectionApp.csproj](LanguageDetectionApp/LanguageDetectionApp.csproj)).

## Configuration

1. **Azure AI Credentials:**  
   Update the `AzureAI` section in [appsettings.json](LanguageDetectionApp/appsettings.json):

   ```json
   "AzureAI": {
     "Endpoint": "<your Azure endpoint>",
     "ApiKey": "<your Azure API key>"
   }
   ```

2. **Logging and Hosting:**  
   Adjust logging levels and allowed hosts as needed.

## How It Works

- The backend ([Pages/Index.cshtml.cs](LanguageDetectionApp/Pages/Index.cshtml.cs)) uses `TextAnalyticsClient` from Azure SDK.
- On form submission, the app calls Azure's language detection API and displays the detected language.

## How to Run

1. **Restore Packages:**
   ```sh
   dotnet restore
   ```

2. **Build the Project:**
   ```sh
   dotnet build
   ```

3. **Run the Application:**
   ```sh
   dotnet run --project LanguageDetectionApp
   ```

4. **Access the App:**  
   Open your browser and navigate to `https://localhost:5001` (or the URL shown in the terminal).

## Screenshots

> _Add screenshots of the UI here if desired._

## License

This project uses open-source libraries under the MIT License. See the `LICENSE` files in the `wwwroot/lib` subfolders for details.

---

**Azure Best Practices:**  
- Store secrets like API keys securely (consider using [Azure Key Vault](https://learn.microsoft.com/azure/key-vault/general/)).
- Use HTTPS in production.
- Restrict `AllowedHosts` in production environments.

---

**Contributions welcome!**
