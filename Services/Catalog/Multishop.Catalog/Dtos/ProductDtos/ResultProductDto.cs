namespace Multishop.Catalog.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProducImageUrl { get; set; } = string.Empty;
        public string ProducDescrition { get; set; } = string.Empty;
        public string CategoryId { get; set; } = string.Empty;
    }
}
