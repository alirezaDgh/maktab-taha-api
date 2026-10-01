using MaktabTaha.Application.DTO_s.Requests.Single;
using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.request.Query.Single
{
    public class GetRequestByIdCommand : IRequest<OperationResult<GetRequestDTO>>
    {
        public int Id
        { get; set; }
    }
}
