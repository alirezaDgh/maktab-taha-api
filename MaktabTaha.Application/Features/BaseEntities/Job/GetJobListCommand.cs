using MaktabTaha.Application.DTOs.BaseEntities.Job.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Job
{
    public class GetJobListCommand : IRequest<OperationResult<List<JobListDTO>>>
    {
    }
}
