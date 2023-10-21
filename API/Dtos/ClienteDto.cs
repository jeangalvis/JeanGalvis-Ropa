namespace API.Dtos;
    public class ClienteDto
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int IdTipoPersonafk { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdMunicipiofk { get; set; }
    }
