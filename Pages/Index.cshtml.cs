using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperStronaLukasz.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Parallel.For(0, 100,
          (i) => _logger.LogWarning($"Dupa {i}"));
        _logger.LogWarning($"Dupa");
    }
}
