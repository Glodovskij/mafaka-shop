using AutoMapper;
using Mafaka.Services.ProductAPI.Domain;
using Mafaka.Services.ProductAPI.Domain.Dto;
using System.Reflection.Metadata.Ecma335;

namespace Mafaka.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
