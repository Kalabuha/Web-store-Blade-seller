using Entities.StoreObjects;

namespace Entities.Goods.Knives.Materials
{
    public abstract class MaterialEntity : StoreEntity
    {
        public bool Premium { get; set; } = false;
    }
}
