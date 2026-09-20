namespace MaktabTaha.Application.DTOs.users.single
{
    class GetUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public DateTime LastEntry { get; set; }
        public bool IsActive { get; set; }

    }
}
