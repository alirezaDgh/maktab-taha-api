using MaktabTaha.Application.DTOs.BaseEntities.HouseHeadStatusDesc.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.HouseHeadStatusDesc
{
    public class GetHouseHeadStatusDescListCommand : IRequest<OperationResult<List<HouseHeadStatusDescListDTO>>>
    {
    }
}
