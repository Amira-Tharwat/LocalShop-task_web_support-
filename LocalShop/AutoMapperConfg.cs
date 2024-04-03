using AutoMapper;
using LocalShop.Migrations;
using LocalShop.Models.DTO;

namespace LocalShop
{
    public class AutoMapperConfg:Profile
    {
        public AutoMapperConfg()
        { 
            CreateMap<product,ProductDTO>().ReverseMap();
            CreateMap<BlogDTO,BlogDTO>().ReverseMap();
        }
    }
}
