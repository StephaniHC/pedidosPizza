using Microsoft.AspNetCore.Mvc;
using pedidosPizza.DTOs;
using pedidosPizza.Service;

namespace pedidosPizza.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : Controller
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost("create")]
        public IActionResult CreatePedido([FromBody] PedidoDto pedidoDto)
        {
            if (pedidoDto == null)
                return BadRequest(new ApiResponseDto(false, "Pedido inválido"));

            try
            {
                _pedidoService.CreatePedido(pedidoDto);
                return Ok(new ApiResponseDto(true, "Pedido creado exitosamente"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto(false, "Error interno: " + ex.Message));
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetPedidoById(int id)
        {
            var pedido = _pedidoService.GetPedidoById(id);
            if (pedido == null)
                return NotFound(new ApiResponseDto(false, "Pedido no encontrado"));

            return Ok(pedido);
        }

        [HttpGet]
        public IActionResult GetAllPedidos()
        {
            var pedidos = _pedidoService.GetAllPedidos();
            return Ok(pedidos);
        }
    }
}