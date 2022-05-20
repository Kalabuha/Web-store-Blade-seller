using Entities.Base;

namespace Entities.StoreObjects.Catalog
{
    public class CatalogEntity : StoreEntity
    {
        public int GoodType { get; set; }
        public int? IdSubCatalog { get; set; }
        public int? AmountSubCatalog { get; set; }
    }
}
