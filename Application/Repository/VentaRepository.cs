using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class VentaRepository : GenericRepository<Venta>, IVenta
{
    private readonly TiendaRopaContext _context;
    public VentaRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Venta> GetByIdAsync(int id){
        return await _context.Ventas
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Venta>> GetAllAsync(){
        return await _context.Ventas.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Venta> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Ventas as IQueryable<Venta>;
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