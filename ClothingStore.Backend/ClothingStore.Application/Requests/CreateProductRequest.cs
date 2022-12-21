using ClothingStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Requests
{
    public class CreateProductRequest
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public ICollection<string> SeasonNames { get; set; }
        public string GenderName { get; set; }

        public ICollection<string> ColorNames { get; set; }

        public string BrandName { get; set; }
    }
}
