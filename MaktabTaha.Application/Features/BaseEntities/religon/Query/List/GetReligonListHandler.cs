using AutoMapper;
using MaktabTaha.Application.Features.BaseEntities.religon.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.religon.Query.List
{
    public class GetReligonListHandler : IRequestHandler<GetReligonListCommand, OperationResult<List<Religon>>>
    {
        private readonly IReligonRepository _repository;
        public GetReligonListHandler(IReligonRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Religon>>> Handle(GetReligonListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<Religon>>();

            var Religons = await _repository.List();

            return operation.Succedded(Religons);
        }
    }
}
