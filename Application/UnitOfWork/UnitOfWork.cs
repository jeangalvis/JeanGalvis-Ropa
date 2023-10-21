using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly TiendaRopaContext context;
    public ICargo _cargo;
    public ICliente _cliente;
    public IColor _color;
    public IDepartamento _departamento;
    public IDetalleOrden _detalleOrden;
    public IDetalleVenta _detalleVenta;
    public IEmpleado _empleado;
    public IEmpresa _empresa;
    public IEstado _estado;
    public IFormaPago _formaPago;
    public IGenero _genero;
    public IInsumo _insumo;
    public IInsumoPrenda _insumoPrenda;
    public IInventario _inventario;
    public IInventarioTalla _inventarioTalla;
    public IMunicipio _municipio;
    public IOrden _orden;
    public IPais _pais;
    public IPrenda _prenda;
    public IProveedor _proveedor;
    public IRol _rol;
    public ITalla _talla;
    public ITipoEstado _tipoEstado;
    public ITipoPersona _tipoPersona;
    public ITipoProteccion _tipoProteccion;
    public IUser _user;
    public IVenta _venta;
    public UnitOfWork(TiendaRopaContext _context)
    {
        context = _context;
    }

    public ICargo Cargos {
        get{
            if(_cargo == null){
                _cargo = new CargoRepository(context);
            }
            return _cargo;
        }
    }

    public ICliente Clientes{
        get{
            if(_cliente == null){
                _cliente = new ClienteRepository(context);
            }
            return _cliente;
        }
    }

    public IColor Colores{
        get{
            if(_color == null){
                _color = new ColorRepository(context);
            }
            return _color;
        }
    }

    public IDepartamento Departamentos{
        get{
            if(_departamento == null){
                _departamento = new DepartamentoRepository(context);
            }
            return _departamento;
        }
    }

    public IDetalleOrden DetalleOrdenes{
        get{
            if(_detalleOrden == null){
                _detalleOrden = new DetalleOrdenRepository(context);
            }
            return _detalleOrden;
        }
    }

    public IEmpleado Empleados{
        get{
            if(_empleado == null){
                _empleado = new EmpleadoRepository(context);
            }
            return _empleado;
        }
    }

    public IEmpresa Empresas{
        get{
            if(_empresa == null){
                _empresa = new EmpresaRepository(context);
            }
            return _empresa;
        }
    }

    public IEstado Estados{
        get{
            if(_estado == null){
                _estado = new EstadoRepository(context);
            }
            return _estado;
        }
    }

    public IFormaPago FormaPagos{
        get{
            if(_formaPago == null){
                _formaPago = new FormaPagoRepository(context);
            }
            return _formaPago;
        }
    }

    public IGenero Generos{
        get{
            if(_genero == null){
                _genero = new GeneroRepository(context);
            }
            return _genero;
        }
    }

    public IInsumo Insumos{
        get{
            if(_insumo == null){
                _insumo = new InsumoRepository(context);
            }
            return _insumo;
        }
    }

    public IInsumoPrenda InsumoPrendas{
        get{
            if(_insumoPrenda == null){
                _insumoPrenda = new InsumoPrendaRepository(context);
            }
            return _insumoPrenda;
        }
    }

    public IInventario Inventarios{
        get{
            if(_inventario == null){
                _inventario = new InventarioRepository(context);
            }
            return _inventario;
        }
    }

    public IInventarioTalla InventarioTallas{
        get{
            if(_inventarioTalla == null){
                _inventarioTalla = new InventarioTallaRepository(context);
            }
            return _inventarioTalla;
        }
    }

    public IMunicipio Municipios{
        get{
            if(_municipio == null){
                _municipio = new MunicipioRepository(context);
            }
            return _municipio;
        }
    }

    public IOrden Ordenes{
        get{
            if(_orden == null){
                _orden = new OrdenRepository(context);
            }
            return _orden;
        }
    }

    public IPais Paises{
        get{
            if(_pais == null){
                _pais = new PaisRepository(context);
            }
            return _pais;
        }
    }

    public IPrenda Prendas{
        get{
            if(_prenda == null){
                _prenda = new PrendaRepository(context);
            }
            return _prenda;
        }
    }

    public IProveedor Proveedores{
        get{
            if(_proveedor == null){
                _proveedor = new ProveedorRepository(context);
            }
            return _proveedor;
        }
    }

    public IRol Rols{
        get{
            if(_rol == null){
                _rol = new RolRepository(context);
            }
            return _rol;
        }
    }

    public ITalla Tallas{
        get{
            if(_talla == null){
                _talla = new TallaRepository(context);
            }
            return _talla;
        }
    }

    public ITipoEstado TipoEstados{
        get{
            if(_tipoEstado == null){
                _tipoEstado = new TipoEstadoRepository(context);
            }
            return _tipoEstado;
        }
    }

    public ITipoPersona TipoPersonas{
        get{
            if(_tipoPersona == null){
                _tipoPersona = new TipoPersonaRepository(context);
            }
            return _tipoPersona;
        }
    }

    public ITipoProteccion TipoProtecciones{
        get{
            if(_tipoProteccion == null){
                _tipoProteccion = new TipoProteccionRepository(context);
            }
            return _tipoProteccion;
        }
    }

    public IUser Users{
        get{
            if(_user == null){
                _user = new UserRepository(context);
            }
            return _user;
        }
    }

    public IVenta Ventas{
        get{
            if(_venta == null){
                _venta = new VentaRepository(context);
            }
            return _venta;
        }
    }

    public void Dispose()
    {
        context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await context.SaveChangesAsync();
    }
}
