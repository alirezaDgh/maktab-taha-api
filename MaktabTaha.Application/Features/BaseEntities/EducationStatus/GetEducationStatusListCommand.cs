using MaktabTaha.Application.DTOs.BaseEntities.EducationStatus.List;
using MaktabTaha.Application.DTOs.BaseEntities.EducationStatus.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.EducationStatus
{
    public class GetEducationStatusListCommand : IRequest<OperationResult<List<EducationStatusListDTO>>>
    {
    }
}
