using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.initialRequest.Command.Approve
{
    public class ApproveInitialRequestCommand : IRequest<OperationResult<InitialRequest>>
    {
        public int RequestNumber { get; set; } 
        public string Status { get; set; }
        public string StatusReason { get; set; }
        public DateTime ApproveDate { get; set; } = DateTime.Now;
        public string OfficerDescription { get; set; }
        public IFormFile Attachment { get; set; }
    }
    
}
