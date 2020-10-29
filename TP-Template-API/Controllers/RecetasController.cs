using Microsoft.AspNetCore.Mvc;
using System;
using TP_Application.Services;
using TP_Domain.DTOs;

namespace TP_Template_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetasController : ControllerBase
    {
        private readonly IRecetaService _service;

        public RecetasController(IRecetaService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post(RecetaDto receta)
        {
            try
            {
                return new JsonResult(_service.CreateReceta(receta)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }

}