using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class DetalleVentaRepository : GenericRepository<DetalleVenta>, IDetalleVenta
{
    private readonly TiendaRopaContext _context;
    public DetalleVentaRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<DetalleVenta> GetByIdAsync(int id){
        return await _context.DetalleVentas
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<DetalleVenta>> GetAllAsync(){
        return await _context.DetalleVentas.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<DetalleVenta> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.DetalleVentas as IQueryable<DetalleVenta>;
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