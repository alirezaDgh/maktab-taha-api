using MaktabTaha.Application.Helpers;
using MediatR;
using MaktabTaha.Application.DTOs.initialRequests.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.initialRequest.Query.List
{
    public class GetInitialRequestListCommand : IRequest<OperationResult<List<InitialRequestListDTO>>>
    {

    }
}
