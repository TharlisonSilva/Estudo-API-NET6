using Estudo_API_NET6.Data.DTOs;
using Estudo_API_NET6.Models;
using AutoMapper;

namespace Estudo_API_NET6.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {   
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<UpdateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>();
            //.ForMember(cinemaDto => cinemaDto.Endereco,
            //        opt => opt.MapFrom(cinema => cinema.Endereco))
            //.ForMember(cinemaDto => cinemaDto.Sessoes,
            //        opt => opt.MapFrom(cinema => cinema.Sessoes));
    }
}