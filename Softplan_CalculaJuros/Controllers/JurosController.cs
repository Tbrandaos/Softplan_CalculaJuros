using Microsoft.AspNetCore.Mvc;
using Softplan_CalculaJuros.Services.JurosService.cs;
using System;

namespace Softplan_CalculaJuros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        private readonly IJurosService JurosService;

        public JurosController(IJurosService jurosService)
        {
            JurosService = jurosService;
        }

        [HttpGet("calculaJuros")]
        public IActionResult GetJuros(double valorinicial, int meses)
        {
            try
            {
                return Ok(JurosService.CalculaJuros(valorinicial, meses));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
