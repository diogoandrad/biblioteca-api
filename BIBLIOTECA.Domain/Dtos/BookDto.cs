using System;

namespace BIBLIOTECA.Domain.Dtos
{
    public class BookDto
    {
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public double Version { get; set; }
        public string Authors { get; set; }
    }
}
