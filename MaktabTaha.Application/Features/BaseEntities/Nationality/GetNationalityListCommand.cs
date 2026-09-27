using MaktabTaha.Application.DTOs.BaseEntities.Nationality.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Nationality
{
    public class GetNationalityListCommand : IRequest<OperationResult<List<NationalityListDTO>>>
    {
    }
}
