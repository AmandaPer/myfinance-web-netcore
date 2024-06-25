using System.ComponentModel;
using System.Diagnostics;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_dotnet.Infrastructure;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Services;

namespace myfinance_web_netcore.Controllers;

[Route("[controller]")]
public class PlanoContaController : Controller
{
    
    private readonly ILogger<PlanoContaController> _logger;
    private readonly IPlanoContaService _planoContaService;

    public PlanoContaController(
        ILogger<PlanoContaController> logger,
        IPlanoContaService planoContaService)
    {
        _logger = logger;
        _planoContaService = planoContaService;
    }

    public IActionResult Index()
    {
        var lista = _planoContaService.ListaRegistros();
        ViewBag.ListaPlanoConta = lista;
        return View();
    }

    [HttpPost]
    [Route("Cadastro")]

    public IActionResult Cadastro(PlanoContaModel model)
    {
        _planoContaService.Salvar(model);
        return View();
    }

    [HttpGet]
    [Route("Cadastro")]
    [Route("Cadastro/{id}")]

    public IActionResult Cadastro(int? id)
    {
        if(id!= null){
            var registro = _planoContaService.RetornarRegistro((int) id);
            return View(registro);
        }
        
        return View();
    }

    [HttpGet]
    [Route("Excluir/{id}")]

    public IActionResult Excluir(int id)
    {
        _planoContaService.Excluir(id);
        return RedirectToAction("index");
    }

}
