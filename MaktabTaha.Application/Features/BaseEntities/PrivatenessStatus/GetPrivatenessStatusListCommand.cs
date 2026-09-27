using MaktabTaha.Application.DTOs.BaseEntities.PrivatenessStatus.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.PrivatenessStatus
{
    public class GetPrivatenessStatusListCommand : IRequest<OperationResult<List<PrivatenessStatusListDTO>>>
    {
    }
}
