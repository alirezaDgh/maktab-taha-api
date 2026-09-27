using MaktabTaha.Application.DTOs.BaseEntities.EducationLevel.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.EducationLevel
{
    public class GetEducationLevelListCommand : IRequest<OperationResult<List<EducationLevelListDTO>>>
    {
    }
}
