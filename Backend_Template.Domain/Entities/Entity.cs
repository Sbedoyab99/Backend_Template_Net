using Backend_Template.Domain.Enums;

namespace Backend_Template.Domain.Entities
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Message { get; set; } = null!;
        public EntityState State { get; set; }
    }
}
