using Domain;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RestAPI.DTOs;

[ApiController]
[Route("api/[controller]")]
public abstract class AController<TEntity, TCreateDto, TReadDto, TUpdateDto, TContext> : ControllerBase
    where TEntity : class
    where TCreateDto : class
    where TReadDto : class
    where TUpdateDto : class
    where TContext : DbContext
{
    protected readonly IRepositoryAsync<TContext, TEntity> _repository;

    protected AController(IRepositoryAsync<TContext, TEntity> repository)
    {
        _repository = repository;
    }

    [HttpPost]
    public async Task<ActionResult<TReadDto>> Create(TCreateDto dto)
    {
        var entity = dto.Adapt<TEntity>();
        var data = await _repository.CreateAsync(entity);
        return Ok(data.Adapt<TReadDto>());
        
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<TReadDto>> Read(int id)
    {
        var data = await _repository.ReadAsync(id);
        if (data == null) return NotFound();
        return Ok(data.Adapt<TReadDto>());
    }

    [HttpGet]
    public async Task<ActionResult<List<TReadDto>>> ReadAll()
    {
        var list = await _repository.ReadAllAsync();
        var dtos = list.Select(p=>p.Adapt<TReadDto>()).ToList();
        return Ok(dtos);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, TEntity t)
    {
        var data = await _repository.ReadAsync(id);
        if (data == null) return NotFound();
        await _repository.UpdateAsync(t.Adapt<TEntity>());
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public  async Task<IActionResult> Delete(int id)
    {
        var data = await _repository.ReadAsync(id);
        if (data == null) return NotFound();
        await _repository.DeleteAsync(data);
        return NoContent();
    }
}