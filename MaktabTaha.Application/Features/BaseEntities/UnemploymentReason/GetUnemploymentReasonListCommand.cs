using MaktabTaha.Application.DTOs.BaseEntities.UnemploymentReason.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.UnemploymentReason
{
    public class GetUnemploymentReasonListCommand : IRequest<OperationResult<List<UnemploymentReasonListDTO>>>
    {
    }
}
