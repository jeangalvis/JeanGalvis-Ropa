namespace Domain.Entities;
    public class DetalleOrden : BaseEntity
    {
        public int IdOrdenfk { get; set; }
        public Orden Orden { get; set; }
        public int IdPrendafk { get; set; }
        public Prenda Prenda { get; set; }
        public int CantidadProducir { get; set; }
        public int IdColorfk { get; set; }
        public Color Color { get; set; }
        public int CantidadProducida { get; set; }
        public int IdEstadofk { get; set; }
        public Estado Estado { get; set; }
    }
