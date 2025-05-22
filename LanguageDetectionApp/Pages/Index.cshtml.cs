using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Azure;
using Azure.AI.TextAnalytics;


namespace LanguageDetectionApp.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string UserText { get; set; }
    private readonly TextAnalyticsClient textAnalyticsClient;
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        var endPoint = configuration["AzureAI:Endpoint"];
        var apiKey = configuration["AzureAI:ApiKey"];

        var credential = new AzureKeyCredential(apiKey);

        textAnalyticsClient = new TextAnalyticsClient(new Uri(endPoint), credential);
    }

    public void OnPost()
    {
        if (string.IsNullOrEmpty(UserText))
        {
            ViewData["DetectedLanguage"] = "Please enter the text to detect the language";

            return;
        }

        var response = textAnalyticsClient.DetectLanguage(UserText);
        ViewData["DetectedLanguage"] = response.Value.Name;
    }

    public void OnGet()
    {

    }
}
