using Estudo_API_NET6.Data.DTOs;
using Estudo_API_NET6.Models;
using AutoMapper;

namespace Estudo_API_NET6.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {   
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
    }
}