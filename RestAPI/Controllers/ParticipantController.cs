using Domain;
using Microsoft.AspNetCore.Mvc;
using Model;
using RestAPI.DTOs;

namespace RestAPI.Controllers;

[Route("participant")]
public class ParticipantController : AController<Participant, CreateParticipantDto, ReadParticipantDto,UpdateParticipantDto, ParticipantContext>
{
    public ParticipantController(IRepositoryAsync<ParticipantContext, Participant> repository)
        : base(repository)
    { }

    [HttpGet("{id:int}/basic")]
    public async Task<ActionResult<ReadParticipantDto>> GetBasic(int id)
    {
        var entity = await _repository.ReadAsync(id);
        if (entity == null) return NotFound();

        var dto = new ReadParticipantDto(
            entity.ParticipantId,
            entity.FirstName,
            entity.LastName,
            entity.BirthDate,
            entity.Email,
            entity.Weight,
            entity.Height
        );


        return Ok(dto);
    }
    
    
}