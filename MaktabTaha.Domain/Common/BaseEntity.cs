namespace MaktabTaha.Domain.Common
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public BaseEntity()
        {
            IsActive = true;
            IsDeleted = false;
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }
    }
}
