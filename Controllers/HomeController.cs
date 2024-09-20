using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using anchorman_se.Models;
using Strife.Binding;

namespace anchorman_se.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index([FromContentRoute] Home content)
    {
        return View(content);
    }
}