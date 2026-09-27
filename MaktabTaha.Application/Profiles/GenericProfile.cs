using AutoMapper;
using MaktabTaha.Application.DTO_s.initialRequests.List;
using MaktabTaha.Application.DTO_s.users.list;
using MaktabTaha.Application.DTO_s.users.single;
using MaktabTaha.Application.DTOs.BaseEntities.Area.List;
using MaktabTaha.Application.DTOs.BaseEntities.Bank.List;
using MaktabTaha.Application.DTOs.BaseEntities.CaseType.List;
using MaktabTaha.Application.DTOs.BaseEntities.CharityMainRole.List;
using MaktabTaha.Application.DTOs.BaseEntities.City.List;
using MaktabTaha.Application.DTOs.BaseEntities.EducationLevel.List;
using MaktabTaha.Application.DTOs.BaseEntities.EducationStatus.List;
using MaktabTaha.Application.DTOs.BaseEntities.EmploymentStatus.List;
using MaktabTaha.Application.DTOs.BaseEntities.GoodWorkType.List;
using MaktabTaha.Application.DTOs.BaseEntities.HouseHeadStatus.List;
using MaktabTaha.Application.DTOs.BaseEntities.HousingStatus.List;
using MaktabTaha.Application.DTOs.BaseEntities.Job.List;
using MaktabTaha.Application.DTOs.BaseEntities.Nationality.List;
using MaktabTaha.Application.DTOs.BaseEntities.OrphanStatus.List;
using MaktabTaha.Application.DTOs.BaseEntities.PhysicalStatus.List;
using MaktabTaha.Application.DTOs.BaseEntities.PrivatenessStatus.List;
using MaktabTaha.Application.DTOs.BaseEntities.Province.List;
using MaktabTaha.Application.DTOs.BaseEntities.Relation.List;
using MaktabTaha.Application.DTOs.BaseEntities.Religon.List;
using MaktabTaha.Application.DTOs.BaseEntities.RequestType.List;
using MaktabTaha.Application.DTOs.BaseEntities.Skill.List;
using MaktabTaha.Application.DTOs.BaseEntities.UnemploymentReason.List;
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
using MaktabTaha.Application.Features.role_permission.Command.Delete;
using MaktabTaha.Application.Features.role_permission.Command.Update;
using MaktabTaha.Application.Features.user.Command.Create;
using MaktabTaha.Application.Features.user.Command.delete;
using MaktabTaha.Application.Features.user.Command.update;
using MaktabTaha.Domain.Common;
using MaktabTaha.Domain.Entites;
using MaktabTaha.Domain.Entites.BaseEntities;

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


            CreateMap<Area, AreaListDTO>();

            CreateMap<Bank, BankListDTO>();

            CreateMap<CaseType, CaseTypeListDTO>();

            CreateMap<CharityMainRole, CharityMainRoleListDTO>();

            CreateMap<City, CityListDTO>();

            CreateMap<EducationLevel, EducationLevelListDTO>();

            CreateMap<EducationStatus, EducationStatusListDTO>();

            CreateMap<EmploymentStatus, EmploymentStatusListDTO>();

            CreateMap<GoodWorkType, GoodWorkTypeListDTO>();

            CreateMap<HouseHeadStatus, HouseHeadStatusListDTO>();

            CreateMap<HousingStatus, HousingStatusListDTO>();

            CreateMap<Job, JobListDTO>();

            CreateMap<Nationalty, NationalityListDTO>();

            CreateMap<OrphanStatus, OrphanStatusListDTO>();

            CreateMap<PhysicalStatus, PhysicalStatusListDTO>();

            CreateMap<PrivatenessStatus, PrivatenessStatusListDTO>();

            CreateMap<Province, ProvinceListDTO>();

            CreateMap<Relation, RelationListDTO>();

            CreateMap<Religon, ReligonListDTO>();

            CreateMap<RequestType, RequestTypeListDTO>();

            CreateMap<Skill, SkillListDTO>();

            CreateMap<UnemploymentReason, UnemploymentReasonListDTO>();

        }
    }
}
