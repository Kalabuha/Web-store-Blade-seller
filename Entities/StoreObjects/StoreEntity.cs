using Entities.Base;

namespace Entities.StoreObjects
{
    public abstract class StoreEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
