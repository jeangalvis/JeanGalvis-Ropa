namespace Domain.Entities;
    public class DetalleVenta : BaseEntity
    {
        public int IdVentafk { get; set; }
        public Venta Venta { get; set; }
        public int IdInventariofk { get; set; }
        public Inventario Inventario { get; set; }
        public int IdTallafk { get; set; }
        public Talla Talla { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorUnit { get; set; }
    }
