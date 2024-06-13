using Adp.Test.Api.Models;
using Adp.Test.Core.Entities;

using AutoMapper;

namespace Adp.Test.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
