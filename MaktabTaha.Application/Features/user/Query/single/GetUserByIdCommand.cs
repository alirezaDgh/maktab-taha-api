using MaktabTaha.Application.DTO_s.users.single;
using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.user.Query.single
{
    public class GetUserByIdCommand : IRequest<OperationResult<SingleUserDTO>>
    {
        public int Id { get; set; }
    }
}
