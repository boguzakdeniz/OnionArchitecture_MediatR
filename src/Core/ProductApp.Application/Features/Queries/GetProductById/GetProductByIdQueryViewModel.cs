namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQueryViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
