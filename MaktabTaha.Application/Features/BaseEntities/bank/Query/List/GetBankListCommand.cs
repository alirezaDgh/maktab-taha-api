using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.bank.Query.List
{
    public class GetBankListCommand : IRequest<OperationResult<List<Bank>>>
    {
    }
}
