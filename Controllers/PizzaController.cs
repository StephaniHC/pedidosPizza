using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pedidosPizza.DTOs;
using pedidosPizza.Service;

namespace pedidosPizza.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : Controller
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpPost("create")]
        public IActionResult CreatePizza([FromBody] PizzaDto pizzaDto)
        {
            if (pizzaDto == null)
                return BadRequest(new ApiResponseDto(false, "Datos de pizza inválidos"));

            try
            {
                _pizzaService.CreatePizza(pizzaDto);
                return Ok(new ApiResponseDto(true, "Pizza creada exitosamente"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto(false, "Error interno: " + ex.Message));
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetPizzaById(int id)
        {
            var pizza = _pizzaService.GetPizzaById(id);
            if (pizza == null)
                return NotFound(new ApiResponseDto(false, "Pizza no encontrada"));

            return Ok(pizza);
        }

        [HttpGet]
        public IActionResult GetAllPizzas()
        {
            var pizzas = _pizzaService.GetAllPizzas();
            return Ok(pizzas);
        }
    }
}
