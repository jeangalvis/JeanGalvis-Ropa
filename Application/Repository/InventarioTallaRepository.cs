using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class InventarioTallaRepository : GenericRepository<InventarioTalla>, IInventarioTalla
{
    private readonly TiendaRopaContext _context;
    public InventarioTallaRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<InventarioTalla> GetByIdAsync(int id){
        return await _context.InventarioTallas
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<InventarioTalla>> GetAllAsync(){
        return await _context.InventarioTallas.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<InventarioTalla> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.InventarioTallas as IQueryable<InventarioTalla>;
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