using AutoMapper;
using Example.Features.DtoModels.Center;
using Example.Storage.Models;

namespace Example.Features.Mappers
{
    public class CenterMapper : Profile
    {
        public CenterMapper()
        {
            CreateMap<Center, EditCenter>()
                .ForMember(x => x.IsnNode, o => o.MapFrom(x => x.IsnNode));

            CreateMap<EditCenter, Center>();
        }
    }
}
