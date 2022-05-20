using Entities.Base;

namespace Entities.Users
{
    public abstract class UserEntity : IEntity, IDateTimeCreateSaveable
    {
        public int Id { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Middlename { get; set; } = string.Empty;
        public string? Lastname { get; set; } = null;
        public string Email { get; set; } = default!;
        public string? login { get; set; }
        public string Password { get; set; } = default!;
    }
}
