using AutoMapper;
using communitybuilderapi.DataModel;
using communitybuilderapi.Dtos.BusinessDtos;
using communitybuilderapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Helpers
{
    public class AutoMapperDto : Profile
    {
        public AutoMapperDto()
        {
            //CreateMap<Event, EventDto>().ReverseMap();
            //CreateMap<Models.Business, BusinessDto>().ReverseMap();
            //CreateMap<Fan, FanDto>().ReverseMap();
            //CreateMap<Languages, LanguageDto>().ReverseMap();
            //CreateMap<LanguageLocalization, LanguageLocalizationDto>().ReverseMap();
            //CreateMap<GenericLocalizationKeyValues, GenericLocalizationKeyValuesDto>().ReverseMap();
            //CreateMap<Site, SiteDto>().ReverseMap();
            //CreateMap<LocalBusinessCard, LocalBusinessCardDto>().ReverseMap();
            //CreateMap<SiteHeader, SiteHeaders>().ReverseMap();
            //CreateMap<CustomCss, CustomCssDto>().ReverseMap();
            //CreateMap<BusinessDetail, BusinessDetailDto>().ReverseMap();
            //CreateMap<BusinessGrid, BusinessGridDto>().ReverseMap();
            //CreateMap<BusinessNameModel, BusinessNameDto>().ReverseMap();
            //CreateMap<SliderItem, SliderItemDto>().ReverseMap();
            //CreateMap<File, FileDto>().ReverseMap();
            CreateMap<List<business>, List<BusinessGridDto>>().ReverseMap();

            CreateMap<business_address, BusinessGridDto>()
               .ForMember(d => d.BusinessId, opt => opt.MapFrom(s => s.id_business))
               .ForMember(d => d.BusinessName, opt => opt.MapFrom(s => s.business.name))
               .ForMember(d => d.BusinessAddress, opt => opt.MapFrom(s => s.address.address1))
               .ForMember(d => d.BusinessTelephone, opt => opt.MapFrom(s => s.address.telephone1))
               .ForMember(d => d.BusinessEmail, opt => opt.MapFrom(s => s.address.email))
               .ForMember(d => d.BusinessComment, opt => opt.MapFrom(s => s.business.internal_comments));

        }
    }
}
