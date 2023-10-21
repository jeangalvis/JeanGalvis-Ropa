namespace API.Dtos;
    public class InsumoxPrendaDto
    {
        public int Id { get; set; }
        public int IdPrenda { get; set; }
        public string Nombre { get; set; }
        public decimal ValorUnitCop { get; set; }
        public decimal ValorUnitUsd { get; set; }
        public int IdEstadofk { get; set; }
        public int IdTipoProteccionfk { get; set; }
        public int IdGenerofk { get; set; }
        public List<InsumoPrendaQuerie1Dto> InsumoPrendas { get; set; }
    }
