using MaktabTaha.Application.DTOs.BaseEntities.RequestType.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.RequestType
{
    public class GetRequestTypeListCommand : IRequest<OperationResult<List<RequestTypeListDTO>>>
    {
    }
}
