using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.requestStatus.Query.List
{
    public class GetRequestStatusListCommand : IRequest<OperationResult<List<RequestStatus>>>
    {
    }
}
