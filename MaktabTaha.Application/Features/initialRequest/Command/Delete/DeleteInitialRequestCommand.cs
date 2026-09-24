using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.initialRequest.Command.Delete
{
    public class DeleteInitialRequestCommand : IRequest<OperationResult<bool>>
    {
        public int RequestNumber { get; set; }
    }
}
