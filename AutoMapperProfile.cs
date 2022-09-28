using AutoMapper;
using Enums.DTOs;
using Enums.Models;
using Enums.Services;

namespace Enums
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Ticket, GetTicketDto>()
                .ForMember(
                    dest => dest.StatusDisplay,
                    opt => opt.MapFrom
                    (
                        src => src.Status.GetDescription()
                    )
                );
        }
    }
}
