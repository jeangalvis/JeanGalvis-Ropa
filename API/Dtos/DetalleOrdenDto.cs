namespace API.Dtos;
    public class DetalleOrdenDto
    {
        public int Id { get; set; }
        public int IdOrdenfk { get; set; }
        public int IdPrendafk { get; set; }
        public int CantidadProducir { get; set; }
        public int IdColorfk { get; set; }
        public int CantidadProducida { get; set; }
        public int IdEstadofk { get; set; }
    }
