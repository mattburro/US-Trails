using AutoMapper;
using USTrails.API.Models.Domain;
using USTrails.API.Models.DTO;

namespace USTrails.API.Mappings
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<State, StateDto>().ReverseMap();
            CreateMap<AddStateRequestDto, State>();
            CreateMap<UpdateStateRequestDto, State>();
        }
    }
}
