namespace Domain.Entities;
    public class Prenda : BaseEntity
    {
        public int IdPrenda { get; set; }
        public string Nombre { get; set; }
        public decimal ValorUnitCop { get; set; }
        public decimal ValorUnitUsd { get; set; }
        public int IdEstadofk { get; set; }
        public Estado Estado { get; set; }
        public int IdTipoProteccionfk { get; set; }
        public TipoProteccion TipoProteccion { get; set; }
        public int IdGenerofk { get; set; }
        public Genero Genero { get; set; }
        public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
        public ICollection<Inventario> Inventarios { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
    }
