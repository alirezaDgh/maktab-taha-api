using MaktabTaha.Application.DTOs.initialRequests.Single;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.initialRequest.Query.Single
{
    public class GetInitialRequestByIdCommand : IRequest<OperationResult<GetInitialRequestDTO>>
    {
        public int RequestNumber { get; set; }
    }
}
