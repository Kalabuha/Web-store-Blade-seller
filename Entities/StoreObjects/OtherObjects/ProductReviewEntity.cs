using Entities.Base;

namespace Entities.StoreObjects.OtherObjects
{
    public class ProductReviewEntity : IEntity, IDateTimeCreateSaveable
    {
        public int Id { get; set; }
        public int IdUserClient { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public string TextReview { get; set; } = default!;
        public byte ScoreReview { get; set; } = 5;
    }
}
