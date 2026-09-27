using MaktabTaha.Application.DTOs.BaseEntities.Area.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Area
{
    public class GetAreaListCommand : IRequest<OperationResult<List<AreaListDTO>>>
    {
    }
}
