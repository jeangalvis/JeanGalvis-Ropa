namespace Domain.Entities;
    public class InventarioTalla : BaseEntity
    {
        public int IdInventariofk { get; set; }
        public Inventario Inventario { get; set; }
        public int IdTallafk { get; set; }
        public Talla Talla { get; set; }
        public int Cantidad { get; set; }
    }
