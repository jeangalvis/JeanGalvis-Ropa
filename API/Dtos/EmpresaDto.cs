namespace API.Dtos;
    public class EmpresaDto
    {
        public int Id { get; set; }
        public string NIT { get; set; }
        public string RazonSocial { get; set; }
        public string RepresentanteLegal { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdMunicipiofk { get; set; }
    }
