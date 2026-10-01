using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.charityMainRole.Query.List
{
    public class GetCharityMainRoleListCommand : IRequest<OperationResult<List<CharityMainRole>>>
    {
    }
}
