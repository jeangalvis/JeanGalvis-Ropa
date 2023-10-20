namespace Domain.Entities;
    public class Venta : BaseEntity
    {
        public DateTime Fecha { get; set; }
        public int IdEmpleadofk { get; set; }
        public Empleado Empleado { get; set; }
        public int IdClientefk { get; set; }
        public Cliente Cliente { get; set; }
        public int IdFormaPagofk { get; set; }
        public FormaPago FormaPago { get; set; }
        public ICollection<DetalleVenta> DetalleVentas { get; set; }
    }
