namespace Entities.Goods.Knives
{
    public abstract class KnifeEntity : GoodEntity
    {
        public byte BladeFixation { get; set; }
        public byte KnifeStyle { get; set; }
        public byte BladeShape { get; set; }
        public byte BladeMaterial { get; set; }
        public byte HandleMaterial { get; set; }
        public int BladeLength { get; set; }
        public int BladeThickness { get; set; }
        public int TotalLength { get; set; }
    }
}
