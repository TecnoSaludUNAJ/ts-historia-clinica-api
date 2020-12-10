using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TP_Application.Services;
using TP_Domain.DTOs;

namespace TP_Template_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriaClinicaController : ControllerBase
    {
        private readonly IHistoriaClinicaService _service;

        public HistoriaClinicaController(IHistoriaClinicaService service)
        {
            _service = service;
        }

        // GET: api/HistoriaClinicas
        [HttpGet("{PacienteId?}")]
        [Authorize]
        public IActionResult GetByPacienteId(int PacienteId)
        {
            try
            {
                List<HistoriaClinicaResponseDto> hhcc = _service.GetHistoriaClinica(PacienteId);
                if (hhcc != null)
                {
                    return new JsonResult(hhcc) { StatusCode = 200 };
                }
                else throw new Exception();
            }
            catch
            {
                return NotFound();
            }               
        }
    }

}
