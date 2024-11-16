using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pedidosPizza.DTOs;
using pedidosPizza.Service;

namespace pedidosPizza.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngredienteController : Controller
    {
        private readonly IIngredienteService _ingredienteService;

        public IngredienteController(IIngredienteService ingredienteService)
        {
            _ingredienteService = ingredienteService;
        }
         
        [HttpPost("create")]
        public IActionResult CreateIngrediente([FromBody] IngredienteDto ingredienteDto)
        {
            if (ingredienteDto == null)
                return BadRequest(new ApiResponseDto(false, "Datos de ingrediente inválidos"));

            try
            {
                _ingredienteService.CreateIngrediente(ingredienteDto);
                return Ok(new ApiResponseDto(true, "Ingrediente creado exitosamente"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto(false, "Error interno: " + ex.Message));
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetIngredienteById(int id)
        {
            var ingrediente = _ingredienteService.GetIngredienteById(id);
            if (ingrediente == null)
                return NotFound(new ApiResponseDto(false, "Ingrediente no encontrado"));

            return Ok(ingrediente);
        }

        [HttpGet]
        public IActionResult GetAllIngredientes()
        {
            var ingredientes = _ingredienteService.GetAllIngredientes();
            return Ok(ingredientes);
        }
    }
}
