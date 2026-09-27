using MaktabTaha.Application.DTOs.BaseEntities.PhysicalStatus.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.PhysicalStatus
{
    public class GetPhysicalStatusListCommand : IRequest<OperationResult<List<PhysicalStatusListDTO>>>
    {
    }
}
