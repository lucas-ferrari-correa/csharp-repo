using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Services
{
    public class CinemaService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public CinemaService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadCinemaDto AdicionaCinema(CreateCinemaDto cinemaDto)
        {
            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
            
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();

            return _mapper.Map<ReadCinemaDto>(cinema);
        }

        public IEnumerable<Cinema> RecuperaCinemas()
        {
            return _context.Cinemas;
        }

        public ReadCinemaDto RecuperarCinemasPorId(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema != null)
            {
                ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
                return cinemaDto;
            }

            return null;
        }

        public UpdateCinemaDto AtualizaCinema(int id, UpdateCinemaDto cinemaDto)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null)
            {
                return null;
            }

            _mapper.Map(cinemaDto, cinema);
            _context.SaveChanges();

            return cinemaDto;
        }

        public bool DeletaCinema(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            
            if (cinema == null)
            {
                return false;
            }

            _context.Remove(cinema);
            _context.SaveChanges();

            return true;
        }
    }
}
