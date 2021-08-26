using AutoMapper;
using BIBLIOTECA.Domain.Entities;
using BIBLIOTECA.Domain.Dtos;

namespace BIBLIOTECA.Domain.AutoMapper
{
    public class BookMapper : Profile
    {
        public BookMapper()
        {
            CreateMap<Book, BookDto>()
                .ReverseMap();
        }
    }
}
