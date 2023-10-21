using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class MunicipioRepository : GenericRepository<Municipio>, IMunicipio
{
    private readonly TiendaRopaContext _context;
    public MunicipioRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Municipio> GetByIdAsync(int id){
        return await _context.Municipios
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Municipio>> GetAllAsync(){
        return await _context.Municipios.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Municipio> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Municipios as IQueryable<Municipio>;
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