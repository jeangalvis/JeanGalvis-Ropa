namespace API.Dtos;
    public class ProveedorDto
    {
        public int Id { get; set; }
        public int NIT { get; set; }
        public string Nombre { get; set; }
        public int IdTipoPersonafk { get; set; }
        public int IdMunicipiofk { get; set; }
    }
