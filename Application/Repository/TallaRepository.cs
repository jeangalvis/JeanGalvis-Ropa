using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class TallaRepository : GenericRepository<Talla>, ITalla
{
    private readonly TiendaRopaContext _context;
    public TallaRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Talla> GetByIdAsync(int id){
        return await _context.Tallas
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Talla>> GetAllAsync(){
        return await _context.Tallas.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Talla> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Tallas as IQueryable<Talla>;
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