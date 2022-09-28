using Core.Persistence.Repositories;

namespace Domain.Entities;

public class ProgrammingLanguage : Entity
{
    public ProgrammingLanguage()
    {
        
    }
    public ProgrammingLanguage(int id,string name) : this()
    {
        Name = name;
        Id = id;
    }

    public string Name { get; set; }
}