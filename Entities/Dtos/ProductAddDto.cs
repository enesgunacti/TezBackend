using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Entities.Dtos
{
    public class ProductAddDto : IDto
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        //public string ProductPicture { get; set; }
        public IFormFile ProductFile { get; set; }
        public int CategoryId { get; set; }
    }
}