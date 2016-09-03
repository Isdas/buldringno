using AutoMapper;
using BuldringNo.Entities;
using BuldringNo.ViewModels;
using System.Linq;

namespace BuldringNo.Infrastructure.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Problem, ProblemViewModel>()
               .ForMember(vm => vm.Uri, map => map.MapFrom(p => "/images/" + p.Uri));

            Mapper.CreateMap<Boulder, BoulderViewModel>()
                .ForMember(vm => vm.TotalProblems, map => map.MapFrom(a => a.Problems.Count))
                .ForMember(vm => vm.Thumbnail, map => 
                    map.MapFrom(a => (a.Problems != null && a.Problems.Count > 0) ?
                    "/images/" + a.Problems.First().Uri :
                    "/images/thumbnail-default.png"));
        }
    }
}
