using AutoMapper;
using Core.Models.Entities.Albums;
using Presentation.Api.Dtos.Albums;

namespace Presentation.Api.MappingProfiles
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
            CreateMap<Album, AlbumDto>().ReverseMap();
        }
    }
}
