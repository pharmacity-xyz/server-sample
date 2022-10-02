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
    public ActionResult<List<PizzaModel>> GetAll()
    {
        return PizzaService.GetAll();
    }

    // GET by id action
    [HttpGet("{id}")]
    public ActionResult<PizzaModel> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if (pizza == null)
        {
            return NotFound();
        }

        return pizza;
    }

    // POST action

    // PUT action

    // DELETE action
}