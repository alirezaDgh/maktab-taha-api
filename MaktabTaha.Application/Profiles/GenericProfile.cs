using AutoMapper;
using MaktabTaha.Application.DTOs.users.list;
using MaktabTaha.Application.DTOs.users.single;
using MaktabTaha.Application.Features.permission.Command.Create;
using MaktabTaha.Application.Features.permission.Command.Delete;
using MaktabTaha.Application.Features.permission.Command.Update;
using MaktabTaha.Application.Features.user.Command.Create;
using MaktabTaha.Application.Features.user.Command.delete;
using MaktabTaha.Application.Features.user.Command.update;
using MaktabTaha.Application.Features.user_permission.Command.Create;
using MaktabTaha.Application.Features.user_permission.Command.Delete;
using MaktabTaha.Application.Features.user_permission.Command.Update;
using MaktabTaha.Domain.Entites;
using System.Security;

namespace MaktabTaha.Application.Profiles
{
    public class GenericProfile : Profile
    {
        public GenericProfile()
        {
            //USER
            CreateMap<CreateUserCommand, User>();
            CreateMap<UpdateUserCommand, User>()
                .ForMember(dest => dest.UserName, opt => opt.Ignore())
                .ForMember(dest => dest.UserPermissions, opt => opt.Ignore())
                .ForMember(dest => dest.LastEntry, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());
            CreateMap<DeleteUserCommand, User>();

            CreateMap<User, UserListDTO>();
            CreateMap<User, GetUserDTO>();

            //PERMISSION
            CreateMap<CreatePermissionCommand, Permission>();
            CreateMap<UpdatePermissionCommand, Permission>();
            CreateMap<DeletePermissionCommand, Permission>();

            //USER PERMISSION
            CreateMap<CreateUserPermissionCommand, UserPermission>();
            CreateMap<UpdateUserPermissionCommand, UserPermission>();
            CreateMap<DeleteUserPermissionCommand, UserPermission>();


        }
    }
}
