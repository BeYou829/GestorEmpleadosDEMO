namespace CRUD.Core.Domain.Common
{
    public class BaseAuditable
    {
        public int Id { get; set; }
        public DateTime CreatedAt => DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
