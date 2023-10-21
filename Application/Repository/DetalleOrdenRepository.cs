using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class DetalleOrdenRepository : GenericRepository<DetalleOrden>, IDetalleOrden
{
    private readonly TiendaRopaContext _context;
    public DetalleOrdenRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<DetalleOrden> GetByIdAsync(int id){
        return await _context.DetalleOrdenes
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<DetalleOrden>> GetAllAsync(){
        return await _context.DetalleOrdenes.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<DetalleOrden> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.DetalleOrdenes as IQueryable<DetalleOrden>;
        if (!string.IsNullOrEmpty(search))
        {
            //query = query.Where(p => p.Nombre.ToLower().Contains(search));
        }
        var totalRegistros = await query.CountAsync();
        var registros = await query
                                 .Skip((pageIndex - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToListAsync();
        return (totalRegistros, registros);
    }
}