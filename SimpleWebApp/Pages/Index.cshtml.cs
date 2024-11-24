using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace SimpleWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<IndexModel> _logger;

        public readonly string ImageVersion = string.Empty;
        public readonly string Environment = string.Empty;
        public readonly string HostName = string.Empty;

        public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger)
        {
            this._configuration = configuration;
            _logger = logger;
            ImageVersion = this._configuration.GetValue<string>("GIT_HASH") ?? string.Empty;
            Environment = this._configuration.GetValue<string>("ASPNETCORE_ENVIRONMENT") ?? string.Empty;
            HostName = this._configuration.GetValue<string>("WEBSITE_HOSTNAME") ?? string.Empty;
        }

        public void OnGet()
        {

        }
    }
}

