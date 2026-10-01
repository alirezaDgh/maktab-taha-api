using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.request.Command.Approve
{
    public class ApproveRequestHandler : IRequestHandler<ApproveRequestCommand, OperationResult<Request>>
    {
        private readonly IRequestRepository _repository;
        private readonly IMapper _mapper;

        public ApproveRequestHandler(IRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<Request>> Handle(ApproveRequestCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<Request>();

            var initRequest = await _repository.SingleOrDefault(x => x.Id == request.Id);
            if (initRequest == null) return operation.Failure("درخواست اولیه یافت نشد");

            _mapper.Map(request, initRequest);

            if (request.Attachment != null)
            {
                using var memoryStream = new MemoryStream();

                await request.Attachment.CopyToAsync(
                    memoryStream,
                    cancellationToken
                    );

                initRequest.Attachment = memoryStream.ToArray();
            }

            await _repository.SaveChanges();

            return operation.Succedded(initRequest);
        }
    }
}
