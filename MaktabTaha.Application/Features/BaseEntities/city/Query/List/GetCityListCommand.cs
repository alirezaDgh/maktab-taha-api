using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.city.Query.List
{
    public class GetCityListCommand : IRequest<OperationResult<List<City>>>
    {
        public int ProvinceId { get; set; }
    }
}
