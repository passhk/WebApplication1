using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string sv = "333";
            string webService = "222";
            string webserv = "11";
            if (sv == "333")
            {
                if (webserv == "111")
                {
                    if (webserv == "22")
                    {
                        if (webserv == "222")
                        {
                            if (webserv == "222")
                            { 
                            
                            }
                        }
                    }
                }
            }

            while (true)
            { }
        }
    }
}
