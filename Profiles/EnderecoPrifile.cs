using Estudo_API_NET6.Data.DTOs;
using Estudo_API_NET6.Models;
using AutoMapper;

namespace Estudo_API_NET6.Profiles;

public class EnderecoProfile : Profile
{
    public EnderecoProfile()
    {   
        CreateMap<CreateEnderecoDto, Endereco>();
        CreateMap<Endereco, ReadEnderecoDto>();
        CreateMap<UpdateEnderecoDto, Endereco>();
    }
}