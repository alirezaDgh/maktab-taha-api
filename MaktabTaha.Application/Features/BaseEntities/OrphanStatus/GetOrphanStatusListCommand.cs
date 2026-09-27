using MaktabTaha.Application.DTOs.BaseEntities.OrphanStatus.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.OrphanStatus
{
    public class GetOrphanStatusListCommand : IRequest<OperationResult<List<OrphanStatusListDTO>>>
    {
    }
}
