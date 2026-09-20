using AutoMapper;
using MaktabTaha.Application.DTOs.users.list;
using MaktabTaha.Application.DTOs.users.single;
using MaktabTaha.Application.Features.user.Command.Create;
using MaktabTaha.Application.Features.user.Command.delete;
using MaktabTaha.Application.Features.user.Command.update;
using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Application.Profiles
{
    public class GenericProfile : Profile
    {
        public GenericProfile()
        {
            CreateMap<CreateUserCommand, User>();
            CreateMap<UpdateUserCommand, User>()
                .ForMember(dest => dest.UserName, opt => opt.Ignore())
                .ForMember(dest => dest.UserPermissions, opt => opt.Ignore())
                .ForMember(dest => dest.LastEntry, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());
            CreateMap<DeleteUserCommand, User>();

            CreateMap<User, UserListDTO>();
            CreateMap<User, GetUserDTO>();
        }
    }
}
