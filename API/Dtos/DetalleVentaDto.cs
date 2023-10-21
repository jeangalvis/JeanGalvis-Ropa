namespace API.Dtos;
    public class DetalleVentaDto
    {
        public int Id { get; set; }
        public int IdVentafk { get; set; }
        public int IdInventariofk { get; set; }
        public int IdTallafk { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorUnit { get; set; }
    }
