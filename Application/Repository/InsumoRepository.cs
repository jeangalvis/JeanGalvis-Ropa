using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class InsumoRepository : GenericRepository<Insumo>, IInsumo
{
    private readonly TiendaRopaContext _context;
    public InsumoRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Insumo> GetByIdAsync(int id){
        return await _context.Insumos
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Insumo>> GetAllAsync(){
        return await _context.Insumos.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Insumo> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Insumos as IQueryable<Insumo>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.Nombre.ToLower().Contains(search));
        }
        var totalRegistros = await query.CountAsync();
        var registros = await query
                                 .Skip((pageIndex - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToListAsync();
        return (totalRegistros, registros);
    }

}