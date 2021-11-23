using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Gerente;
using FilmesAPI.Models;
using FilmesAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        private GerenteService _gerenteService;

        public GerenteController(GerenteService gerenteService)
        {
            _gerenteService = gerenteService;
        }

        [HttpPost]
        public IActionResult AdicionaGerente(CreateGerenteDto dto)
        {
            ReadGerenteDto readGerenteDto = _gerenteService.AdicionaGerente(dto);
            return CreatedAtAction(nameof(RecuperaGerentesPorId), new { id = readGerenteDto.Id }, readGerenteDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentesPorId(int id)
        {
            ReadGerenteDto readGerenteDto = _gerenteService.RecuperaGerentesPorId(id);

            if (readGerenteDto != null)
            {
                return Ok(readGerenteDto);
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaGerentePorId(int id)
        {
            bool wasGerenteDeleted = _gerenteService.DeletaGerentePorId(id);

            if (wasGerenteDeleted == false)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
