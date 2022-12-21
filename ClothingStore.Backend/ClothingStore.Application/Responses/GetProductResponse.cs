using ClothingStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Responses
{
    public class GetProductResponse
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public string UserName { get; set; }

        public string BrandName { get; set; }
    }
}
