using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WifiRadioSignalR.Pages
{
    public class PeopleView : PageModel
    {
        private readonly ILogger<PeopleView> _logger;

        public PeopleView(ILogger<PeopleView> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}