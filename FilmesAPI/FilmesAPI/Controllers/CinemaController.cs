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
    public class CinemaController : ControllerBase
    {
        private CinemaService _cinemaService;

        public CinemaController(CinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        [HttpPost]
        public IActionResult AdicionaCinema([FromBody] CreateCinemaDto cinemaDto)
        {
            ReadCinemaDto readCinemaDto = _cinemaService.AdicionaCinema(cinemaDto);
            return CreatedAtAction(nameof(RecuperarCinemasPorId), new { id = readCinemaDto.Id }, readCinemaDto);
        }

        [HttpGet]
        public IEnumerable<Cinema> RecuperaCinemas([FromQuery] string nomeDoFilme)
        {
            return _cinemaService.RecuperaCinemas();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarCinemasPorId(int id)
        {
            ReadCinemaDto readCinemaDto = _cinemaService.RecuperarCinemasPorId(id);
            if (readCinemaDto != null)
            {
                return Ok(readCinemaDto);
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
        {
            UpdateCinemaDto updateCinemaDto = _cinemaService.AtualizaCinema(id, cinemaDto);
            if (updateCinemaDto == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaCinema(int id)
        {
            bool wasCinemaDeleted = _cinemaService.DeletaCinema(id);
            if (wasCinemaDeleted == false)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
