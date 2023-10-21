using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class InventarioRepository : GenericRepository<Inventario>, IInventario
{
    private readonly TiendaRopaContext _context;
    public InventarioRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Inventario> GetByIdAsync(int id){
        return await _context.Inventarios
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Inventario>> GetAllAsync(){
        return await _context.Inventarios.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Inventario> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Inventarios as IQueryable<Inventario>;
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