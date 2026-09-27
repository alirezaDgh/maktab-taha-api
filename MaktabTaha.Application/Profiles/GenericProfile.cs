using AutoMapper;
using MaktabTaha.Application.Features.initialRequest.Command.Approve;
using MaktabTaha.Application.Features.initialRequest.Command.Create;
using MaktabTaha.Application.Features.initialRequest.Command.Update;
using MaktabTaha.Application.Features.permission.Command.Create;
using MaktabTaha.Application.Features.permission.Command.Delete;
using MaktabTaha.Application.Features.permission.Command.Update;
using MaktabTaha.Application.Features.role.Command.create;
using MaktabTaha.Application.Features.role.Command.delete;
using MaktabTaha.Application.Features.role.Command.update;
using MaktabTaha.Application.Features.role_permission.Command.Create;
using MaktabTaha.Application.Features.user.Command.Create;
using MaktabTaha.Application.Features.user.Command.delete;
using MaktabTaha.Application.Features.user.Command.update;
using MaktabTaha.Application.Features.role_permission.Command.Delete;
using MaktabTaha.Application.Features.role_permission.Command.Update;
using MaktabTaha.Domain.Common;
using MaktabTaha.Domain.Entites;
using MaktabTaha.Application.DTO_s.users.list;
using MaktabTaha.Application.DTO_s.users.single;
using MaktabTaha.Application.DTO_s.initialRequests.List;
using MaktabTaha.Domain.Entites.BaseEntities;
using MaktabTaha.Application.DTOs.BaseEntities.Area.List;
using MaktabTaha.Application.DTOs.BaseEntities.City.List;
using MaktabTaha.Application.DTOs.BaseEntities.Province.List;
using MaktabTaha.Application.DTOs.BaseEntities.Religon.List;
using MaktabTaha.Application.DTOs.BaseEntities.Nationality.List;

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
            CreateMap<User, GetUserDTO>();

            //PERMISSION
            CreateMap<CreatePermissionCommand, Permission>();
            CreateMap<UpdatePermissionCommand, Permission>();
            CreateMap<DeletePermissionCommand, Permission>();

            //ROLE PERMISSION
            CreateMap<CreateRolePermissionCommand, RolePermission>();
            CreateMap<UpdateRolePermissionCommand, RolePermission>();
            CreateMap<DeleteRolePermissionCommand, RolePermission>();

            //InitialRequest
            CreateMap<CreateInitialRequestCommand, InitialRequest>();
            CreateMap<UpdateInitialRequestCommand, InitialRequest>();
            CreateMap<InitialRequest, InitialRequestListDTO>();
            CreateMap<InitialRequest, GetUserDTO>();
            CreateMap<ApproveInitialRequestCommand, InitialRequest>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Attachment, opt => opt.Ignore());

            //ROLE
            CreateMap<CreateRoleCommand, Role>();
            CreateMap<UpdateRoleCommand, Role>();
            CreateMap<DeleteRoleCommand, Role>();


            //Base Entities

            //Area
            CreateMap<Area, AreaListDTO>();


            CreateMap<City, CityListDTO>();


            CreateMap<Province, ProvinceListDTO>();
            CreateMap<Religon, ReligonListDTO>();
            CreateMap<Nationalty, NationalityListDTO>();

        }
    }
}
