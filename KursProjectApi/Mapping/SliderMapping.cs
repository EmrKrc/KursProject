using AutoMapper;
using KursProject.DtoLayer.SliderDto;
using KursProject.EntityLayer.Entities;

namespace KursProjectApi.Mapping
{
    public class SliderMapping:Profile
    {
        public SliderMapping()
        {
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
        }
    }
}
