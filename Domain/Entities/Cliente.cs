namespace Domain.Entities;
    public class Cliente : BaseEntity
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int IdTipoPersonafk { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdMunicipiofk { get; set; }
        public Municipio Municipio { get; set; }
    }
