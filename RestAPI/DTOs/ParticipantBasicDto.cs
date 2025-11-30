

    public record CreateParticipantDto(string FirstName, string LastName, DateTime BirthDate, string Email, decimal Weight, decimal Height);
    
    public record ReadParticipantDto(int id, string FirstName, string LastName, DateTime BirthDate, string Email, decimal Weight, decimal Height);
    
    public record  UpdateParticipantDto(int id, string FirstName, string LastName, DateTime BirthDate, string Email, decimal Weight);
