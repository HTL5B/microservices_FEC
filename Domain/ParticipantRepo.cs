using Model;

namespace Domain;

public class ParticipantRepo:ARepositoryAsync<ParticipantContext, Participant>
{
    public ParticipantRepo(ParticipantContext context) : base(context)
    {
    }
}