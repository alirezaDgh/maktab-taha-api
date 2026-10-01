using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.bank.Query.List
{
    public class GetBankListHandler : IRequestHandler<GetBankListCommand, OperationResult<List<Bank>>>
    {
        private readonly IBankRepository _repository;

        public GetBankListHandler(IBankRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Bank>>> Handle(GetBankListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<Bank>>();

            var banks = await _repository.List();
            return operation.Succedded(banks);
        }
    }
}
