using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class TipoEstadoRepository : GenericRepository<TipoEstado>, ITipoEstado
{
    private readonly TiendaRopaContext _context;
    public TipoEstadoRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<TipoEstado> GetByIdAsync(int id){
        return await _context.TipoEstados
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<TipoEstado>> GetAllAsync(){
        return await _context.TipoEstados.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<TipoEstado> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.TipoEstados as IQueryable<TipoEstado>;
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