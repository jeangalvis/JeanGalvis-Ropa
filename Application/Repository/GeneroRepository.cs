using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class GeneroRepository : GenericRepository<Genero>, IGenero
{
    private readonly TiendaRopaContext _context;
    public GeneroRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Genero> GetByIdAsync(int id){
        return await _context.Generos
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Genero>> GetAllAsync(){
        return await _context.Generos.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Genero> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Generos as IQueryable<Genero>;
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