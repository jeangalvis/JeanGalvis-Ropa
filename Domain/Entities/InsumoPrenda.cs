namespace Domain.Entities;
    public class InsumoPrenda
    {
        public int IdInsumofk { get; set; }
        public Insumo Insumo { get; set; }
        public int IdPrendafk { get; set; }
        public Prenda Prenda { get; set; }
    }
