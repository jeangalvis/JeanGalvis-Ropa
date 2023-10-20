namespace Domain.Entities;
    public class InsumoPrenda : BaseEntity
    {
        public int IdInsumofk { get; set; }
        public Insumo Insumo { get; set; }
        public int IdPrendafk { get; set; }
        public Prenda Prenda { get; set; }
        public int Cantidad { get; set; }
    }
