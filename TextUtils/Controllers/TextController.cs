using Microsoft.AspNetCore.Mvc;
using TextUtils.Models;

namespace TextUtils.Controllers
{
    public class TextController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new TextModel());
        }

      [HttpPost]
public IActionResult ProcessText(TextModel model, string action)
{
    if (ModelState.IsValid)
    {
        if (action == "correct")
        {
            model.OutputText = FormatText(model.InputText);
        }
        else if (action == "stop")
        {
            model.OutputText = "Text processing stopped by user.";
        }
        return View("Index", model);
    }
    return View("Index", model);
}


        private string FormatText(string inputText)
        {
            // Simple example of processing logic: removing extra spaces
            var processedText = inputText.Replace("\n", " ").Replace("\t", " ");
            processedText = System.Text.RegularExpressions.Regex.Replace(processedText, @"\s+", " ");
            return processedText.Trim();
        }
    }
}
