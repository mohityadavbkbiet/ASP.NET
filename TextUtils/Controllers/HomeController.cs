using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TextUtils.Models;

namespace TextUtils.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // Pass an empty instance of TextModel to avoid null reference issues in the view
        var model = new TextModel();
        return View(model);
    }

    [HttpPost]
    public IActionResult ProcessText(TextModel model, string action)
    {
        if (ModelState.IsValid)
        {
            if (action == "correct")
            {
                model.OutputText = FormatText(model.InputText); // Example formatting method
            }
            else if (action == "stop")
            {
                model.OutputText = "Text processing stopped by user.";
            }
        }
        return View("Index", model);
    }
    
    private string FormatText(string inputText)
    {
        // Simple example formatting function
        return inputText?.ToUpper(); // Modify this according to your formatting requirements
    }
}

