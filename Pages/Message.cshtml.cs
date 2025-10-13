using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ThirdTry.Pages
{
    public class MessageIndex : PageModel
    {

        [BindProperty]
        public string Message { get; set; } = string.Empty;

        public string DisplayMessage { get; set; } = string.Empty;

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            // Функция вывода текста
            if (!string.IsNullOrEmpty(Message))
            {
                DisplayMessage = Message;
            }
            else
            {
                DisplayMessage = "ничего :(";
            }

            return Page();
        }
    }
}