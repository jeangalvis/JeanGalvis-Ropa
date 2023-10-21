namespace API.Dtos;
    public class EmpleadoDto
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public int IdCargofk { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdMunicipiofk { get; set; }
    }
