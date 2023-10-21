using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class ColorRepository : GenericRepository<Color>, IColor
{
    private readonly TiendaRopaContext _context;
    public ColorRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<Color> GetByIdAsync(int id){
        return await _context.Colores
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<Color>> GetAllAsync(){
        return await _context.Colores.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<Color> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.Colores as IQueryable<Color>;
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