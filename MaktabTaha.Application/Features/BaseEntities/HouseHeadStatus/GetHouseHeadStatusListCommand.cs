using MaktabTaha.Application.DTOs.BaseEntities.HouseHeadStatus.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.HouseHeadStatus
{
    public class GetHouseHeadStatusListCommand : IRequest<OperationResult<List<HouseHeadStatusListDTO>>>
    {
    }
}
