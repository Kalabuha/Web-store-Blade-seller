using Entities.StoreObjects;

namespace Entities.Goods
{
    public abstract class GoodEntity : StoreEntity
    {
        public int Price { get; set; }
        public string ProductCode { get; set; } = default!;
        public byte[] Image { get; set; } = default!;
        public string ProducingCompany { get; set; } = default!;
        public string? ProducingCountry { get; set; }
        public int? IdProductReview { get; set; }
    }
}
