using ApiAndDatabase.Entities;
using AutoMapper;

namespace ApiAndDatabase.AutoMapping
{
    public class AutoMapperMappingException :Profile
    {
         public AutoMapperMappingException()
        {
          CreateMap<Books, ModelApiBook>().ReverseMap();
            CreateMap<Cart, ModelApiCart>().ReverseMap();

        }

    }
}
