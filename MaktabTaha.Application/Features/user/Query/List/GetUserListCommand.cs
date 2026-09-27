using MaktabTaha.Application.DTO_s.users.list;
using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.user.Query.List
{
    public class GetUserListCommand : IRequest<OperationResult<List<UserListDTO>>>
    {
    }
}
