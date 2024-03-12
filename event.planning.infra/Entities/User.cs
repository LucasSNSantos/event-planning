using infra.Interfaces.Generic;

namespace infra.Entities
{
    public class User:IEntity
    {
        public int Id => Id;
        public string? Name { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? LastLogin { get; set; }

    }
}
