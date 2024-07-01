using AutoMapper;
using KursProject.DtoLayer.AboutDto;
using KursProject.EntityLayer.Entities;
using KursProjectWebUI.Dtos.CreateAboutDto;

namespace KursProjectApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
