using AutoMapper;
using MaktabTaha.Application.Features.BaseEntities.privatenessStatus.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.privatenessStatus.Query.List
{
    public class GetPrivatenessStatusListHandler : IRequestHandler<GetPrivatenessStatusListCommand, OperationResult<List<PrivatenessStatus>>>
    {
        private readonly IPrivatenessStatusRepository _repository;
        public GetPrivatenessStatusListHandler(IPrivatenessStatusRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<PrivatenessStatus>>> Handle(GetPrivatenessStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<PrivatenessStatus>>();

            var PrivatenessStatuss = await _repository.List();

            return operation.Succedded(PrivatenessStatuss);
        }
    }
}
