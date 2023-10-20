namespace Domain.Entities;
    public class Orden : BaseEntity
    {
        public DateTime Fecha { get; set; }
        public int IdEmpleadofk { get; set; }
        public Empleado Empleado { get; set; }
        public int IdClientefk { get; set; }
        public Cliente Cliente { get; set; }
        public int IdEstadofk { get; set; }
        public Estado Estado { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
    }
