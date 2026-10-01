using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.request.Command.Delete
{
    public class DeleteRequestCommand : IRequest<OperationResult<bool>>
    {
        public int Id { get; set; }
    }
}
