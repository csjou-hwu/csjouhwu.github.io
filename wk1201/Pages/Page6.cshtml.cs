﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace wk1201.Pages
{
    public class Page6Model : PageModel
    {
        private readonly ILogger<Page6Model> _logger;

        public Page6Model(ILogger<Page6Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
