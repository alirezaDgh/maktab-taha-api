using MaktabTaha.Application.DTO_s.initialRequests.Single;
using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.initialRequest.Query.Single
{
    public class GetInitialRequestByIdCommand : IRequest<OperationResult<GetInitialRequestDTO>>
    {
        public int Id
        { get; set; }
    }
}
