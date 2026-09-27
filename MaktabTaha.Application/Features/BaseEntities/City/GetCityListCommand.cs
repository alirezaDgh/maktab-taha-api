using MaktabTaha.Application.DTOs.BaseEntities.City.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.City
{
    public class GetCityListCommand : IRequest<OperationResult<List<CityListDTO>>>
    {
    }
}
