namespace API.Dtos;
    public class InsumoPrendaQuerie1Dto
    {
        public int Id { get; set; }
        public int IdInsumofk { get; set; }
        public int IdPrendafk { get; set; }
        public int Cantidad { get; set; }
        public InsumoDto Insumo { get; set; }

    }
