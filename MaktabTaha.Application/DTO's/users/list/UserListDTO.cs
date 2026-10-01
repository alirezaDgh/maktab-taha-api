using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.users.list
{
    public class UserListDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public DateTime? LastEntry { get; set; }
        public bool IsActive { get; set; }  
        public UserRoleDTO Role { get; set; } = null!;

    }

    public class UserRoleDTO
    {
        public int RoleId { get; set; }
        public string RoleTitle { get; set; } = null!;
        public List<UserPermissionDTO> Permissions { get; set; } = new();
    }

    public class UserPermissionDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Key { get; set; } = null!;
        public string? Path { get; set; }
        public string? Icon { get; set; }
        public int? ParentId { get; set; }
        public int SortOrder { get; set; }
        public List<UserPermissionDTO> Children { get; set; } = new();
    }
}

