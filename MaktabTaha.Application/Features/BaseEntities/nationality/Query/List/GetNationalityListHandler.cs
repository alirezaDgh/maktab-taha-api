using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.nationality.Query.List
{
    public class GetNationalityListHandler : IRequestHandler<GetNationalityListCommand, OperationResult<List<Nationality>>>
    {
        private readonly INationalityRepository _repository;

        public GetNationalityListHandler(INationalityRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Nationality>>> Handle(GetNationalityListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<Nationality>>();

            var Nationalities = await _repository.List();

            return operation.Succedded(Nationalities);
        }
    }
}
