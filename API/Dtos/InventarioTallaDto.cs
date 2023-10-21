namespace API.Dtos;
    public class InventarioTallaDto
    {
        public int Id { get; set; }
        public int IdInventariofk { get; set; }
        public int IdTallafk { get; set; }
        public int Cantidad { get; set; }
    }
