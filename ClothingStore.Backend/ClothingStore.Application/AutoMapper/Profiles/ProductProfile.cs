using AutoMapper;
using ClothingStore.Application.Responses;
using ClothingStore.Domain;

namespace ClothingStore.Application.AutoMapper.Profiles;

internal class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, GetProductResponse>()
            .ForMember(productResponse => productResponse.ProductId,
                product => product.MapFrom(i => i.ProductId))
            .ForMember(productResponse => productResponse.ProductName,
                product => product.MapFrom(i => i.ProductName))
            .ForMember(productResponse => productResponse.Image,
                product => product.MapFrom(i => i.Image))
            .ForMember(productResponse => productResponse.Price,
                product => product.MapFrom(i => i.Price))
            .ForMember(productResponse => productResponse.BrandName,
                product => product.MapFrom(i => i.Brand.BrandName))
            .ForMember(productResponse => productResponse.UserName,
                product => product.MapFrom(i => i.User.UserName));

        CreateMap<Product, GetProductDetailsResponse>()
            .ForMember(productDetailResponse => productDetailResponse.ProductId,
                product => product.MapFrom(i => i.ProductId))
            .ForMember(productDetailResponse => productDetailResponse.ProductName,
                product => product.MapFrom(i => i.ProductName))
            .ForMember(productDetailResponse => productDetailResponse.Image,
                product => product.MapFrom(i => i.Image))
            .ForMember(productDetailResponse => productDetailResponse.Price,
                product => product.MapFrom(i => i.Price))
            .ForMember(productDetailResponse => productDetailResponse.BrandName,
                product => product.MapFrom(i => i.Brand.BrandName))
            .ForMember(productDetailResponse => productDetailResponse.UserName,
                product => product.MapFrom(i => i.User.UserName))
            .ForMember(productDetailResponse => productDetailResponse.PhoneNumber,
                product => product.MapFrom(i => i.User.PhoneNumber))
            .ForMember(productDetailResponse => productDetailResponse.GenderName,
                product => product.MapFrom(i => i.Gender.GenderName))
            .ForMember(productDetailResponse => productDetailResponse.SeasonNames,
                product => product.MapFrom(i => i.Seasons.Select(x => x.SeasonName)))
            .ForMember(productDetailResponse => productDetailResponse.ColorNames,
                product => product.MapFrom(i => i.Colors.Select(x => x.ColorName)));
    }
}