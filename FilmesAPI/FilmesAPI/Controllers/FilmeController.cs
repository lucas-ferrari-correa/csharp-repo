using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
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
    public class FilmeController : ControllerBase
    {
        private FilmeService _filmeService;

        public FilmeController(FilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
        {
            ReadFilmeDto readFilmeDto = _filmeService.AdicionaFilme(filmeDto);
            return CreatedAtAction(nameof(RecuperaFilmesPorId), new { id = readFilmeDto.Id }, readFilmeDto);
        }

        [HttpGet]
        public IActionResult RecuperaFilmes([FromQuery] int? classificacaoEtaria = null)
        {
            List<ReadFilmeDto> readFilmeDto = _filmeService.RecuperaFilmes(classificacaoEtaria);

            if (readFilmeDto != null)
            {
                return Ok(readFilmeDto);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmesPorId(int id)
        {
            ReadFilmeDto readFilmeDto = _filmeService.RecuperaFilmesPorId(id);

            if (readFilmeDto != null)
            {
                return Ok(readFilmeDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
        {
            UpdateFilmeDto updateFilmeDto = _filmeService.AtualizaFilme(id, filmeDto);
            if (updateFilmeDto != null)
            {
                return NoContent();
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaFilmePorId(int id)
        {
            Filme filme = _filmeService.DeletaFilmePorId(id);

            if (filme == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
