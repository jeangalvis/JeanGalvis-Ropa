namespace API.Dtos;
    public class InventarioDto
    {
        public int Id { get; set; }
        public string CodInv { get; set; }
        public int IdPrendafk { get; set; }
        public decimal ValorVtaCop { get; set; }
        public decimal ValorVtaUsd { get; set; }
    }
