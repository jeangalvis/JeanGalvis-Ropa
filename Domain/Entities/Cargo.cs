namespace Domain.Entities;
    public class Cargo : BaseEntity
    {
        public string Descripcion { get; set; }
        public decimal SueldoBase { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
