namespace Domain.Entities;
    public class Empresa : BaseEntity
    {
        public string NIT { get; set; }
        public string RazonSocial { get; set; }
        public string RepresentanteLegal { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdMunicipiofk { get; set; }
        public Municipio Municipio { get; set; }
    }
