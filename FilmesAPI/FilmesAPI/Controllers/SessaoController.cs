using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Sessao;
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
    public class SessaoController : ControllerBase
    {
        private SessaoService _sessaoService;

        public SessaoController(SessaoService sessaoService)
        {
            _sessaoService = sessaoService;
        }

        [HttpPost]
        public IActionResult AdicionaSessao([FromBody] CreateSessaoDto dto)
        {
            ReadSessaoDto readSessaoDto = _sessaoService.AdicionaSessao(dto);

            return CreatedAtAction(nameof(RecuperaSessoesPorId), new { id = readSessaoDto.Id }, readSessaoDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessoesPorId(int id)
        {
            ReadSessaoDto readSessaoDto = _sessaoService.RecuperaSessoesPorId(id);

            if (readSessaoDto != null)
            {
                return Ok(readSessaoDto);
            }

            return NotFound();
        }
    }
}
