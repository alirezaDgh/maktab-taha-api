using MaktabTaha.Application.DTOs.BaseEntities.Relation.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Relation
{
    public class GetRelationListCommand : IRequest<OperationResult<List<RelationListDTO>>>
    {
    }
}
