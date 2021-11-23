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
    public class EnderecoController : ControllerBase
    {
        private EnderecoService _enderecoService;

        public EnderecoController(EnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost]
        public IActionResult AdicionaEndereco([FromBody] CreateEnderecoDto enderecoDto)
        {
            ReadEnderecoDto readEnderecoDto = _enderecoService.AdicionaEndereco(enderecoDto);
            return CreatedAtAction(nameof(RecuperaEnderecosPorId), new { Id = readEnderecoDto.Id }, readEnderecoDto);
        }

        [HttpGet]
        public IEnumerable<Endereco> RecuperaEnderecos()
        {
            return _enderecoService.RecuperaEnderecos();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEnderecosPorId(int id)
        {
            ReadEnderecoDto readEnderecoDto = _enderecoService.RecuperaEnderecosPorId(id);

            if (readEnderecoDto != null)
            {
                return Ok(readEnderecoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
        {
            UpdateEnderecoDto updateEnderecoDto = _enderecoService.AtualizaEndereco(id, enderecoDto);

            if (updateEnderecoDto == null)
            {
                return NotFound();
            }
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id)
        {
            bool wasEnderecoDeleted = _enderecoService.DeletaEndereco(id);

            if (wasEnderecoDeleted == false)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}