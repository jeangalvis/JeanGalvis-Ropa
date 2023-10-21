using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class TipoProteccionRepository : GenericRepository<TipoProteccion>, ITipoProteccion
{
    private readonly TiendaRopaContext _context;
    public TipoProteccionRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<TipoProteccion> GetByIdAsync(int id){
        return await _context.TipoProtecciones
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<TipoProteccion>> GetAllAsync(){
        return await _context.TipoProtecciones.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<TipoProteccion> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.TipoProtecciones as IQueryable<TipoProteccion>;
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