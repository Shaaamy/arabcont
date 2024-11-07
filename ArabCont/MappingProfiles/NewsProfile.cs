using ArabCont.DAL.Models;
using ArabCont.PL.ViewModels;
using AutoMapper;

namespace ArabCont.PL.MappingProfiles
{
    public class NewsProfile : Profile
    {
        public NewsProfile()
        {
            CreateMap<NewsViewModel,News>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
