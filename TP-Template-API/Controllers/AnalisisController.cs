using Microsoft.AspNetCore.Mvc;
using System;
using TP_Application.Services;
using TP_Domain.DTOs;

namespace TP_Template_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalisisController : ControllerBase
    {
        private readonly IAnalisisService _service;

        public AnalisisController(IAnalisisService service)
        {
            _service = service;
        }


        [HttpPost]
        public IActionResult Post(AnalisisDto analisis)
        {
            try
            {
                return new JsonResult(_service.CreateAnalisis(analisis)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }

}
