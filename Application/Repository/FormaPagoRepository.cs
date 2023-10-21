using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class FormaPagoRepository : GenericRepository<FormaPago>, IFormaPago
{
    private readonly TiendaRopaContext _context;
    public FormaPagoRepository(TiendaRopaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<FormaPago> GetByIdAsync(int id){
        return await _context.FormaPagos
                            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public override async Task<IEnumerable<FormaPago>> GetAllAsync(){
        return await _context.FormaPagos.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<FormaPago> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.FormaPagos as IQueryable<FormaPago>;
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