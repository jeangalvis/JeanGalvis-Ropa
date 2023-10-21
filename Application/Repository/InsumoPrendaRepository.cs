using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class InsumoPrendaRepository : GenericRepository<InsumoPrenda>, IInsumoPrenda
{
    private readonly TiendaRopaContext _context;
    public InsumoPrendaRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<InsumoPrenda> GetByIdAsync(int id){
        return await _context.InsumoPrendas
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<InsumoPrenda>> GetAllAsync(){
        return await _context.InsumoPrendas.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<InsumoPrenda> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.InsumoPrendas as IQueryable<InsumoPrenda>;
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