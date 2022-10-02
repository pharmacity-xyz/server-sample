using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController() { }

    // GET all action
    [HttpGet]
    public ActionResult<List<PizzaModel>> GetAll() =>
        PizzaService.GetAll();

    // GET by id action

    // POST action

    // PUT action

    // DELETE action
}