using MaktabTaha.Application.DTOs.BaseEntities.CaseType.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.CaseType
{
    public class GetCaseTypeListCommand : IRequest<OperationResult<List<CaseTypeListDTO>>>
    {
    }
}
