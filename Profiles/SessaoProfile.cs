using Estudo_API_NET6.Data.DTOs;
using Estudo_API_NET6.Models;
using AutoMapper;

namespace Estudo_API_NET6.Profiles;

public class SessaoProfile : Profile
{
    public SessaoProfile()
    {   
        CreateMap<CreateSessaoDto, Sessao>();
        CreateMap<Sessao, ReadSessaoDto>()
        .ForMember(sessaoDto => sessaoDto.Filme,
                    opt => opt.MapFrom(sessao => sessao.Filme))
        .ForMember(sessaoDto => sessaoDto.Cinema,
                    opt => opt.MapFrom(sessao => sessao.Cinema));
    }
}