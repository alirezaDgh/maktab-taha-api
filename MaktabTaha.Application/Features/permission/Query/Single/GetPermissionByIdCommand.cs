using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.permission.Query.Single
{
    public class GetPermissionByIdCommand : IRequest<OperationResult<Permission>>
    {
        public int Id { get; set; }
    }
}
