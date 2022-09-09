namespace INVENTORY.SHARED.Dto
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
