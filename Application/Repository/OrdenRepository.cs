using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class OrdenRepository : GenericRepository<Orden>, IOrden
{
    private readonly TiendaRopaContext _context;
    public OrdenRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Orden> GetByIdAsync(int id){
        return await _context.Ordenes
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Orden>> GetAllAsync(){
        return await _context.Ordenes.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Orden> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Ordenes as IQueryable<Orden>;
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