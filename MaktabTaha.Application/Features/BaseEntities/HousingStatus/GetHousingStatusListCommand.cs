using MaktabTaha.Application.DTOs.BaseEntities.HousingStatus.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.HousingStatus
{
    public class GetHousingStatusListCommand : IRequest<OperationResult<List<HousingStatusListDTO>>>
    {
    }
}
