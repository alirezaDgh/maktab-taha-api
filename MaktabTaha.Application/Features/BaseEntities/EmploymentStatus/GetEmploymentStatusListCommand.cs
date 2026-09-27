using MaktabTaha.Application.DTOs.BaseEntities.EmploymentStatus.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.EmploymentStatus
{
    public class GetEmploymentStatusListCommand : IRequest<OperationResult<List<EmploymentStatusListDTO>>>
    {
    }
}
