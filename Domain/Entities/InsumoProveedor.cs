namespace Domain.Entities;
    public class InsumoProveedor
    {
        public int IdInsumofk { get; set; }
        public Insumo Insumo { get; set; }
        public int IdProveedorfk { get; set; }
        public Proveedor Proveedor { get; set; }
    }
