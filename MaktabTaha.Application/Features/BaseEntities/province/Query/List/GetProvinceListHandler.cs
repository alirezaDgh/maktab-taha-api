using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.province.Query.List
{
    public class GetProvinceListHandler : IRequestHandler<GetProvinceListCommand, OperationResult<List<Province>>>
    {
        private readonly IProvinceRepository _repository;
        public GetProvinceListHandler(IProvinceRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Province>>> Handle(GetProvinceListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<Province>>();

            var Provinces = await _repository.List();

            return operation.Succedded(Provinces);
        }
    }
}
