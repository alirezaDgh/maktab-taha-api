using MaktabTaha.Application.DTOs.users.single;
using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.user.Query.single
{
    public class GetUserByIdCommand : IRequest<OperationResult<GetUserDTO>>
    {
        public int Id { get; set; }
    }
}
