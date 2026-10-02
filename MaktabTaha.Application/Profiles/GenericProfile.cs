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
            CreateMap<Request, RequestListDTO>()
                .ForMember(
                    dest => dest.RequestTypeTitle,
                    opt => opt.MapFrom(src => src.RequestType != null
                        ? src.RequestType.RequestTypeName
                        : null)
                )
                .ForMember(
                    dest => dest.HouseHeadStatusTitle,
                    opt => opt.MapFrom(src => src.HouseHeadStatus != null
                        ? src.HouseHeadStatus.Name
                        : null)
                )
                .ForMember(
                    dest => dest.RefererName,
                    opt => opt.MapFrom(src => src.Referer != null
                        ? $"{src.Referer.Firstname} {src.Referer.Lastname}"
                        : null)
                )
                .ForMember(
                    dest => dest.NationaltyTitle,
                    opt => opt.MapFrom(src => src.Nationalty != null
                        ? src.Nationalty.NationalityName
                        : null)
                )
                .ForMember(
                    dest => dest.ProvinceTitle,
                    opt => opt.MapFrom(src => src.Province != null
                        ? src.Province.ProvinceName
                        : null)
                )
                .ForMember(
                    dest => dest.CityTitle,
                    opt => opt.MapFrom(src => src.City != null
                        ? src.City.CityName
                        : null)
                )
                .ForMember(
                    dest => dest.AreaTitle,
                    opt => opt.MapFrom(src => src.Area != null
                        ? src.Area.AreaName
                        : null)
                )
                .ForMember(
                    dest => dest.ReligonTitle,
                    opt => opt.MapFrom(src => src.Religon != null
                        ? src.Religon.ReligonName
                        : null)
                )
                .ForMember(
                    dest => dest.RequestStatusTitle,
                    opt => opt.MapFrom(src => src.RequestStatus != null
                        ? src.RequestStatus.RequestStatusName
                        : null)
                )
                .ForMember(
                    dest => dest.FullName,
                    opt => opt.MapFrom(src =>
                        $"{src.ClientFirstName} {src.ClientLastName}".Trim()
                    )
                ); 
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
