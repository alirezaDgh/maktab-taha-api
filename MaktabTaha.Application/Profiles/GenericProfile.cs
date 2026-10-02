using AutoMapper;
using MaktabTaha.Application.DTO_s.Requests.List;
using MaktabTaha.Application.DTO_s.users.list;
using MaktabTaha.Application.DTO_s.users.single;
using MaktabTaha.Application.Features.request.Command.Approve;
using MaktabTaha.Application.Features.request.Command.Create;
using MaktabTaha.Application.Features.request.Command.Update;
using MaktabTaha.Application.Features.permission.Command.Create;
using MaktabTaha.Application.Features.permission.Command.Delete;
using MaktabTaha.Application.Features.permission.Command.Update;
using MaktabTaha.Application.Features.role.Command.create;
using MaktabTaha.Application.Features.role.Command.delete;
using MaktabTaha.Application.Features.role.Command.update;
using MaktabTaha.Application.Features.role_permission.Command.Create;
using MaktabTaha.Application.Features.role_permission.Command.Delete;
using MaktabTaha.Application.Features.role_permission.Command.Update;
using MaktabTaha.Application.Features.user.Command.Create;
using MaktabTaha.Application.Features.user.Command.delete;
using MaktabTaha.Application.Features.user.Command.update;
using MaktabTaha.Domain.Common;
using MaktabTaha.Domain.Entites;
using MaktabTaha.Application.DTO_s.Requests.Single;

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
                .ForMember(dest => dest.LastEntry, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());
            CreateMap<DeleteUserCommand, User>();
            CreateMap<AuthViewModel, User>();

            CreateMap<User, UserListDTO>();
            CreateMap<User, SingleUserDTO>();

            //PERMISSION
            CreateMap<CreatePermissionCommand, Permission>();
            CreateMap<UpdatePermissionCommand, Permission>();
            CreateMap<DeletePermissionCommand, Permission>();

            //ROLE PERMISSION
            CreateMap<CreateRolePermissionCommand, RolePermission>();
            CreateMap<UpdateRolePermissionCommand, RolePermission>();
            CreateMap<DeleteRolePermissionCommand, RolePermission>();

            //InitialRequest
            CreateMap<CreateRequestCommand, Request>();
            CreateMap<UpdateRequestCommand, Request>();
            CreateMap<Request, RequestListDTO>();
            CreateMap<Request, SingleRequestDTO>();
            CreateMap<ApproveRequestCommand, Request>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Attachment, opt => opt.Ignore());

            //ROLE
            CreateMap<CreateRoleCommand, Role>();
            CreateMap<UpdateRoleCommand, Role>();
            CreateMap<DeleteRoleCommand, Role>();


            
        }
    }
}
