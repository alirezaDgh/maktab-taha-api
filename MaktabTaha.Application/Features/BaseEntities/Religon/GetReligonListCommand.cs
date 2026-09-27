using MaktabTaha.Application.DTOs.BaseEntities.Religon.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Religon
{
    public class GetReligonListCommand : IRequest<OperationResult<List<ReligonListDTO>>>
    {
    }
}
