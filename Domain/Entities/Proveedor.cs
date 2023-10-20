namespace Domain.Entities;
    public class Proveedor : BaseEntity
    {
        public int NIT { get; set; }
        public string Nombre { get; set; }
        public int IdTipoPersonafk { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public int IdMunicipiofk { get; set; }
        public Municipio Municipio { get; set; }
        public ICollection<InsumoProveedor> InsumoProveedores { get; set; }
    }
