using MaktabTaha.Application.DTOs.BaseEntities.Province.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Province
{
    public class GetProvinceListCommand : IRequest<OperationResult<List<ProvinceListDTO>>>
    {
    }
}
