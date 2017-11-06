using AutoMapper;
using Microsoft.EntityFrameworkCore.Infrastructure;
using StackExchange.Redis;
using vega.Controllers.Resources;

using vegaAttempt.Models;
using VegaAttempt.Models;

namespace vega.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelSource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}