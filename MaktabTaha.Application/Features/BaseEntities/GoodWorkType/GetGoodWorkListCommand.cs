using MaktabTaha.Application.DTOs.BaseEntities.GoodWorkType.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.GoodWorkType
{
    public class GetGoodWorkTypeListCommand : IRequest<OperationResult<List<GoodWorkTypeListDTO>>>
    {
    }
}
