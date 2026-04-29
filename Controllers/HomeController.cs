using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP01.Models;

namespace TP01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Grupo grupo = new Grupo();
        Dictionary<int, Integrante> Integrantes;
        Integrantes = grupo.DevolverIntegrantes();
        ViewBag.Integrantes = Integrantes;
        return View();
    }

    public IActionResult infoIntegrante(int dni) 
    {
        Grupo grupo = new Grupo();
        Integrante integrante = grupo.GetIntegrante(dni);
        if(integrante != null)
        {
            ViewBag.Integrante = integrante;
            ViewBag.Dni = dni;
            return View("infoIntegrante");
        }
        else
        {
            return RedirectToAction("NoEncontrado");
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
