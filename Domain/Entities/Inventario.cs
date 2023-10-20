namespace Domain.Entities;
    public class Inventario : BaseEntity
    {
        public string CodInv { get; set; }
        public int IdPrendafk { get; set; }
        public Prenda Prenda { get; set; }
        public decimal ValorVtaCop { get; set; }
        public decimal ValorVtaUsd { get; set; }
        public ICollection<DetalleVenta> DetalleVentas { get; set; }
        public ICollection<InventarioTalla> InventarioTallas { get; set; }
    }
