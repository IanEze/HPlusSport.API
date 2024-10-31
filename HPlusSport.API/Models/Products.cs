using System.Text.Json.Serialization;
namespace HPlusSport.API.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int IsAvailable{ get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }



    }
}
