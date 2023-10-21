using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiVersion("1.0")]
[ApiVersion("1.1")]
public class PrendaController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PrendaController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    [HttpGet]
    //[Authorize(Roles = "Administrator,Employee")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<PrendaDto>>> Get1()
    {
        var appointments = await _unitOfWork.Prendas
                                    .GetAllAsync();

        return _mapper.Map<List<PrendaDto>>(appointments);
    }

    [HttpGet("{id}")]
    //[Authorize(Roles = "Administrator, Employee")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PrendaDto>> Get2(int id)
    {
        var appointment = await _unitOfWork.Prendas.GetByIdAsync(id);
        return _mapper.Map<PrendaDto>(appointment);
    }

    [HttpPost]
    //[Authorize(Roles = "Administrator, Employee")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Prenda>> Post(PrendaDto resultDto)
    {
        var result = _mapper.Map<Prenda>(resultDto);
        this._unitOfWork.Prendas.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
        {
            return BadRequest();
        }
        resultDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { id = resultDto.Id }, resultDto);
    }
    [HttpPut("{id}")]
    //[Authorize(Roles = "Administrator, Employee")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Prenda>> Put(int id, [FromBody] PrendaDto resultDto)
    {
        var result = _mapper.Map<Prenda>(resultDto);
        if (result == null)
        {
            return NotFound();
        }
        _unitOfWork.Prendas.Update(result);
        await _unitOfWork.SaveAsync();
        return result;
    }
    [HttpDelete("{id}")]
    //[Authorize(Roles = "Administrator, Employee")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _unitOfWork.Prendas.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        _unitOfWork.Prendas.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    //[Authorize(Roles = "Administrator, Employee")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<PrendaDto>>> Getpag([FromQuery] Params resultParams)
    {
        var result = await _unitOfWork.Prendas.GetAllAsync(resultParams.PageIndex, resultParams.PageSize, resultParams.Search);
        var lstResultDto = _mapper.Map<List<PrendaDto>>(result.registros);
        return new Pager<PrendaDto>(lstResultDto, result.totalRegistros, resultParams.PageIndex, resultParams.PageSize, resultParams.Search);
    }

    [HttpGet("GetInsumosxPrenda")]
    //[Authorize(Roles = "Administrator,Employee")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<InsumoxPrendaDto>>> Get3(int codigo)
    {
        var appointments = await _unitOfWork.Prendas
                                    .GetInsumosxPrenda(codigo);

        return _mapper.Map<List<InsumoxPrendaDto>>(appointments);
    }
}
