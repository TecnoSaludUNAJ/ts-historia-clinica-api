using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using TP_Application.Services;
using TP_Domain.DTOs;

namespace TP_Template_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrosController : ControllerBase
    {
        private readonly IRegistroService _service;

        public RegistrosController(IRegistroService service)
        {
            _service = service;
        }

        [HttpPost]
        //[Authorize]
        public IActionResult Post(RegistroDTO registro)
        {
            try
            {
                return new JsonResult(_service.CreateRegistro(registro)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }

}
