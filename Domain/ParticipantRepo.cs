using Model;

namespace Domain;

public class ParticipantRepo:ARepositoryAsync<ParticipantContext, ParticipantContext>
{
    public ParticipantRepo(ParticipantContext context) : base(context)
    {
    }
}