﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP_AccessData;
using TP_Application.Services;
using TP_Domain.DTOs;
using TP_Domain.Entities;

namespace TP_Template_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriaClinicasController : ControllerBase
    {
        private readonly IHistoriaClinicaService _service;

        public HistoriaClinicasController(IHistoriaClinicaService service)
        {
            _service = service;
        }

        // GET: api/HistoriaClinicas
        [HttpGet]
        public IActionResult GetByPacienteId(int pacienteid)
        {

            HistoriaClinicaResponseDto hhcc = _service.GetByPacienteId(pacienteid);
            if (hhcc != null)
            {
                return new JsonResult(hhcc) { StatusCode = 200 };
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPost]
        public IActionResult Post(HistoriaClinicaDto historiaclinica)
        {
            try
            {
                return new JsonResult(_service.CreateHistoriaClinica(historiaclinica)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }







}