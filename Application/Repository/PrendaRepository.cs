using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class PrendaRepository : GenericRepository<Prenda>, IPrenda
{
    private readonly TiendaRopaContext _context;
    public PrendaRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Prenda> GetByIdAsync(int id){
        return await _context.Prendas
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Prenda>> GetAllAsync(){
        return await _context.Prendas.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Prenda> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Prendas as IQueryable<Prenda>;
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

        public async Task<IEnumerable<Prenda>> GetInsumosxPrenda(int codigo){
        return await _context.Prendas
                                .Include(p => p.InsumoPrendas)
                                .ThenInclude(p => p.Insumo)
                                .Where(p => p.IdPrenda == codigo)
                                .ToListAsync();
    }
}